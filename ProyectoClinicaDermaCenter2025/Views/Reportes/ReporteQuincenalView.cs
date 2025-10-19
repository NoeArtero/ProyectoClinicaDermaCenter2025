using Microsoft.Data.SqlClient; 
using Microsoft.Reporting.NETCore;
using ProyectoClinicaDermaCenter2025.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;                         
using System.Windows.Forms;

namespace ProyectoClinicaDermaCenter2025.Views.Reportes
{
    public partial class ReporteQuincenalView : Form
    {
        private bool _buscando = false;
        private bool _exportando = false;
        private DataTable _dtResumen;      
        private DataTable _dtFacturas;
        private DataTable _dtPagos;

        private (DateTime Desde, DateTime HastaExcl, string Estado, string NombreLike) ReadFiltros()
        {
            DateTime desde = dtpDesdeReporte?.Value.Date ?? DateTime.Today.AddDays(-14);
            DateTime hastaExcl = (dtpHastaReporte?.Value.Date ?? DateTime.Today).AddDays(1);
            string estado = (cmbEstadoReporte?.SelectedItem?.ToString() ?? "Todas").Trim();
            string nombreLike = (txtBuscarPacienteReporte?.Text ?? "").Trim();
            return (desde, hastaExcl, estado, nombreLike);
        }


        private void Buscar()
        {
            if (_buscando) return;
            _buscando = true;
            Cursor = Cursors.WaitCursor;
            try
            {
                var f = ReadFiltros();
                if (f.Desde >= f.HastaExcl)
                {
                    MessageBox.Show("El rango de fechas es inválido.");
                    return;
                }

                EjecutarConsultas(f);

                
                dgvResumen.DataSource = _dtResumen;
                dgvDetalleFacturas.DataSource = _dtFacturas;
                dgvDetallePagos.DataSource = _dtPagos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                _buscando = false;
            }
        }

        private void EjecutarConsultas((DateTime Desde, DateTime HastaExcl, string Estado, string NombreLike) f)
        {
            _dtResumen = new DataTable();
            _dtFacturas = new DataTable();
            _dtPagos = new DataTable();

            using (var cn = new SqlConnection(Conexion.AppConnectionString))
            {
                cn.Open();

                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT f.ID_Factura, f.ID_Paciente, f.FechaEmision, f.ImporteTotal,
       v.Pagado, v.Saldo, v.EstadoPago, v.UltimoPago, v.NumPagos,
       (p.Nombres + ' ' + p.Apellidos) AS Paciente
FROM dbo.vFacturaSaldo v
JOIN dbo.FACTURA f ON f.ID_Factura = v.ID_Factura
JOIN dbo.PERSONA p ON p.ID_Persona = f.ID_Paciente
WHERE f.FechaEmision >= @Desde AND f.FechaEmision < @HastaExcl
  AND (@Estado = 'Todas' OR v.EstadoPago = @Estado)
  AND (
        @NombreLike = '' OR p.DUI = @NombreLike
        OR (p.Nombres + ' ' + p.Apellidos LIKE '%' + @NombreLike + '%')
      )
ORDER BY f.ID_Factura DESC;";
                    cmd.Parameters.AddWithValue("@Desde", f.Desde);
                    cmd.Parameters.AddWithValue("@HastaExcl", f.HastaExcl);
                    cmd.Parameters.AddWithValue("@Estado", f.Estado);
                    cmd.Parameters.AddWithValue("@NombreLike", f.NombreLike);
                    using var da = new SqlDataAdapter((SqlCommand)cmd);
                    da.Fill(_dtFacturas);
                }

                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT pg.ID_Pago, pg.ID_Factura, pg.FechaPago, pg.Monto, pg.MetodoPago
FROM dbo.PAGO pg
WHERE pg.FechaPago >= @Desde AND pg.FechaPago < @HastaExcl
ORDER BY pg.FechaPago DESC, pg.ID_Pago DESC;";
                    cmd.Parameters.AddWithValue("@Desde", f.Desde);
                    cmd.Parameters.AddWithValue("@HastaExcl", f.HastaExcl);
                    using var da = new SqlDataAdapter((SqlCommand)cmd);
                    da.Fill(_dtPagos);
                }

