using Microsoft.Data.SqlClient;
using ProyectoClinicaDermaCenter2025.ConexionDB;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoClinicaDermaCenter2025.Views.Empleados
{
    public partial class Empleado_Roles_View : Form
    {

        private readonly Form? _menu;

        public Empleado_Roles_View(Form? menu = null)
        {
            InitializeComponent();

            _menu = menu;

            this.Load += Empleado_Roles_View_Load;
            btnBuscar.Click += btnBuscar_Click;
            BtnNuevo.Click += BtnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnRegresar.Click += (_, __) => this.Close();

            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;

            this.FormClosed += (_, __) =>
            {
                try
                {
                    if (_menu != null && !_menu.IsDisposed)
                    {
                        _menu.Show();
                        _menu.Activate();
                    }
                    else if (this.Owner != null && !this.Owner.IsDisposed)
                    {
                        this.Owner.Show();
                        this.Owner.Activate();
                    }
                }
                catch {  }
            };
        }

        private static SqlConnection Open()
        {
            var cs = Conexion.AppConnectionString ?? throw new InvalidOperationException(
                "No se encontró la cadena de conexión. Asegúrate de tener <connectionStrings> en App.config " +
                "con name=\"DermaCenterDb\" o \"Conexion.AppConnectionString\".");
            var cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }

        private static object DbNullIfNull(object? v) => v ?? DBNull.Value;

        private void Empleado_Roles_View_Load(object? sender, EventArgs e)
        {
            ConfigurarUI();
            CargarRolesDesdeBD();
            Buscar(); 
        }

        private void ConfigurarUI()
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.AddRange(new object[] { "F", "M" });
            if (cmbSexo.Items.Count > 0) cmbSexo.SelectedIndex = 0;

            dgvEmpleados.RowHeadersVisible = false;
            lblClaveInicial.Text = "Clave inicial (login): —";

            txtEspecialidad.Visible = label16.Visible = false;
            cmbRol.SelectedIndexChanged += (_, __) =>
            {
                var rolSel = (cmbRol.SelectedItem as DataRowView)?["NombreRol"]?.ToString() ?? cmbRol.Text;
                bool esMedico = string.Equals(rolSel, "Medico", StringComparison.OrdinalIgnoreCase);
                txtEspecialidad.Visible = label16.Visible = esMedico;
            };

            txtDUI.TextChanged += (_, __) =>
            {
                var limpio = txtDUI.Text.Replace("-", "");
                lblClaveInicial.Text = limpio.Length >= 4
                    ? $"Clave inicial (login): {limpio.Substring(limpio.Length - 4, 4)}"
                    : "Clave inicial (login): —";
            };

            this.AcceptButton = btnBuscar;
            this.CancelButton = btnRegresar;

            this.FormClosing += (_, __) => { if (Owner != null) Owner.Show(); };
        }

        private void CargarRolesDesdeBD()
        {
            using var cn = Open();
            using var da = new SqlDataAdapter("SELECT ID_Rol, NombreRol FROM dbo.ROL ORDER BY NombreRol", cn);
            var dt = new DataTable();
            da.Fill(dt);

            cmbRol.DataSource = dt.Copy();
            cmbRol.DisplayMember = "NombreRol";
            cmbRol.ValueMember = "ID_Rol";
            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;

            var dtFiltro = dt.Copy();
            var filaTodos = dtFiltro.NewRow();
            filaTodos["ID_Rol"] = DBNull.Value;
            filaTodos["NombreRol"] = "Todos";
            dtFiltro.Rows.InsertAt(filaTodos, 0);

            cmbRolFiltro.DataSource = dtFiltro;
            cmbRolFiltro.DisplayMember = "NombreRol";
            cmbRolFiltro.ValueMember = "ID_Rol";
            cmbRolFiltro.SelectedIndex = 0;
        }

        private void Buscar()
        {
            string? nombre = string.IsNullOrWhiteSpace(txtBuscarNombre.Text) ? null : txtBuscarNombre.Text.Trim();

            string? rolSel = (cmbRolFiltro.SelectedItem as DataRowView)?["NombreRol"]?.ToString()
                             ?? cmbRolFiltro.Text;
            string? rol = rolSel == "Todos" ? null : rolSel;

            using var cn = Open();
            using var cmd = new SqlCommand("dbo.sp_Empleado_Listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreLike", DbNullIfNull(nombre));
            cmd.Parameters.AddWithValue("@Rol", DbNullIfNull(rol));

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            dgvEmpleados.DataSource = dt;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnBuscar_Click(object? sender, EventArgs e) => Buscar();

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            txtBuscarNombre.Clear();
            cmbRolFiltro.SelectedIndex = 0;
            txtDUIbuscar?.Clear();
            Buscar();
        }

        private void BtnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarFormulario();
            txtDUI.Focus();
        }

        private void btnCancelar_Click(object? sender, EventArgs e) => LimpiarFormulario();

        private void LimpiarFormulario()
        {
            errorEmpleado.Clear();

            txtDUI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpNacimiento.Value = DateTime.Today;
            if (cmbSexo.Items.Count > 0) cmbSexo.SelectedIndex = 0;
            txtDireccion.Clear();

            txtCodigoEmpleado.Clear();
            dtpFechaContratacion.Value = DateTime.Today;
            txtSalario.Clear();
            txtEspecialidad.Clear();
            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;

            chkActivo.Checked = true;
            lblClaveInicial.Text = "Clave inicial (login): —";
        }

        private bool ValidarFormulario()
        {
            errorEmpleado.Clear();
            bool ok = true;

            if (txtDUI is MaskedTextBox m && !m.MaskFull)
            {
                errorEmpleado.SetError(txtDUI, "DUI es requerido (formato 00000000-0).");
                ok = false;
            }
            else if (string.IsNullOrWhiteSpace(txtDUI.Text))
            {
                errorEmpleado.SetError(txtDUI, "DUI es requerido.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorEmpleado.SetError(txtNombres, "Nombres es requerido.");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorEmpleado.SetError(txtApellidos, "Apellidos es requerido.");
                ok = false;
            }
            return ok;
        }
        
        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario()) return;

                int idPersona;
                using (var cn = Open())
                using (var cmd = new SqlCommand("dbo.sp_Persona_Crear", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DUI", txtDUI.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpNacimiento.Value.Date);
                    cmd.Parameters.AddWithValue("@Sexo", DbNullIfNull(cmbSexo.Text));
                    cmd.Parameters.AddWithValue("@Direccion", DbNullIfNull(txtDireccion.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Estado", chkActivo.Checked ? "Activo" : "Inactivo");
                    var pOut = new SqlParameter("@NuevoId", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(pOut);
                    cmd.ExecuteNonQuery();
                    idPersona = (int)pOut.Value;
                }

                string rol = (cmbRol.SelectedItem as DataRowView)?["NombreRol"]?.ToString() ?? cmbRol.Text;

                DateTime? fechaC = dtpFechaContratacion.Value.Date;
                decimal? salario = null;
                if (decimal.TryParse(txtSalario.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var sal)) salario = sal;

                using (var cn = Open())
                using (var cmd = new SqlCommand("dbo.sp_Empleado_Registrar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Persona", idPersona);
                    cmd.Parameters.AddWithValue("@NombreRol", rol);
                    cmd.Parameters.AddWithValue("@CodigoEmpleado",
                        string.IsNullOrWhiteSpace(txtCodigoEmpleado.Text) ? (object)DBNull.Value : txtCodigoEmpleado.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaContratacion", DbNullIfNull(fechaC));
                    cmd.Parameters.AddWithValue("@Salario", DbNullIfNull(salario));
                    cmd.Parameters.AddWithValue("@Especialidad",
                        (string.Equals(rol, "Medico", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                            ? (object)txtEspecialidad.Text.Trim()
                            : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }

                var duiSinGuion = txtDUI.Text.Replace("-", "");
                var ult4 = duiSinGuion.Length >= 4 ? duiSinGuion[^4..] : duiSinGuion;
                lblClaveInicial.Text = $"Clave inicial (login): {ult4}";

                MessageBox.Show("Empleado creado correctamente.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Buscar();
                LimpiarFormulario();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un empleado en la tabla.", "Aviso");
                    return;
                }

                int idEmpleado = Convert.ToInt32(GetCell(dgvEmpleados.CurrentRow, "ID_Empleado") ?? 0);
                if (idEmpleado <= 0) throw new Exception("No se pudo determinar el ID_Empleado de la fila.");

                string? codigo = string.IsNullOrWhiteSpace(txtCodigoEmpleado.Text) ? null : txtCodigoEmpleado.Text.Trim();
                DateTime? fecha = dtpFechaContratacion.Value.Date;
                decimal? salario = null;
                if (decimal.TryParse(txtSalario.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var sal)) salario = sal;

                using (var cn = Open())
                using (var cmd = new SqlCommand("dbo.sp_Empleado_Editar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@CodigoEmpleado", DbNullIfNull(codigo));
                    cmd.Parameters.AddWithValue("@FechaContratacion", DbNullIfNull(fecha));
                    cmd.Parameters.AddWithValue("@Salario", DbNullIfNull(salario));
                    cmd.ExecuteNonQuery();
                }

                string rol = (cmbRol.SelectedItem as DataRowView)?["NombreRol"]?.ToString() ?? cmbRol.Text;
                string? esp = (string.Equals(rol, "Medico", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                    ? txtEspecialidad.Text.Trim()
                    : null;

                using (var cn = Open())
                using (var cmd = new SqlCommand("dbo.sp_Empleado_CambiarRol", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@NombreRol", rol);
                    cmd.Parameters.AddWithValue("@Especialidad", DbNullIfNull(esp));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Empleado actualizado.", "OK");
                Buscar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpleados_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null) return;

            txtCodigoEmpleado.Text = GetCell(dgvEmpleados.CurrentRow, "CodigoEmpleado")?.ToString() ?? "";
            txtSalario.Text = GetCell(dgvEmpleados.CurrentRow, "Salario")?.ToString() ?? "";
            txtDireccion.Text = GetCell(dgvEmpleados.CurrentRow, "Direccion")?.ToString()
                                ?? GetCell(dgvEmpleados.CurrentRow, "Dirección")?.ToString() ?? "";
            txtNombres.Text = GetCell(dgvEmpleados.CurrentRow, "Nombres")?.ToString() ?? "";
            txtApellidos.Text = GetCell(dgvEmpleados.CurrentRow, "Apellidos")?.ToString() ?? "";
            txtDUI.Text = GetCell(dgvEmpleados.CurrentRow, "DUI")?.ToString() ?? "";
            txtEspecialidad.Text = GetCell(dgvEmpleados.CurrentRow, "Especialidad")?.ToString() ?? "";

            if (DateTime.TryParse(GetCell(dgvEmpleados.CurrentRow, "FechaContratacion")?.ToString(), out var fc))
                dtpFechaContratacion.Value = fc;
            if (DateTime.TryParse(GetCell(dgvEmpleados.CurrentRow, "FechaNacimiento")?.ToString(), out var fn))
                dtpNacimiento.Value = fn;

            var sexo = GetCell(dgvEmpleados.CurrentRow, "Sexo")?.ToString();
            if (!string.IsNullOrWhiteSpace(sexo))
            {
                var idx = cmbSexo.Items.IndexOf(sexo);
                if (idx >= 0) cmbSexo.SelectedIndex = idx;
            }

            var rol = GetCell(dgvEmpleados.CurrentRow, "Rol")?.ToString()
                      ?? GetCell(dgvEmpleados.CurrentRow, "NombreRol")?.ToString();
            if (!string.IsNullOrWhiteSpace(rol))
            {
                for (int i = 0; i < cmbRol.Items.Count; i++)
                {
                    var item = cmbRol.Items[i];
                    var nombre = item is DataRowView drv ? $"{drv["NombreRol"]}" : item.ToString();
                    if (string.Equals(nombre, rol, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbRol.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private static object? GetCell(DataGridViewRow row, string col)
        {
            if (row?.DataGridView == null) return null;
            if (!row.DataGridView.Columns.Contains(col)) return null;
            return row.Cells[col]?.Value;
        }
    }
}
