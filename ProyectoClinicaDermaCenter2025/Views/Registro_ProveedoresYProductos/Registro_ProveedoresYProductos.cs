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

namespace ProyectoClinicaDermaCenter2025.Views.Proveedores
{
    public partial class Registro_ProveedoresYProductos : Form
    {
        public Registro_ProveedoresYProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // --- 1. VALIDACIÓN ---
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtNombreDelProducto.Text))
            {
                MessageBox.Show("El nombre del proveedor y del producto son obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int idProveedor = 0;
                    string nombreProveedor = txtNombreProveedor.Text.Trim();

                    // --- 2. BUSCAR O CREAR EL PROVEEDOR
                    string selectQuery = "SELECT ID_Proveedor FROM PROVEEDOR WHERE Nombre = @Nombre";
                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        cmdSelect.Parameters.AddWithValue("@Nombre", nombreProveedor);
                        object result = cmdSelect.ExecuteScalar();

                        if (result != null)
                        {
                            idProveedor = Convert.ToInt32(result);
                        }
                        else
                        {
                            string insertProveedorQuery = "INSERT INTO PROVEEDOR (Nombre, Contacto, Telefono) VALUES (@Nombre, @Contacto, @Telefono); SELECT SCOPE_IDENTITY();";
                            using (SqlCommand cmdInsertProv = new SqlCommand(insertProveedorQuery, con))
                            {
                                cmdInsertProv.Parameters.AddWithValue("@Nombre", nombreProveedor);
                                cmdInsertProv.Parameters.AddWithValue("@Contacto", txtPContacto.Text);
                                cmdInsertProv.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                                idProveedor = Convert.ToInt32(cmdInsertProv.ExecuteScalar());
                            }
                        }
                    }

                    // --- 3. GUARDAR EL PRODUCTO (VERSIÓN FINAL) ---
                    if (idProveedor > 0)
                    {
                        // Se quita 'PuntoReorden' de la consulta SQL
                        string insertProductoQuery = @"
                    INSERT INTO PRODUCTO (ID_Proveedor, NombreProducto, Descripcion, CantidadStock, FechaVencimiento) 
                    VALUES (@ID_Proveedor, @NombreProducto, @Descripcion, @Cantidad, @Vencimiento);";

                        using (SqlCommand cmdInsertProd = new SqlCommand(insertProductoQuery, con))
                        {
                            cmdInsertProd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                            cmdInsertProd.Parameters.AddWithValue("@NombreProducto", txtNombreDelProducto.Text);
                            cmdInsertProd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                            cmdInsertProd.Parameters.AddWithValue("@Cantidad", numCantidad.Value);
                            cmdInsertProd.Parameters.AddWithValue("@Vencimiento", dtpFechaDeVencimiento.Value);

                            // --- LÍNEA ELIMINADA ---
                            // Ya no se necesita el parámetro para PuntoReorden

                            cmdInsertProd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Producto y proveedor guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // --- Limpiar campos
            txtNombreProveedor.Clear();
            txtPContacto.Clear();
            txtTelefono.Clear();
            txtNombreDelProducto.Clear();
            txtDescripcion.Clear();
            numCantidad.Value = 0;
            dtpFechaDeVencimiento.Value = DateTime.Now;
            txtNombreProveedor.Focus();
        }
    }
}
