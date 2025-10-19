using Microsoft.Data.SqlClient;
using ProyectoClinicaDermaCenter2025.ConexionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinicaDermaCenter2025.Views.Facturacion_Pagos
{
    public partial class Facturacion_View : Form
    {
        private readonly Form _menu;

        private bool _buscandoCitas, _generandoFactura, _agregandoDet, _quitandoDet;
        private bool _modoConsultaFacturas;

        private DataTable _dtCitas;
        private DataTable _dtDetalle;

        private DateTime _lastDesde, _lastHasta;
        private string _lastPacienteLike;

        // Catálogo de precios TEMPORAL
        private Dictionary<string, decimal> _preciosPorServicio =
            new Dictionary<string, decimal>(StringComparer.InvariantCultureIgnoreCase)
            {
                ["Consulta dermatológica"] = 50.00m,
                ["Control/seguimiento"] = 35.00m,
                ["Limpieza facial"] = 30.00m,
                ["Peeling químico superficial"] = 60.00m,
                ["Peeling químico medio"] = 90.00m,
                ["Extracción de comedones"] = 25.00m,
                ["Cauterización de verrugas (unidad)"] = 15.00m,
                ["Crioterapia (lesión)"] = 25.00m,
                ["Biopsia de piel (toma)"] = 120.00m,
                ["Curación/retirada de puntos"] = 20.00m
            };



        public Facturacion_View(Form menu = null)
        {
            InitializeComponent();
            _menu = menu;

            this.Shown += Facturacion_View_Shown;
            this.FormClosed += Facturacion_View_FormClosed;

            DesengancharEventos();
            EngancharEventos();
        }

        private void DesengancharEventos()
        {
            btnBuscarCitas.Click -= btnBuscarCitas_Click;
            btnRefrescarCitas.Click -= btnRefrescarCitas_Click;
            btnLimpiarFiltros.Click -= btnLimpiarFiltros_Click;
            btnHoy.Click -= btnHoy_Click;

            dgvCitasCompletadas.SelectionChanged -= dgvCitasCompletadas_SelectionChanged;

            btnAgregarServicio.Click -= btnAgregarServicio_Click;
            btnQuitarServicio.Click -= btnQuitarServicio_Click;
            btnGenerarFactura.Click -= btnGenerarFactura_Click;
            btnCancelar.Click -= btnCancelar_Click;

            btnBuscarFacturas.Click -= btnBuscarFacturas_Click;
            btnRegresar.Click -= BtnRegresar_Cerrar;      // por si se enganchó antes

            cmbServicio.SelectedIndexChanged -= cmbServicio_SelectedIndexChanged;
        }

        private void EngancharEventos()
        {
            btnBuscarCitas.Click += btnBuscarCitas_Click;
            btnRefrescarCitas.Click += btnRefrescarCitas_Click;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            btnHoy.Click += btnHoy_Click;

            dgvCitasCompletadas.SelectionChanged += dgvCitasCompletadas_SelectionChanged;

            btnAgregarServicio.Click += btnAgregarServicio_Click;
            btnQuitarServicio.Click += btnQuitarServicio_Click;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            btnCancelar.Click += btnCancelar_Click;

            btnBuscarFacturas.Click += btnBuscarFacturas_Click;
            btnRegresar.Click += BtnRegresar_Cerrar;

            cmbServicio.SelectedIndexChanged += cmbServicio_SelectedIndexChanged;
        }

        private void BtnRegresar_Cerrar(object? s, EventArgs e) => this.Close();


        private void Facturacion_View_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (_menu != null && !_menu.IsDisposed)
            {
                _menu.Show();
                _menu.Activate();
            }
        }


        private void Facturacion_View_Shown(object sender, EventArgs e)
        {
            try
            {
                this.AcceptButton = btnBuscarCitas;

                PrepararGrids();
                CargarCombos();
                SetRangoHoy();
                LimpiarFacturaUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar Facturación: " + ex.Message, "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        private void PrepararGrids()
        {
            // Citas
            dgvCitasCompletadas.RowHeadersVisible = false;
            dgvCitasCompletadas.MultiSelect = false;
            dgvCitasCompletadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitasCompletadas.AutoGenerateColumns = true;

            // Detalle
            dgvDetalleFactura.RowHeadersVisible = false;
            dgvDetalleFactura.MultiSelect = false;
            dgvDetalleFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleFactura.AutoGenerateColumns = true;

            _dtDetalle = new DataTable();
            _dtDetalle.Columns.Add("ID_Servicio", typeof(int));
            _dtDetalle.Columns.Add("Servicio", typeof(string));
            _dtDetalle.Columns.Add("Cantidad", typeof(int));
            _dtDetalle.Columns.Add("PrecioUnitario", typeof(decimal));
            _dtDetalle.Columns.Add("Importe", typeof(decimal));
            dgvDetalleFactura.DataSource = _dtDetalle;
        }

        private void CargarCombos()
        {
            // Estados de FACTURA 
            cmbEstadoFactura.Items.Clear();
            cmbEstadoFactura.Items.AddRange(new object[] { "Pendiente", "Parcial", "Pagada", "Todas" });
            cmbEstadoFactura.SelectedIndex = 3;

            // Servicios desde PRODUCTO
            using var cn = new SqlConnection(Conexion.AppConnectionString);
            using var da = new SqlDataAdapter(
                @"SELECT ID_Producto AS ID_Servicio, NombreProducto AS Servicio
                  FROM dbo.PRODUCTO
                  ORDER BY Servicio", cn);
            var dtServ = new DataTable();
            da.Fill(dtServ);

            cmbServicio.DisplayMember = "Servicio";
            cmbServicio.ValueMember = "ID_Servicio";
            cmbServicio.DataSource = dtServ;

        }

        private void SetRangoHoy()
        {
            var hoy = DateTime.Today;
            dtpDesde.Value = hoy;
            dtpHasta.Value = hoy;
        }

        private void LimpiarFacturaUI()
        {
            txtPacienteLectura.Clear();
            txtMedicoLectura.Clear();
            dtpFechaFacturacion.Value = DateTime.Today;

            _dtDetalle.Rows.Clear();
            txtSubTotal.Text = "0.00";
            txtImpuesto.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtTotal.Text = "0.00";

            panel1.Enabled = false;
        }




        private void HabilitarPanelInferior(bool enabled)
        {
            panel1.Enabled = enabled;
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            SetRangoHoy();
            btnBuscarCitas_Click(null, EventArgs.Empty);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarPaciente.Clear();
            SetRangoHoy();
            _modoConsultaFacturas = false;
            dgvCitasCompletadas.DataSource = null;
            LimpiarFacturaUI();
        }

        private void btnRefrescarCitas_Click(object sender, EventArgs e)
        {
            if (_lastDesde != default && !_modoConsultaFacturas)
                BuscarCitas(_lastDesde, _lastHasta, _lastPacienteLike);
        }

        private void btnBuscarCitas_Click(object sender, EventArgs e)
        {
            var desde = dtpDesde.Value.Date;                             // 00:00:00
            var hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);   // 23:59:59
            var nombreLike = string.IsNullOrWhiteSpace(txtBuscarPaciente.Text) ? null : txtBuscarPaciente.Text.Trim();

            BuscarCitas(desde, hasta, nombreLike);
        }

        private void BuscarCitas(DateTime desde, DateTime hasta, string nombreLike)
        {
            if (_buscandoCitas) return;
            _buscandoCitas = true;
            _modoConsultaFacturas = false;
            try
            {
                using var cn = new SqlConnection(Conexion.AppConnectionString);
                using var cmd = new SqlCommand(@"
SELECT 
    c.ID_Cita, c.ID_Paciente, c.ID_Medico,
    c.FechaHora,
    c.Estado,
    Paciente = pp.Apellidos + ', ' + pp.Nombres,
    Medico   = pm.Apellidos + ', ' + pm.Nombres
FROM dbo.CITA c
JOIN dbo.PERSONA pp ON pp.ID_Persona = c.ID_Paciente
JOIN dbo.PERSONA pm ON pm.ID_Persona = c.ID_Medico
WHERE c.FechaHora >= @Desde AND c.FechaHora <= @Hasta
  AND c.Estado = 'Completada'
  AND NOT EXISTS (SELECT 1 FROM dbo.CITA_FACTURA cf WHERE cf.ID_Cita = c.ID_Cita)
  AND (
        @NombreLike IS NULL OR
        (pp.Nombres + ' ' + pp.Apellidos LIKE '%' + @NombreLike + '%'
         OR pp.DUI = @NombreLike)
      )
ORDER BY c.FechaHora DESC;", cn);



                cmd.Parameters.Add("@Desde", SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@Hasta", SqlDbType.DateTime).Value = hasta;
                if (nombreLike == null)
                    cmd.Parameters.Add("@NombreLike", SqlDbType.NVarChar, 100).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@NombreLike", SqlDbType.NVarChar, 100).Value = nombreLike;

                using var da = new SqlDataAdapter(cmd);
                _dtCitas = new DataTable();
                da.Fill(_dtCitas);
                dgvCitasCompletadas.DataSource = _dtCitas;

                if (dgvCitasCompletadas.Columns["ID_Cita"] != null) dgvCitasCompletadas.Columns["ID_Cita"].Visible = false;
                if (dgvCitasCompletadas.Columns["ID_Paciente"] != null) dgvCitasCompletadas.Columns["ID_Paciente"].Visible = false;
                if (dgvCitasCompletadas.Columns["ID_Medico"] != null) dgvCitasCompletadas.Columns["ID_Medico"].Visible = false;

                dgvCitasCompletadas.Columns["FechaHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                if (dgvCitasCompletadas.Columns["Estado"] != null) dgvCitasCompletadas.Columns["Estado"].DisplayIndex = 0;


                _lastDesde = desde; _lastHasta = hasta; _lastPacienteLike = nombreLike;

                LimpiarFacturaUI();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL al listar citas: " + ex.Message, "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar citas: " + ex.Message, "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _buscandoCitas = false;
            }
        }

        private void dgvCitasCompletadas_SelectionChanged(object sender, EventArgs e)
        {
            if (_modoConsultaFacturas) return;
            if (dgvCitasCompletadas.CurrentRow == null) return;

            var row = dgvCitasCompletadas.CurrentRow;
            if (row.DataBoundItem is DataRowView drv)
            {
                txtPacienteLectura.Text = Convert.ToString(drv["Paciente"]);
                txtMedicoLectura.Text = Convert.ToString(drv["Medico"]);
                dtpFechaFacturacion.Value = DateTime.Today;

                _dtDetalle.Rows.Clear();
                RecalcularTotales();
                HabilitarPanelInferior(true);
            }
        }


        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (_agregandoDet) return;
            _agregandoDet = true;
            try
            {
                errorFacturacion.Clear();

                if (cmbServicio.SelectedValue == null)
                {
                    errorFacturacion.SetError(cmbServicio, "Seleccione un servicio.");
                    return;
                }

                if (nunCantidad.Value < 1)
                {
                    errorFacturacion.SetError(nunCantidad, "Cantidad debe ser ≥ 1.");
                    return;
                }

                if (!decimal.TryParse(txtPrecioUnidadLectura.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var precio) || precio <= 0)
                {
                    errorFacturacion.SetError(txtPrecioUnidadLectura, "Precio unitario inválido (> 0).");
                    return;
                }

                var idServ = Convert.ToInt32(cmbServicio.SelectedValue);
                var nombre = Convert.ToString((cmbServicio.SelectedItem as DataRowView)?["Servicio"] ?? cmbServicio.Text);
                var cantidad = Convert.ToInt32(nunCantidad.Value);

                DataRow existente = null;
                foreach (DataRow r in _dtDetalle.Rows)
                {
                    if (Convert.ToInt32(r["ID_Servicio"]) == idServ) { existente = r; break; }
                }

                if (existente != null)
                {
                    var nuevaCant = Convert.ToInt32(existente["Cantidad"]) + cantidad;
                    existente["Cantidad"] = nuevaCant;
                    existente["PrecioUnitario"] = precio; // último precio
                    existente["Importe"] = nuevaCant * precio;
                }
                else
                {
                    var dr = _dtDetalle.NewRow();
                    dr["ID_Servicio"] = idServ;
                    dr["Servicio"] = nombre;
                    dr["Cantidad"] = cantidad;
                    dr["PrecioUnitario"] = precio;
                    dr["Importe"] = cantidad * precio;
                    _dtDetalle.Rows.Add(dr);
                }

                RecalcularTotales();
                btnGenerarFactura.Enabled = _dtDetalle.Rows.Count > 0;
            }
            finally { _agregandoDet = false; }
        }

        private void btnQuitarServicio_Click(object sender, EventArgs e)
        {
            if (_quitandoDet) return;
            _quitandoDet = true;
            try
            {
                if (dgvDetalleFactura.CurrentRow == null) return;
                if (dgvDetalleFactura.CurrentRow.DataBoundItem is DataRowView drv)
                {
                    drv.Row.Delete();
                    RecalcularTotales();
                    btnGenerarFactura.Enabled = _dtDetalle.Rows.Count > 0;
                }
            }
            finally { _quitandoDet = false; }
        }

        private void RecalcularTotales()
        {
            decimal sub = 0m;
            foreach (DataRow r in _dtDetalle.Rows)
                sub += Convert.ToDecimal(r["Importe"]);

            txtSubTotal.Text = sub.ToString("N2");
            txtImpuesto.Text = 0m.ToString("N2");
            txtDescuento.Text = 0m.ToString("N2");
            txtTotal.Text = sub.ToString("N2");
        }

        private int? GetIdPacienteSeleccionado()
        {
            if (dgvCitasCompletadas.CurrentRow == null) return null;
            if (dgvCitasCompletadas.CurrentRow.DataBoundItem is not DataRowView drv) return null;
            return Convert.ToInt32(drv["ID_Paciente"]);
        }

        //áquí se genera la factura
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (_generandoFactura) return;
            _generandoFactura = true;

            SqlTransaction? tx = null;

            try
            {
                errorFacturacion.Clear();

                if (_dtDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un servicio al detalle.", "DermaCenter",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!decimal.TryParse(txtTotal.Text, NumberStyles.Number, CultureInfo.CurrentCulture,
                                      out var total) || total <= 0)
                {
                    errorFacturacion.SetError(txtTotal, "Total inválido.");
                    return;
                }

                var idPaciente = GetIdPacienteSeleccionado();
                if (idPaciente == null)
                {
                    MessageBox.Show("Seleccione una cita para facturar.", "DermaCenter",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dgvCitasCompletadas.CurrentRow?.DataBoundItem is not DataRowView drvSel
                    || drvSel.Row.Table.Columns.Contains("ID_Cita") == false)
                {
                    MessageBox.Show("No se pudo determinar la cita seleccionada.", "DermaCenter",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idCita = Convert.ToInt32(drvSel["ID_Cita"]);

                using var cn = new SqlConnection(Conexion.AppConnectionString);
                cn.Open();
                tx = cn.BeginTransaction();

                using (var cmd = new SqlCommand("dbo.sp_Factura_Crear", cn, tx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID_Paciente", SqlDbType.Int).Value = idPaciente.Value;
                    var pImporte = cmd.Parameters.Add("@ImporteTotal", SqlDbType.Decimal);
                    pImporte.Precision = 10; pImporte.Scale = 2; pImporte.Value = total;
                    cmd.Parameters.Add("@FechaEmision", SqlDbType.Date).Value = dtpFechaFacturacion.Value.Date;

                    var pOut = cmd.Parameters.Add("@NuevoId", SqlDbType.Int);
                    pOut.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    int idFactura = (int)pOut.Value;

                    using (var cmdMark = new SqlCommand("dbo.sp_Cita_MarcarFacturada", cn, tx))
                    {
                        cmdMark.CommandType = CommandType.StoredProcedure;
                        cmdMark.Parameters.Add("@ID_Cita", SqlDbType.Int).Value = idCita;
                        cmdMark.Parameters.Add("@ID_Factura", SqlDbType.Int).Value = idFactura;
                        cmdMark.ExecuteNonQuery();
                    }

                    tx.Commit(); tx = null;

                    MessageBox.Show($"Factura #{idFactura} creada correctamente por {total:N2}.",
                                    "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    drvSel.Row.Delete(); 
                }

                BuscarCitas(
                    _lastDesde == default ? dtpDesde.Value.Date : _lastDesde,
                    _lastHasta == default ? dtpHasta.Value.Date.AddDays(1).AddSeconds(-1) : _lastHasta,
                    _lastPacienteLike
                );
                LimpiarFacturaUI();
            }
            catch (SqlException ex)
            {
                try { tx?.Rollback(); } catch {  }
                MessageBox.Show("Error SQL al crear/marcar factura: " + ex.Message,
                                "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                try { tx?.Rollback(); } catch {  }
                MessageBox.Show("Error al crear/marcar factura: " + ex.Message,
                                "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _generandoFactura = false;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFacturaUI();
        }

        //la consulta de facturas
        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            var estado = (cmbEstadoFactura.SelectedItem?.ToString() ?? "Todas");

            BuscarFacturas(desde, hasta, estado);
        }

        private void BuscarFacturas(DateTime desde, DateTime hasta, string estado)
        {
            _modoConsultaFacturas = true;
            try
            {
                using var cn = new SqlConnection(Conexion.AppConnectionString);
                using var cmd = new SqlCommand(@"
SELECT ID_Factura, ID_Paciente, FechaEmision, ImporteTotal,
       Pagado, Saldo, EstadoPago, UltimoPago, NumPagos
FROM dbo.vFacturaSaldo
WHERE FechaEmision BETWEEN @Desde AND @Hasta
  AND (@Estado = 'Todas' OR EstadoPago = @Estado)
ORDER BY ID_Factura DESC;", cn);

                cmd.Parameters.Add("@Desde", SqlDbType.Date).Value = desde;
                cmd.Parameters.Add("@Hasta", SqlDbType.Date).Value = hasta;
                cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 20).Value = estado ?? "Todas";

                using var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                dgvCitasCompletadas.DataSource = dt;
                if (dgvCitasCompletadas.Columns["FechaEmision"] != null)
                    dgvCitasCompletadas.Columns["FechaEmision"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar facturas: " + ex.Message, "DermaCenter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HabilitarPanelInferior(false);
        }


        private void cmbServicio_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (cmbServicio.SelectedItem is DataRowView drv)
                {
                    var nombre = Convert.ToString(drv["Servicio"]) ?? string.Empty;
                    if (_preciosPorServicio.TryGetValue(nombre, out var precio))
                        txtPrecioUnidadLectura.Text = precio.ToString("N2");
                    else
                        txtPrecioUnidadLectura.Clear(); // sin precio conocido
                }
            }
            catch { }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
