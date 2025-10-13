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

namespace ProyectoClinicaDermaCenter2025.Views
{
    public partial class Login_View : Form
    {
        public Login_View()
        {
            InitializeComponent();
        }

        public static class Sesion
        {
            public static int IdEmpleado { get; set; }
            public static int IdRol { get; set; }
            public static string? Nombre { get; set; }
            public static string? RolNombre { get; set; }
        }
        private SqlConnection NuevaConexion() => new SqlConnection(Conexion.AppConnectionString);
        private void Login_View_Load(object sender, EventArgs e)
        {
            errorLogin.Clear();
            try
            {
                using var cn = NuevaConexion();
                var sql = @"
SELECT  e.ID_Empleado,
        (p.Apellidos + ', ' + p.Nombres) AS Nombre,
        e.ID_Rol
FROM    dbo.EMPLEADO e
JOIN    dbo.PERSONA  p ON p.ID_Persona = e.ID_Empleado
WHERE   p.Estado = 'Activo'
ORDER BY p.Apellidos, p.Nombres;";
                using var da = new SqlDataAdapter(sql, cn);
                var dt = new DataTable();
                da.Fill(dt);

                cmbUsuario.DisplayMember = "Nombre";
                cmbUsuario.ValueMember = "ID_Empleado";
                cmbUsuario.DataSource = dt;
                cmbUsuario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                errorLogin.SetError(cmbUsuario, ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorLogin.Clear();
            bool ok = true;

            if (cmbUsuario.SelectedIndex < 0) { errorLogin.SetError(cmbUsuario, "Seleccione un usuario."); ok = false; }
            if (string.IsNullOrWhiteSpace(txtClave.Text)) { errorLogin.SetError(txtClave, "Ingrese la clave."); ok = false; }
            if (!ok) return;

            int idEmpleado = (int)((DataRowView)cmbUsuario.SelectedItem)["ID_Empleado"];

            try
            {
                using var cn = NuevaConexion();
                using var cmd = new SqlCommand("dbo.sp_Login_Empleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
                cmd.Parameters.AddWithValue("@Clave", txtClave.Text.Trim());
                cn.Open();
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Sesion.IdEmpleado = rd.GetInt32(rd.GetOrdinal("ID_Empleado"));
                    Sesion.IdRol = rd.GetInt32(rd.GetOrdinal("ID_Rol"));
                    Sesion.Nombre = rd["NombreMostrado"] as string;
                    Sesion.RolNombre = rd["NombreRol"] as string;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    errorLogin.SetError(txtClave, "Credenciales inválidas (verifique los últimos 4 del DUI).");
                }
            }
            catch (Exception ex)
            {
                errorLogin.SetError(cmbUsuario, ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
