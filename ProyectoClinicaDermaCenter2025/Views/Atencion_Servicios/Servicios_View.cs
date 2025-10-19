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

namespace ProyectoClinicaDermaCenter2025.Views.Atencion_Servicios
{
    public partial class Servicios_View : Form
    {
        private int idServicioSeleccionado = 0;

        public Servicios_View()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Verificar que un servicio esté seleccionado
            if (idServicioSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un servicio de la lista para eliminar.", "Ningún Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pedir confirmación
            var confirmacion = MessageBox.Show("¿Seguro que quieres eliminar este servicio?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string connectionString = Conexion.AppConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE SERVICIO SET Estado = 'Inactivo' WHERE ID_Servicio = @ID;";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", idServicioSeleccionado);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Servicio marcado como inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarDatosServicios(); // Refrescar la lista
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el servicio: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los controles
            txtNombreServicio.Clear();
            txtDescripcion.Clear();
            numCoste.Value = 0;
            idServicioSeleccionado = 0;
            txtNombreServicio.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text))
            {
                MessageBox.Show("El nombre del servicio es obligatorio.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query;

                    if (idServicioSeleccionado == 0)
                    {

                        query = "INSERT INTO SERVICIO (NombreServicio, Descripcion, Coste, Estado) VALUES (@Nombre, @Desc, @Coste, 'Activo');";
                    }
                    else
                    {

                        query = @"UPDATE SERVICIO SET 
                            NombreServicio = @Nombre, 
                            Descripcion = @Desc, 
                            Coste = @Coste 
                          WHERE ID_Servicio = @ID;";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreServicio.Text);
                        cmd.Parameters.AddWithValue("@Desc", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Coste", numCoste.Value);

                        if (idServicioSeleccionado != 0)
                        {
                            cmd.Parameters.AddWithValue("@ID", idServicioSeleccionado);
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Servicio guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDatosServicios();
                        btnLimpiar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el servicio: " + ex.Message);
            }
        }

        private void Servicios_View_Load(object sender, EventArgs e)
        {
            CargarDatosServicios(false);
        }

        private void CargarDatosServicios(bool mostrarInactivos = false)
        {
            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // La consulta base ahora no tiene el WHERE
                    string query = "SELECT ID_Servicio, NombreServicio, Descripcion, Coste, Estado FROM SERVICIO";

                    // Si el CheckBox NO está marcado, añadimos el filtro para ver solo los activos
                    if (!mostrarInactivos)
                    {
                        query += " WHERE Estado = 'Activo'";
                    }

                    query += ";"; // Cerramos la sentencia

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvServicios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los servicios: " + ex.Message);
            }
        }


        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (dgvServicios.Rows[e.RowIndex].IsNewRow) return;

                DataGridViewRow fila = dgvServicios.Rows[e.RowIndex];


                idServicioSeleccionado = Convert.ToInt32(fila.Cells["ID_Servicio"].Value);


                txtNombreServicio.Text = fila.Cells["NombreServicio"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                numCoste.Value = Convert.ToDecimal(fila.Cells["Coste"].Value);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosServicios(chkMostrarInactivos.Checked);
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (idServicioSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un servicio inactivo de la lista para reactivar.", "Ningún Servicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            var confirmacion = MessageBox.Show("¿Estás seguro de que quieres reactivar este servicio?", "Confirmar Reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string connectionString = Conexion.AppConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE SERVICIO SET Estado = 'Activo' WHERE ID_Servicio = @ID;";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", idServicioSeleccionado);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Servicio reactivado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarDatosServicios(chkMostrarInactivos.Checked);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al reactivar el servicio: " + ex.Message);
                }
            }
        }
    }
}
