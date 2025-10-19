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
using Microsoft.VisualBasic;

namespace ProyectoClinicaDermaCenter2025.Views.Inventario
{


    public partial class Inventario_View : Form
    {
        private DataTable dtInventario;
        private int idProductoSeleccionado = 0;
        public Inventario_View()
        {
            InitializeComponent();
        }
        private void CargarDatos(bool mostrarInactivos = false)
        {
            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                   

                    
                    string queryInventario = @"
                SELECT 
                    p.ID_Producto, p.NombreProducto AS 'Nombre del Producto',
                    p.ID_Proveedor, pr.Nombre AS 'Proveedor', 
                    p.CantidadStock AS 'Cantidad', p.FechaVencimiento AS 'Vencimiento', 
                    p.Estado, p.Descripcion
                FROM PRODUCTO AS p
                LEFT JOIN PROVEEDOR AS pr ON p.ID_Proveedor = pr.ID_Proveedor";

                   
                    if (!mostrarInactivos)
                    {
                        queryInventario += " WHERE p.Estado = 'Activo'";
                    }

                    queryInventario += ";"; 

                    SqlDataAdapter daInventario = new SqlDataAdapter(queryInventario, con);
                    dtInventario = new DataTable();
                    daInventario.Fill(dtInventario);
                    dgvInventario.DataSource = dtInventario;

                    dgvInventario.Columns["ID_Proveedor"].Visible = false;

                
                    string queryProveedores = "SELECT ID_Proveedor, Nombre FROM PROVEEDOR ORDER BY Nombre;";
                    SqlDataAdapter daProveedores = new SqlDataAdapter(queryProveedores, con);
                    DataTable dtProveedores = new DataTable();
                    daProveedores.Fill(dtProveedores);

                    cmbProveedor.DataSource = dtProveedores;
                    cmbProveedor.DisplayMember = "Nombre";
                    cmbProveedor.ValueMember = "ID_Proveedor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void Inventario_View_Load(object sender, EventArgs e)
        {
            CargarDatos(false);

        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto de la lista para editar.", "Ningún Producto Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE PRODUCTO SET 
                                        NombreProducto = @Nombre,
                                        ID_Proveedor = @ID_Proveedor,
                                        CantidadStock = @Cantidad,
                                        FechaVencimiento = @Vencimiento,
                                        Descripcion = @Descripcion
                                     WHERE 
                                        ID_Producto = @ID_Producto;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                        cmd.Parameters.AddWithValue("@ID_Proveedor", (int)cmbProveedor.SelectedValue);
                        cmd.Parameters.AddWithValue("@Cantidad", numCantidadStock.Value);
                        cmd.Parameters.AddWithValue("@Vencimiento", dtpFechaVencimiento.Value);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@ID_Producto", idProductoSeleccionado);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto de la lista para eliminar.", "Ningún Producto Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Estás seguro? El producto se marcará como inactivo.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string connectionString = Conexion.AppConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE PRODUCTO SET Estado = 'Inactivo' WHERE ID_Producto = @ID;";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", idProductoSeleccionado);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Producto marcado como inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarDatos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                if (dgvInventario.Rows[e.RowIndex].IsNewRow)
                {
                    return;
                }


                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];


                idProductoSeleccionado = Convert.ToInt32(fila.Cells["ID_Producto"].Value);
                txtNombreProducto.Text = fila.Cells["Nombre del Producto"].Value.ToString();
                cmbProveedor.SelectedValue = fila.Cells["ID_Proveedor"].Value;
                numCantidadStock.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);

                if (fila.Cells["Descripcion"].Value != DBNull.Value)
                {
                    txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                }

                if (fila.Cells["Vencimiento"].Value != DBNull.Value)
                {
                    dtpFechaVencimiento.Value = Convert.ToDateTime(fila.Cells["Vencimiento"].Value);
                }
            }
        }


        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            numCantidadStock.Value = 0;
            cmbProveedor.SelectedIndex = -1;
            dtpFechaVencimiento.Value = DateTime.Now;
            idProductoSeleccionado = 0;
            txtNombreProducto.Focus();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos(chkMostrarInactivos.Checked);
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto inactivo de la lista.", "Ningún Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PRODUCTO SET Estado = 'Activo' WHERE ID_Producto = @ID;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", idProductoSeleccionado);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto reactivado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDatos(chkMostrarInactivos.Checked); // Refresca la lista manteniendo el filtro actual
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reactivar el producto: " + ex.Message);
            }
        }
    }
}