                var dtTotales = new DataTable();
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT SUM(f.ImporteTotal) AS TotalFacturado,
       SUM(v.Pagado)       AS TotalPagado,
       SUM(v.Saldo)        AS Saldo,
       COUNT(*)            AS NumFacturas
FROM dbo.vFacturaSaldo v
JOIN dbo.FACTURA f ON f.ID_Factura = v.ID_Factura
WHERE f.FechaEmision >= @Desde AND f.FechaEmision < @HastaExcl
  AND (@Estado = 'Todas' OR v.EstadoPago = @Estado);";
                    cmd.Parameters.AddWithValue("@Desde", f.Desde);
                    cmd.Parameters.AddWithValue("@HastaExcl", f.HastaExcl);
                    cmd.Parameters.AddWithValue("@Estado", f.Estado);
                    using var da = new SqlDataAdapter((SqlCommand)cmd);
                    da.Fill(dtTotales);
                }

                var dtMetodos = new DataTable();
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT MetodoPago, SUM(Monto) AS TotalMetodo, COUNT(*) AS Cantidad
FROM dbo.PAGO
WHERE FechaPago >= @Desde AND FechaPago < @HastaExcl
GROUP BY MetodoPago;";
                    cmd.Parameters.AddWithValue("@Desde", f.Desde);
                    cmd.Parameters.AddWithValue("@HastaExcl", f.HastaExcl);
                    using var da = new SqlDataAdapter((SqlCommand)cmd);
                    da.Fill(dtMetodos);
                }

                _dtResumen.Columns.Add("TotalFacturado", typeof(decimal));
                _dtResumen.Columns.Add("TotalPagado", typeof(decimal));
                _dtResumen.Columns.Add("Saldo", typeof(decimal));
                _dtResumen.Columns.Add("NumFacturas", typeof(int));
                _dtResumen.Columns.Add("NumPagos", typeof(int));
                _dtResumen.Columns.Add("Efectivo", typeof(decimal));
                _dtResumen.Columns.Add("Tarjeta", typeof(decimal));
                _dtResumen.Columns.Add("Transferencia", typeof(decimal));
                _dtResumen.Columns.Add("Otro", typeof(decimal));

                decimal totalFact = 0, totalPag = 0, saldo = 0;
                int numFact = 0, numPagos = _dtPagos.Rows.Count;

                if (dtTotales.Rows.Count > 0)
                {
                    var r = dtTotales.Rows[0];
                    totalFact = r["TotalFacturado"] == DBNull.Value ? 0 : Convert.ToDecimal(r["TotalFacturado"]);
                    totalPag = r["TotalPagado"] == DBNull.Value ? 0 : Convert.ToDecimal(r["TotalPagado"]);
                    saldo = r["Saldo"] == DBNull.Value ? 0 : Convert.ToDecimal(r["Saldo"]);
                    numFact = r["NumFacturas"] == DBNull.Value ? 0 : Convert.ToInt32(r["NumFacturas"]);
                }

                decimal efectivo = 0, tarjeta = 0, transferencia = 0, otro = 0;
                foreach (DataRow r in dtMetodos.Rows)
                {
                    var metodo = (r["MetodoPago"]?.ToString() ?? "").Trim().ToLower();
                    var val = r["TotalMetodo"] == DBNull.Value ? 0 : Convert.ToDecimal(r["TotalMetodo"]);
                    switch (metodo)
                    {
                        case "efectivo": efectivo += val; break;
                        case "tarjeta": tarjeta += val; break;
                        case "transferencia": transferencia += val; break;
                        default: otro += val; break;
                    }
                }

                _dtResumen.Rows.Add(totalFact, totalPag, saldo, numFact, numPagos, efectivo, tarjeta, transferencia, otro);
            }
        }


       

        private void ExportarPDF()
        {
            if (_exportando) return;
            _exportando = true;
            Cursor = Cursors.WaitCursor;
            try
            {
                if (_dtResumen == null || _dtFacturas == null || _dtPagos == null ||
                    _dtFacturas.Rows.Count == 0)
                {
                    MessageBox.Show("Ejecute una búsqueda antes de exportar.", "Reportes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using var sfd = new SaveFileDialog
                {
                    Title = "Guardar Reporte Quincenal en PDF",
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = $"ReporteQuincenal_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "ReporteQuincenal.rdlc");
                if (!File.Exists(reportPath))
                    throw new FileNotFoundException("No se encontró el archivo RDLC.", reportPath);

                var report = new LocalReport();
                using (var fs = File.OpenRead(reportPath))
                {
                    report.LoadReportDefinition(fs);
                }

                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("dsResumen", _dtResumen));
                report.DataSources.Add(new ReportDataSource("dsFacturas", _dtFacturas));
                report.DataSources.Add(new ReportDataSource("dsPagos", _dtPagos));

                DateTime desde = dtpDesdeReporte.Value.Date;
                DateTime hastaExcl = dtpHastaReporte.Value.Date.AddDays(1);
                string estado = (cmbEstadoReporte?.SelectedItem?.ToString() ?? "Todas").Trim();
                string nombreLike = (txtBuscarPacienteReporte?.Text ?? "").Trim();

                var parametros = new[]
                {
                    new ReportParameter("pRango", $"{desde:dd/MM/yyyy} - {hastaExcl.AddDays(-1):dd/MM/yyyy}"),
                    new ReportParameter("pEstado", estado),
                    new ReportParameter("pPaciente", string.IsNullOrWhiteSpace(nombreLike) ? "(Todos)" : nombreLike),
                    new ReportParameter("pFechaEmision", DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                };
                report.SetParameters(parametros);

                byte[] pdf = report.Render("PDF");
                File.WriteAllBytes(sfd.FileName, pdf);

                MessageBox.Show("PDF generado correctamente.", "Reportes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar:\n" + GetDeepError(ex), "Reportes",
        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Cursor = Cursors.Default;
                _exportando = false;
            }
        }

        private static string GetDeepError(Exception ex)
        {
            var sb = new System.Text.StringBuilder();
            for (var e = ex; e != null; e = e.InnerException)
                sb.AppendLine(e.Message);
            return sb.ToString();
        }

        private void ReporteQuincenalView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var menu = BuscarMenuInicio();
                if (menu != null)
                {
                    menu.Show();
                    menu.BringToFront();
                }
            }
        }


        private Form BuscarMenuInicio()
        {
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "DermaCenterInicio") 
                    return frm;
            return null; 
        }
        private void CerrarYVolverAlMenu()
        {
            var menu = BuscarMenuInicio();
            if (menu != null)
            {
                menu.Show();
                menu.BringToFront();
            }
            this.Close();
        }

        public ReporteQuincenalView()
        {
            InitializeComponent();

            if (btnBuscarReporte != null) btnBuscarReporte.Click += (s, e) => Buscar();
            if (btnExportarPDF != null) btnExportarPDF.Click += (s, e) => ExportarPDF();
            if (btnLimpiarFiltros != null) btnLimpiarFiltros.Click += (s, e) => Limpiar();
            if (btnRefrescarGrids != null) btnRefrescarGrids.Click += (s, e) => Buscar();

            if (btnHoyReporte != null) btnHoyReporte.Click += (s, e) => SetRangoQuick(DateTime.Today, DateTime.Today.AddDays(1));
            if (btnAyerReporte != null) btnAyerReporte.Click += (s, e) => { var hoy = DateTime.Today; SetRangoQuick(hoy.AddDays(-1), hoy); };
            if (btnUltimos15 != null) btnUltimos15.Click += (s, e) => { var hoy = DateTime.Today; SetRangoQuick(hoy.AddDays(-14), hoy.AddDays(1)); };

            if (btnRegresar != null) btnRegresar.Click += (s, e) => CerrarYVolverAlMenu();
            this.FormClosing += ReporteQuincenalView_FormClosing;


            if (btnBuscarReporte != null) this.AcceptButton = btnBuscarReporte;

            if (cmbEstadoReporte != null)
            {
                cmbEstadoReporte.Items.Clear();
                cmbEstadoReporte.Items.AddRange(new object[] { "Todas", "Pendiente", "Parcial", "Pagada" });
                cmbEstadoReporte.SelectedIndex = 0;
            }

            ConfigurarDgv(dgvResumen);
            ConfigurarDgv(dgvDetalleFacturas);
            ConfigurarDgv(dgvDetallePagos);

            SetRangoQuick(DateTime.Today.AddDays(-14), DateTime.Today.AddDays(1));


        }

        private void ConfigurarDgv(DataGridView dgv)
        {
            if (dgv == null) return;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoGenerateColumns = true;
        }

        private void SetRangoQuick(DateTime desde, DateTime hastaExcl)
        {
            if (dtpDesdeReporte != null) dtpDesdeReporte.Value = desde;
            if (dtpHastaReporte != null) dtpHastaReporte.Value = hastaExcl.AddDays(-1); // en UI inclusivo
        }

        private void Limpiar()
        {
            txtBuscarPacienteReporte?.Clear();
            if (cmbEstadoReporte != null) cmbEstadoReporte.SelectedIndex = 0;
            SetRangoQuick(DateTime.Today.AddDays(-14), DateTime.Today.AddDays(1));
            if (dgvResumen != null) dgvResumen.DataSource = null;
            if (dgvDetalleFacturas != null) dgvDetalleFacturas.DataSource = null;
            if (dgvDetallePagos != null) dgvDetallePagos.DataSource = null;
            _dtResumen = _dtFacturas = _dtPagos = null;
        }

    }
}
