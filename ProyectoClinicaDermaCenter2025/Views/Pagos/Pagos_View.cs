using System;
using System.Configuration; 
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProyectoClinicaDermaCenter2025.Views.Pagos
{
    public partial class Pagos_View : Form
    {
        private bool _buscandoFacturas = false;
        private bool _cargandoPagos = false;
        private bool _registrandoPago = false;

        private DateTime _filtroDesde;
        private DateTime _filtroHasta;
        private string _filtroEstado = "Todas";
        private string _filtroNombre = string.Empty;

        private DataTable _dtFacturas;
        private DataTable _dtPagos;

        private static string CadenaConexion
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings["Conexion.AppConnectionString"];
                if (cs == null || string.IsNullOrWhiteSpace(cs.ConnectionString))
                    throw new InvalidOperationException("Falta la cadena 'Conexion.AppConnectionString' en App.config del proyecto de inicio.");
                return cs.ConnectionString;
            }
        }

        public Pagos_View()
        {
            InitializeComponent();
            WireUpEvents();
            InitUi();

            this.FormClosed += (_, __) =>
            {
                var menu = Application.OpenForms["DermaCenterInicio"];
                if (menu != null)
                {
                    menu.Show();
                    menu.BringToFront();
                }
            };
        }

        private void WireUpEvents()
        {
            btnHoyPagos.Click += (_, __) => SetHoy();
            btnBuscarPagos.Click += async (_, __) => await BuscarFacturasAsync();
            btnActualizarPagos.Click += async (_, __) => await ActualizarFacturasAsync();
            btnLimpiarFiltrosPagos.Click += (_, __) => LimpiarFiltros();
            btnRegresar.Click += (_, __) => this.Close();

            dgvFacturas.SelectionChanged += async (_, __) => await CargarFacturaSeleccionadaAsync();

            btnRegistrarPago.Click += async (_, __) => await RegistrarPagoAsync();
            btnCancelarPago.Click += (_, __) => LimpiarPagoInputs();

            this.AcceptButton = btnBuscarPagos;
        }

        private void InitUi()
        {
            SetHoy();
            if (cmbEstadoPago.Items.Contains("Todas"))
                cmbEstadoPago.SelectedItem = "Todas";

            ConfigurarGrids();

            SetPagoInputsEnabled(false);

            if (cmbMetodoPago.Items.Count > 0) cmbMetodoPago.SelectedIndex = -1;

            dtpFechaPago.Value = DateTime.Today;

            nudMontoPago.Increment = 0.01M;
        }

        private void ConfigurarGrids()
        {
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.MultiSelect = false;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.ReadOnly = true;
            dgvFacturas.AutoGenerateColumns = true;

            dgvPagosFactura.RowHeadersVisible = false;
            dgvPagosFactura.MultiSelect = false;
            dgvPagosFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagosFactura.ReadOnly = true;
            dgvPagosFactura.AutoGenerateColumns = true;
        }

        private void SetHoy()
        {
            var hoy = DateTime.Today;
            dtpDesdePagos.Value = hoy;
            dtpHastaPagos.Value = hoy;
        }

        private void LimpiarFiltros()
        {
            SetHoy();
            if (cmbEstadoPago.Items.Contains("Todas"))
                cmbEstadoPago.SelectedItem = "Todas";
            txtBuscarPacientePagos.Clear();

            _dtFacturas?.Clear();
            _dtPagos?.Clear();
            dgvFacturas.DataSource = null;
            dgvPagosFactura.DataSource = null;

            LimpiarEncabezado();
            SetPagoInputsEnabled(false);
        }

        private void LimpiarEncabezado()
        {
            txtPacienteSel.Clear();
            txtEstadoSel.Clear();
            txtTotalSel.Clear();
            txtPagadoSel.Clear();
            txtSaldoSel.Clear();
        }

        private void SetPagoInputsEnabled(bool enabled)
        {
            dtpFechaPago.Enabled = enabled;
            cmbMetodoPago.Enabled = enabled;
            nudMontoPago.Enabled = enabled;
            btnRegistrarPago.Enabled = enabled;
            btnCancelarPago.Enabled = enabled;
        }

        // buscar facturas

        private async Task BuscarFacturasAsync()
        {
            if (_buscandoFacturas) return;
            try
            {
                _buscandoFacturas = true;

                _filtroDesde = dtpDesdePagos.Value.Date;
                _filtroHasta = dtpHastaPagos.Value.Date;
                _filtroEstado = (cmbEstadoPago.SelectedItem?.ToString() ?? "Todas");
                _filtroNombre = (txtBuscarPacientePagos.Text ?? "").Trim();

                using (var cn = new SqlConnection(CadenaConexion))
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT 
    f.ID_Factura,
    f.ID_Paciente,
    f.FechaEmision,
    f.ImporteTotal,
    v.Pagado,
    v.Saldo,
    v.EstadoPago,
    v.UltimoPago,
    v.NumPagos,
    (p.Nombres + ' ' + p.Apellidos) AS Paciente
FROM dbo.vFacturaSaldo v
JOIN dbo.FACTURA f     ON f.ID_Factura = v.ID_Factura
JOIN dbo.PERSONA p     ON p.ID_Persona = f.ID_Paciente
WHERE f.FechaEmision >= @Desde
  AND f.FechaEmision <  @HastaExclusivo
  AND (@Estado = 'Todas' OR v.EstadoPago = @Estado)
  AND (
        @NombreLike = '' 
        OR p.DUI = @NombreLike
        OR (p.Nombres + ' ' + p.Apellidos LIKE '%' + @NombreLike + '%')
      )
ORDER BY f.ID_Factura DESC;";

                    cmd.Parameters.Add(new SqlParameter("@Desde", SqlDbType.DateTime) { Value = _filtroDesde });
                    cmd.Parameters.Add(new SqlParameter("@HastaExclusivo", SqlDbType.DateTime) { Value = _filtroHasta.AddDays(1) });
                    cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.NVarChar, 20) { Value = _filtroEstado });
                    cmd.Parameters.Add(new SqlParameter("@NombreLike", SqlDbType.NVarChar, 150) { Value = _filtroNombre });

                    await cn.OpenAsync();
                    using (var rd = await cmd.ExecuteReaderAsync())
                    {
                        _dtFacturas = new DataTable();
                        _dtFacturas.Load(rd);
                        dgvFacturas.DataSource = _dtFacturas;
                    }
                }

                FormatearColumnasFacturas();
                LimpiarEncabezado();
                dgvPagosFactura.DataSource = null;
                SetPagoInputsEnabled(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar facturas:\n" + ex.Message, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _buscandoFacturas = false;
            }
        }

        private async Task ActualizarFacturasAsync()
        {
            if (_buscandoFacturas) return;
            try
            {
                _buscandoFacturas = true;

                using (var cn = new SqlConnection(CadenaConexion))
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT 
    f.ID_Factura,
    f.ID_Paciente,
    f.FechaEmision,
    f.ImporteTotal,
    v.Pagado,
    v.Saldo,
    v.EstadoPago,
    v.UltimoPago,
    v.NumPagos,
    (p.Nombres + ' ' + p.Apellidos) AS Paciente
FROM dbo.vFacturaSaldo v
JOIN dbo.FACTURA f     ON f.ID_Factura = v.ID_Factura
JOIN dbo.PERSONA p     ON p.ID_Persona = f.ID_Paciente
WHERE f.FechaEmision >= @Desde
  AND f.FechaEmision <  @HastaExclusivo
  AND (@Estado = 'Todas' OR v.EstadoPago = @Estado)
  AND (
        @NombreLike = '' 
        OR p.DUI = @NombreLike
        OR (p.Nombres + ' ' + p.Apellidos LIKE '%' + @NombreLike + '%')
      )
ORDER BY f.ID_Factura DESC;";

                    cmd.Parameters.Add(new SqlParameter("@Desde", SqlDbType.DateTime) { Value = _filtroDesde });
                    cmd.Parameters.Add(new SqlParameter("@HastaExclusivo", SqlDbType.DateTime) { Value = _filtroHasta.AddDays(1) });
                    cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.NVarChar, 20) { Value = _filtroEstado });
                    cmd.Parameters.Add(new SqlParameter("@NombreLike", SqlDbType.NVarChar, 150) { Value = _filtroNombre });

                    await cn.OpenAsync();
                    using (var rd = await cmd.ExecuteReaderAsync())
                    {
                        _dtFacturas = new DataTable();
                        _dtFacturas.Load(rd);
                        dgvFacturas.DataSource = _dtFacturas;
                    }
                }

                FormatearColumnasFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar facturas:\n" + ex.Message, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _buscandoFacturas = false;
            }
        }

        private void FormatearColumnasFacturas()
        {
            if (_dtFacturas == null) return;

            if (dgvFacturas.Columns.Contains("ID_Factura"))
                dgvFacturas.Columns["ID_Factura"].Visible = false;
            if (dgvFacturas.Columns.Contains("ID_Paciente"))
                dgvFacturas.Columns["ID_Paciente"].Visible = false;

            if (dgvFacturas.Columns.Contains("FechaEmision"))
                dgvFacturas.Columns["FechaEmision"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvFacturas.Columns.Contains("UltimoPago"))
                dgvFacturas.Columns["UltimoPago"].DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (var col in new[] { "ImporteTotal", "Pagado", "Saldo" })
            {
                if (dgvFacturas.Columns.Contains(col))
                    dgvFacturas.Columns[col].DefaultCellStyle.Format = "N2";
            }
        }


        private async Task CargarFacturaSeleccionadaAsync()
        {
            if (_cargandoPagos) return;
            if (dgvFacturas.CurrentRow == null || dgvFacturas.CurrentRow.Index < 0) return;

            try
            {
                _cargandoPagos = true;

                var row = dgvFacturas.CurrentRow.DataBoundItem as DataRowView;
                if (row == null) { LimpiarEncabezado(); SetPagoInputsEnabled(false); return; }

                int idFactura = Convert.ToInt32(row["ID_Factura"]);
                var tbl = row.DataView?.Table ?? row.Row.Table;

                string paciente = tbl.Columns.Contains("Paciente") ? Convert.ToString(row["Paciente"]) : string.Empty;
                string estado = tbl.Columns.Contains("EstadoPago") ? Convert.ToString(row["EstadoPago"]) : string.Empty;

                decimal total = (tbl.Columns.Contains("ImporteTotal") && row["ImporteTotal"] != DBNull.Value) ? Convert.ToDecimal(row["ImporteTotal"]) : 0m;
                decimal pagado = (tbl.Columns.Contains("Pagado") && row["Pagado"] != DBNull.Value) ? Convert.ToDecimal(row["Pagado"]) : 0m;
                decimal saldo = (tbl.Columns.Contains("Saldo") && row["Saldo"] != DBNull.Value) ? Convert.ToDecimal(row["Saldo"]) : 0m;

                txtPacienteSel.Text = paciente;
                txtEstadoSel.Text = estado;
                txtTotalSel.Text = total.ToString("N2");
                txtPagadoSel.Text = pagado.ToString("N2");
                txtSaldoSel.Text = saldo.ToString("N2");

                bool puedePagar = !string.Equals(estado, "Pagada", StringComparison.OrdinalIgnoreCase);
                SetPagoInputsEnabled(puedePagar);

                if (puedePagar)
                {
                    nudMontoPago.Value = Math.Max(0.01M, (decimal)saldo);
                    txtCambio.Text = "0.00";
                    if (cmbMetodoPago.SelectedIndex < 0 && cmbMetodoPago.Items.Count > 0)
                        cmbMetodoPago.SelectedIndex = 0; 
                }

                await CargarPagosFacturaAsync(idFactura);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la factura seleccionada:\n" + ex.Message, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargandoPagos = false;
            }
        }

        private async Task CargarPagosFacturaAsync(int idFactura)
        {
            using (var cn = new SqlConnection(CadenaConexion))
            using (var cmd = cn.CreateCommand())
            {
                cmd.CommandText = @"
SELECT ID_Pago, FechaPago, Monto, MetodoPago
FROM dbo.PAGO
WHERE ID_Factura = @ID_Factura
ORDER BY FechaPago DESC, ID_Pago DESC;";
                cmd.Parameters.Add(new SqlParameter("@ID_Factura", SqlDbType.Int) { Value = idFactura });

                await cn.OpenAsync();
                using (var rd = await cmd.ExecuteReaderAsync())
                {
                    _dtPagos = new DataTable();
                    _dtPagos.Load(rd);
                    dgvPagosFactura.DataSource = _dtPagos;
                }
            }

            if (dgvPagosFactura.Columns.Contains("ID_Pago"))
                dgvPagosFactura.Columns["ID_Pago"].Visible = false;
            if (dgvPagosFactura.Columns.Contains("FechaPago"))
                dgvPagosFactura.Columns["FechaPago"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvPagosFactura.Columns.Contains("Monto"))
                dgvPagosFactura.Columns["Monto"].DefaultCellStyle.Format = "N2";
        }

        // registrar pago

        private async Task RegistrarPagoAsync()
        {
            if (_registrandoPago) return;
            if (dgvFacturas.CurrentRow == null || dgvFacturas.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione una factura.", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _registrandoPago = true;
                errorFacturacion.Clear();

                var row = dgvFacturas.CurrentRow.DataBoundItem as DataRowView;
                int idFactura = Convert.ToInt32(row["ID_Factura"]);
                string estado = Convert.ToString(row["EstadoPago"]);
                if (string.Equals(estado, "Pagada", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La factura ya está Pagada.", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cmbMetodoPago.SelectedIndex < 0)
                {
                    errorFacturacion.SetError(cmbMetodoPago, "Seleccione un método.");
                    return;
                }

                decimal saldoActual = 0m;
                decimal.TryParse(txtSaldoSel.Text, out saldoActual);

                decimal monto = nudMontoPago.Value;
                if (monto <= 0)
                {
                    errorFacturacion.SetError(nudMontoPago, "El monto debe ser mayor a 0.");
                    return;
                }

                if (monto > saldoActual)
                {
                    errorFacturacion.SetError(nudMontoPago, "El monto no puede exceder el saldo.");
                    return;
                }

                var metodo = cmbMetodoPago.SelectedItem.ToString();
                var fechaPago = dtpFechaPago.Value.Date;

                using (var cn = new SqlConnection(CadenaConexion))
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "dbo.sp_Pago_Registrar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ID_Factura", SqlDbType.Int) { Value = idFactura });
                    cmd.Parameters.Add(new SqlParameter("@Monto", SqlDbType.Decimal)
                    {
                        Precision = 18,
                        Scale = 2,
                        Value = monto
                    });
                    cmd.Parameters.Add(new SqlParameter("@MetodoPago", SqlDbType.NVarChar, 50) { Value = metodo });
                    cmd.Parameters.Add(new SqlParameter("@FechaPago", SqlDbType.DateTime) { Value = fechaPago });

                    await cn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

                await ActualizarFacturasAsync();              
                await SeleccionarFilaPorIdFactura(idFactura);  
                await CargarFacturaSeleccionadaAsync();        

                LimpiarPagoInputs();

                MessageBox.Show("Pago registrado correctamente.", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error SQL al registrar pago:\n" + sqlex.Message, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pago:\n" + ex.Message, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _registrandoPago = false;
            }
        }

        private void LimpiarPagoInputs()
        {
            dtpFechaPago.Value = DateTime.Today;
            if (cmbMetodoPago.Items.Count > 0) cmbMetodoPago.SelectedIndex = 0;
            nudMontoPago.Value = 0.01M;
            txtCambio.Text = "0.00";
        }

        private async Task SeleccionarFilaPorIdFactura(int idFactura)
        {
            await Task.Yield(); 
            if (dgvFacturas.DataSource == null) return;
            foreach (DataGridViewRow r in dgvFacturas.Rows)
            {
                if (r.DataBoundItem is DataRowView drv &&
                    Convert.ToInt32(drv["ID_Factura"]) == idFactura)
                {
                    r.Selected = true;
                    int firstVisible = 0;
                    foreach (DataGridViewColumn c in dgvFacturas.Columns)
                    {
                        if (c.Visible) { firstVisible = c.Index; break; }
                    }
                    dgvFacturas.CurrentCell = r.Cells[firstVisible];
                }
            }
        }
    }
}
