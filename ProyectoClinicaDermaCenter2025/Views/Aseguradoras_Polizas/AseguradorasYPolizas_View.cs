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

namespace ProyectoClinicaDermaCenter2025.Views.Aseguradoras_Polizas
{

    public partial class AseguradorasYPolizas_View : Form
    {

        private int idDelPaciente;
        public AseguradorasYPolizas_View()
        {
            InitializeComponent();
        }

        // Este constructor especial es el que llamaremos desde el formulario de Pacientes.
        // Acepta un número entero (el ID del paciente) como parámetro.
        public AseguradorasYPolizas_View(int idPacienteRecibido)
        {
            InitializeComponent();

            // Guardamos el ID que nos pasaron en nuestra variable privada.
            this.idDelPaciente = idPacienteRecibido;
        }

        private void AseguradorasYPolizas_View_Load(object sender, EventArgs e)
        {

        }


        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreAseguradora.Clear();
            txtNumeroPoliza.Clear();
            txtNombreAseguradora.Focus();
        }

        private void btnGuardarAseguradoraPoliza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAseguradora.Text) || string.IsNullOrWhiteSpace(txtNumeroPoliza.Text))
            {
                MessageBox.Show("El nombre de la aseguradora y el número de póliza son obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int idAseguradora = 0;
                    string nombreAseguradora = txtNombreAseguradora.Text.Trim();

                    // 1. Buscar o Crear la Aseguradora
                    string selectQuery = "SELECT ID_Aseguradora FROM ASEGURADORA WHERE Nombre = @Nombre";
                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        cmdSelect.Parameters.AddWithValue("@Nombre", nombreAseguradora);
                        object result = cmdSelect.ExecuteScalar();

                        if (result != null)
                        {
                            idAseguradora = Convert.ToInt32(result);
                        }
                        else
                        {
                            string insertAseguradoraQuery = "INSERT INTO ASEGURADORA (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();";
                            using (SqlCommand cmdInsert = new SqlCommand(insertAseguradoraQuery, con))
                            {
                                cmdInsert.Parameters.AddWithValue("@Nombre", nombreAseguradora);
                                idAseguradora = Convert.ToInt32(cmdInsert.ExecuteScalar());
                            }
                        }
                    }

                    // 2. Guardar la Póliza
                    if (idAseguradora > 0)
                    {
                        string insertPolizaQuery = "INSERT INTO POLIZA (ID_Paciente, ID_Aseguradora, NumeroDePoliza) VALUES (@ID_Paciente, @ID_Aseguradora, @Numero);";
                        using (SqlCommand cmdPoliza = new SqlCommand(insertPolizaQuery, con))
                        {
                            cmdPoliza.Parameters.AddWithValue("@ID_Paciente", this.idDelPaciente);
                            cmdPoliza.Parameters.AddWithValue("@ID_Aseguradora", idAseguradora);
                            cmdPoliza.Parameters.AddWithValue("@Numero", txtNumeroPoliza.Text);
                            cmdPoliza.ExecuteNonQuery();
                        }

                        MessageBox.Show("Póliza de seguro guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la póliza: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
