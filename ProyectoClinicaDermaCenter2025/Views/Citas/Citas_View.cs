using Microsoft.Data.SqlClient;
using ProyectoClinicaDermaCenter2025.ConexionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinicaDermaCenter2025.Views.Citas
{
    public partial class Citas_View : Form
    {
        public Citas_View()
        {
            InitializeComponent();



            btnListar.Click += (_, __) => CargarGrid();
            btnHoy.Click += (_, __) => CargarRango(DateTime.Today, DateTime.Today);
            btnManiana.Click += (_, __) => CargarRango(DateTime.Today.AddDays(1), DateTime.Today.AddDays(1));

            this.AcceptButton = btnBuscar;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.MultiSelect = false;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            this.DoubleBuffered = true;
            this.Shown += (s, e) => { btnListar.PerformClick(); };

        }




        private bool _creando = false;

        private SqlConnection NuevaConexion() => new SqlConnection(Conexion.AppConnectionString);

        private void ResetEditor()
        {
            cmbMedico.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today.AddHours(9);
            dateTimePicker2.Value = DateTime.Today.AddHours(9).AddMinutes(30);
            txtMotivo.Clear();
            txtNotas.Clear();
            errorCitas.Clear();
        }


        private void Citas_View_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMedicos();
                CargarPacientes();
                CargarEstados();

                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today.AddDays(7);
                dtpFecha.Value = DateTime.Today;

                dateTimePicker1.CustomFormat = "HH:mm";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.ShowUpDown = true;
                dateTimePicker1.Value = DateTime.Today.AddHours(9);

                dateTimePicker2.CustomFormat = "HH:mm";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.ShowUpDown = true;
                dateTimePicker2.Value = DateTime.Today.AddHours(9).AddMinutes(30);

                ToggleBotonesEdicion(false);

            }
            catch (Exception ex)
            {
                errorCitas.SetError(dgvCitas, ex.Message);
            }
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            var hayFila = dgvCitas.CurrentRow != null;
            ToggleBotonesEdicion(hayFila);
            if (!hayFila) return;

            var row = ((DataRowView)dgvCitas.CurrentRow.DataBoundItem).Row;

            if (row.Table.Columns.Contains("ID_Medico"))
                cmbMedico.SelectedValue = Convert.ToInt32(row["ID_Medico"]);
            if (row.Table.Columns.Contains("ID_Paciente"))
                cmbPaciente.SelectedValue = Convert.ToInt32(row["ID_Paciente"]);

            if (row.Table.Columns.Contains("FechaHora") && row["FechaHora"] != DBNull.Value)
            {
                var fh = Convert.ToDateTime(row["FechaHora"]);
                dtpFecha.Value = fh.Date;
                dateTimePicker1.Value = DateTime.Today.Add(fh.TimeOfDay);
            }


            if (row.Table.Columns.Contains("Motivo")) txtMotivo.Text = row["Motivo"]?.ToString() ?? "";
            if (row.Table.Columns.Contains("Notas")) txtNotas.Text = row["Notas"]?.ToString() ?? "";

        }

        private void ToggleBotonesEdicion(bool habilitar)
        {
            btnReprogramar.Enabled = habilitar;
            btnCancelarCita.Enabled = habilitar;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (_creando) return;
            _creando = true;
            btnCrear.Enabled = false;

            if (!ValidarFormulario(out var idMedico, out var idPaciente, out var ini, out _))
            {
                _creando = false;
                btnCrear.Enabled = true;
                return;
            }

            try
            {
                var msg = TryCrearCita(idPaciente, idMedico, ini, out int? nuevoId);
                MessageBox.Show(nuevoId.HasValue ? $"{msg} (ID: {nuevoId.Value})" : msg, "DermaCenter");
                btnBuscar_Click(null, EventArgs.Empty);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _creando = false;
                btnCrear.Enabled = true;
            }

            try
            {
                CargarMedicos();
                CargarPacientes();
                CargarEstados();

                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today.AddDays(7);
                dtpFecha.Value = DateTime.Today;

                dateTimePicker1.CustomFormat = "HH:mm";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.ShowUpDown = true;
                dateTimePicker1.Value = DateTime.Today.AddHours(9);

                dateTimePicker2.CustomFormat = "HH:mm";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.ShowUpDown = true;
                dateTimePicker2.Value = DateTime.Today.AddHours(9).AddMinutes(30);

                CargarGrid();
                ToggleBotonesEdicion(false);

                ResetEditor();
            }
            catch (Exception ex)
            {
                errorCitas.SetError(dgvCitas, ex.Message);
            }


        }

        private string TryCrearCita(int idPaciente, int idMedico, DateTime fechaHora, out int? nuevoId)
        {
            nuevoId = null;

            using var cn = NuevaConexion();
            using var cmd = new SqlCommand("dbo.sp_Cita_Crear", cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.Add("@ID_Paciente", SqlDbType.Int).Value = idPaciente;
            cmd.Parameters.Add("@ID_Medico", SqlDbType.Int).Value = idMedico;
            cmd.Parameters.Add("@FechaHora", SqlDbType.DateTime).Value = fechaHora;

            var pOut = new SqlParameter("@NuevoId", SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(pOut);

            cn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                if (pOut.Value is int val) nuevoId = val;
                return "Cita creada correctamente.";
            }
            catch (SqlException ex) when (ex.Number == 8144 ||
                                          ex.Message.Contains("too many arguments", StringComparison.OrdinalIgnoreCase))
            {
                cmd.Parameters.Remove(pOut);
                if (cmd.Parameters.Contains("@Estado")) cmd.Parameters.RemoveAt("@Estado");
                cmd.ExecuteNonQuery();
                return "Cita creada correctamente.";
            }
        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? idMedico = cmbMedico.SelectedIndex >= 0 ? (int?)Convert.ToInt32(cmbMedico.SelectedValue) : null;
            int? idPaciente = cmbPaciente.SelectedIndex >= 0 ? (int?)Convert.ToInt32(cmbPaciente.SelectedValue) : null;
            var est = cmbEstado.SelectedItem?.ToString();
            var d = dtpDesde.Value.Date;
            var h = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
            CargarGrid(idMedico, idPaciente, d, h, est);


        }

        private bool _reprogramando = false;

        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            if (_reprogramando) return;
            _reprogramando = true;
            btnReprogramar.Enabled = false;

            try
            {
                if (dgvCitas.CurrentRow == null) { MessageBox.Show("Seleccione la cita."); return; }
                if (!ValidarFormulario(out var idMedico, out var idPaciente, out var ini, out _)) return;

                var row = ((DataRowView)dgvCitas.CurrentRow.DataBoundItem).Row;
                int idCita = Convert.ToInt32(row["ID_Cita"]);

                using var cn = NuevaConexion();
                cn.Open();
                using var tx = cn.BeginTransaction();

                using (var cmd = new SqlCommand("dbo.sp_Cita_Reprogramar", cn, tx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Cita", idCita);
                    cmd.Parameters.AddWithValue("@NuevaFechaHora", ini);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd2 = new SqlCommand(
                    @"UPDATE dbo.CITA 
              SET Estado = 'Reprogramada' 
              WHERE ID_Cita = @ID_Cita AND Estado <> 'Cancelada';", cn, tx))
                {
                    cmd2.Parameters.AddWithValue("@ID_Cita", idCita);
                    cmd2.ExecuteNonQuery();
                }

                tx.Commit();
                MessageBox.Show("Cita reprogramada.", "DermaCenter");
                btnBuscar_Click(null, EventArgs.Empty);

                CargarGrid();
                ToggleBotonesEdicion(false);

                ResetEditor();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                _reprogramando = false;
                btnReprogramar.Enabled = true;
            }
        }


        private bool _cancelando = false;

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            if (_cancelando) return;
            _cancelando = true;
            btnCancelarCita.Enabled = false;

            try
            {
                if (dgvCitas.CurrentRow == null) { MessageBox.Show("Seleccione la cita."); return; }
                var row = ((DataRowView)dgvCitas.CurrentRow.DataBoundItem).Row;
                int idCita = Convert.ToInt32(row["ID_Cita"]);
                if (MessageBox.Show("¿Cancelar esta cita?", "Confirmación", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                using var cn = NuevaConexion();
                using var cmd = new SqlCommand("dbo.sp_Cita_Cancelar", cn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@ID_Cita", idCita);
                var motivo = string.IsNullOrWhiteSpace(txtMotivo.Text) ? (object)DBNull.Value : txtMotivo.Text.Trim();
                if (cmd.Parameters.Contains("@Motivo")) cmd.Parameters["@Motivo"].Value = motivo;

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cita cancelada.", "DermaCenter");
                btnBuscar_Click(null, EventArgs.Empty);

                CargarGrid();
                ToggleBotonesEdicion(false);
                ResetEditor();

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                _cancelando = false;
                btnCancelarCita.Enabled = true;
            }
        }


        private void CargarMedicos()
        {
            using var cn = NuevaConexion();
            var sql = @"
SELECT e.ID_Empleado   AS ID_Medico,
       (p.Apellidos + ', ' + p.Nombres) AS NombreMedico
FROM   dbo.EMPLEADO e
JOIN   dbo.PERSONA  p ON p.ID_Persona = e.ID_Empleado
JOIN   dbo.ROL      r ON r.ID_Rol = e.ID_Rol
WHERE  p.Estado='Activo' AND r.NombreRol='Medico'
ORDER BY p.Apellidos, p.Nombres;";
            using var da = new SqlDataAdapter(sql, cn);
            var dt = new DataTable(); da.Fill(dt);
            cmbMedico.DisplayMember = "NombreMedico";
            cmbMedico.ValueMember = "ID_Medico";
            cmbMedico.DataSource = dt;
            cmbMedico.SelectedIndex = -1;
        }

        private void CargarPacientes()
        {
            using var cn = NuevaConexion();
            var sql = @"
SELECT pa.ID_Paciente,
       (p.Apellidos + ', ' + p.Nombres) AS NombrePaciente
FROM   dbo.PACIENTE pa
JOIN   dbo.PERSONA  p ON p.ID_Persona = pa.ID_Paciente
WHERE  p.Estado='Activo'
ORDER BY p.Apellidos, p.Nombres;";
            using var da = new SqlDataAdapter(sql, cn);
            var dt = new DataTable(); da.Fill(dt);
            cmbPaciente.DisplayMember = "NombrePaciente";
            cmbPaciente.ValueMember = "ID_Paciente";
            cmbPaciente.DataSource = dt;
            cmbPaciente.SelectedIndex = -1;
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new[] { "Activa", "Cancelada", "Reprogramada", "Completada", "Todos" });
            cmbEstado.SelectedIndex = 0;

        }

        // listar y buscar
        private void CargarGrid(int? idMedico = null, int? idPaciente = null,
                        DateTime? desde = null, DateTime? hasta = null,
                        string? estado = null)
        {
            using var cn = NuevaConexion();
            var sql = @"
SELECT  c.ID_Cita, c.ID_Medico, c.ID_Paciente,
        c.FechaHora, c.Estado,
        Medico   = pm.Apellidos + ', ' + pm.Nombres,
        Paciente = pp.Apellidos + ', ' + pp.Nombres
FROM    dbo.CITA c
JOIN    dbo.PERSONA pm ON pm.ID_Persona = c.ID_Medico
JOIN    dbo.PERSONA pp ON pp.ID_Persona = c.ID_Paciente
WHERE   (@ID_Medico   IS NULL OR c.ID_Medico   = @ID_Medico)
  AND   (@ID_Paciente IS NULL OR c.ID_Paciente = @ID_Paciente)
  AND   (@Desde IS NULL OR c.FechaHora >= @Desde)
  AND   (@Hasta IS NULL OR c.FechaHora <= @Hasta)
  AND   (@Estado IS NULL OR c.Estado = @Estado)
ORDER BY c.FechaHora DESC;";

            using var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID_Medico", (object?)idMedico ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ID_Paciente", (object?)idPaciente ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Desde", (object?)desde ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Hasta", (object?)hasta ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Estado", string.IsNullOrWhiteSpace(estado) || estado == "Todos" ? DBNull.Value : estado);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable(); da.Fill(dt);
            dgvCitas.DataSource = dt;
            dgvCitas.AutoResizeColumns();

            if (dgvCitas.Columns.Contains("ID_Cita")) dgvCitas.Columns["ID_Cita"].Visible = false;
            if (dgvCitas.Columns.Contains("ID_Medico")) dgvCitas.Columns["ID_Medico"].Visible = false;
            if (dgvCitas.Columns.Contains("ID_Paciente")) dgvCitas.Columns["ID_Paciente"].Visible = false;

            if (dgvCitas.Columns.Contains("FechaHora"))
                dgvCitas.Columns["FechaHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            ToggleBotonesEdicion(dgvCitas.Rows.Count > 0 && dgvCitas.CurrentRow != null);

        }


        private void CargarRango(DateTime desde, DateTime hasta)
        {
            dtpDesde.Value = desde;
            dtpHasta.Value = hasta;
            btnBuscar_Click(null, EventArgs.Empty);
        }

        // Crear reprogramar cancelar
        private DateTime Combine(DateTime fecha, DateTime hora) =>
            fecha.Date.AddHours(hora.Hour).AddMinutes(hora.Minute);

        private bool ValidarFormulario(out int idMedico, out int idPaciente, out DateTime ini, out DateTime fin)
        {
            errorCitas.Clear();
            idMedico = idPaciente = 0; ini = fin = DateTime.MinValue;
            bool ok = true;

            if (cmbMedico.SelectedIndex < 0) { errorCitas.SetError(cmbMedico, "Seleccione un médico."); ok = false; }
            if (cmbPaciente.SelectedIndex < 0) { errorCitas.SetError(cmbPaciente, "Seleccione un paciente."); ok = false; }

            var i = Combine(dtpFecha.Value, dateTimePicker1.Value);
            var f = Combine(dtpFecha.Value, dateTimePicker2.Value);
            if (f <= i) { errorCitas.SetError(dateTimePicker2, "Hora fin debe ser mayor que inicio."); ok = false; }

            if (!ok) return false;

            idMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            idPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            ini = i; fin = f;
            return true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private bool _completando = false;

        private void btnCompletada_Click(object sender, EventArgs e)
        {
            if (_completando) return;
            _completando = true;
            btnCompletada.Enabled = false;

            try
            {
                if (dgvCitas.CurrentRow == null) { MessageBox.Show("Seleccione la cita."); return; }
                var row = ((DataRowView)dgvCitas.CurrentRow.DataBoundItem).Row;
                int idCita = Convert.ToInt32(row["ID_Cita"]);

                using var cn = NuevaConexion();
                using var cmd = new SqlCommand(
                    @"UPDATE dbo.CITA SET Estado='Completada' 
              WHERE ID_Cita=@ID_Cita AND Estado <> 'Cancelada';", cn);
                cmd.Parameters.AddWithValue("@ID_Cita", idCita);
                cn.Open();
                int n = cmd.ExecuteNonQuery();

                if (n > 0) MessageBox.Show("Cita marcada como completada.", "DermaCenter");
                else MessageBox.Show("No se pudo completar (¿está cancelada?).", "DermaCenter");

                btnBuscar_Click(null, EventArgs.Empty);

                CargarGrid();
                ToggleBotonesEdicion(false);
                ResetEditor();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                _completando = false;
                btnCompletada.Enabled = true;
            }
        }

        private void panelX_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
