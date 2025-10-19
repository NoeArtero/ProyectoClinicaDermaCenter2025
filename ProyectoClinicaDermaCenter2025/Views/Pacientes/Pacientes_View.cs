using Microsoft.Data.SqlClient;
using ProyectoClinicaDermaCenter2025.ConexionDB;
using ProyectoClinicaDermaCenter2025.Controllers;
using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Models.Pacientes;
using ProyectoClinicaDermaCenter2025.Views.Aseguradoras_Polizas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;




namespace ProyectoClinicaDermaCenter2025.Views.Pacientes
{
    public partial class Pacientes_View : Form
    {


        public Pacientes_View()
        {
            InitializeComponent();
        }

        private void Pacientes_View_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDUI.Text))
            {
                MessageBox.Show("El nombre completo y el DNI son obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string connectionString = ProyectoClinicaDermaCenter2025.ConexionDB.Conexion.AppConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int nuevoIdPersona = 0;

                    string personaQuery = @"
                INSERT INTO PERSONA (DUI, Nombres, Apellidos, FechaNacimiento, Direccion, Sexo, Pais, Estado)
                VALUES (@DUI, @Nombre, @Apellidos, @FechaNacimiento, @Direccion, @Sexo, @Pais, 'Activo');
                SELECT SCOPE_IDENTITY();";

                    // Separar nombre completo a Nombre y apellidos
                    string nombreCompleto = txtNombre.Text.Trim();
                    string nombre = nombreCompleto;
                    string apellidos = "";
                    int primerEspacio = nombreCompleto.IndexOf(' ');
                    if (primerEspacio != -1)
                    {
                        nombre = nombreCompleto.Substring(0, primerEspacio);
                        apellidos = nombreCompleto.Substring(primerEspacio + 1);
                    }

                    using (SqlCommand cmdPersona = new SqlCommand(personaQuery, con))
                    {
                        cmdPersona.Parameters.AddWithValue("@DUI", txtDUI.Text);
                        cmdPersona.Parameters.AddWithValue("@Nombres", nombre);
                        cmdPersona.Parameters.AddWithValue("@Apellidos", apellidos);
                        cmdPersona.Parameters.AddWithValue("@FechaNacimiento", dtFechaNac.Value);
                        cmdPersona.Parameters.AddWithValue("@Direccion", txtDirrec.Text);
                        cmdPersona.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
                        cmdPersona.Parameters.AddWithValue("@Pais", cmbPais.Text);

                        nuevoIdPersona = Convert.ToInt32(cmdPersona.ExecuteScalar());
                    }

                    if (nuevoIdPersona > 0)
                    {
                        // Guardar en la tabla paciente
                        string pacienteQuery = "INSERT INTO PACIENTE (ID_Paciente) VALUES (@ID_Paciente);";
                        using (SqlCommand cmdPaciente = new SqlCommand(pacienteQuery, con))
                        {
                            cmdPaciente.Parameters.AddWithValue("@ID_Paciente", nuevoIdPersona);
                            cmdPaciente.ExecuteNonQuery();
                        }

                        // Guardar en la tabla Contacto
                        string contactoQuery = "INSERT INTO CONTACTO (ID_Persona, TipoContacto, ValorContacto) VALUES (@ID_Persona, @Tipo, @Valor);";
                        if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
                        {
                            using (SqlCommand cmdCorreo = new SqlCommand(contactoQuery, con))
                            {
                                cmdCorreo.Parameters.AddWithValue("@ID_Persona", nuevoIdPersona);
                                cmdCorreo.Parameters.AddWithValue("@Tipo", "Correo");
                                cmdCorreo.Parameters.AddWithValue("@Valor", txtCorreo.Text);
                                cmdCorreo.ExecuteNonQuery();
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
                        {
                            using (SqlCommand cmdTelefono = new SqlCommand(contactoQuery, con))
                            {
                                cmdTelefono.Parameters.AddWithValue("@ID_Persona", nuevoIdPersona);
                                cmdTelefono.Parameters.AddWithValue("@Tipo", "Teléfono");
                                cmdTelefono.Parameters.AddWithValue("@Valor", txtTelefono.Text);
                                cmdTelefono.ExecuteNonQuery();
                            }
                        }

                        // Guardar en HISTORIAL MEDICO
                        string historialQuery = "INSERT INTO HISTORIAL_MEDICO (ID_Paciente, TipoRegistro, Descripcion) VALUES (@ID_Paciente, @Tipo, @Desc);";

                        if (cmbAlergias.SelectedItem != null && !string.IsNullOrEmpty(cmbAlergias.Text))
                        {
                            using (SqlCommand cmdHistorial = new SqlCommand(historialQuery, con))
                            {
                                cmdHistorial.Parameters.AddWithValue("@ID_Paciente", nuevoIdPersona);
                                cmdHistorial.Parameters.AddWithValue("@Tipo", "Alergia");
                                cmdHistorial.Parameters.AddWithValue("@Desc", cmbAlergias.SelectedItem.ToString());
                                cmdHistorial.ExecuteNonQuery();
                            }
                        }
                       
                        if (!string.IsNullOrWhiteSpace(txtOtrasAlergias.Text))
                        {
                            using (SqlCommand cmdHistorial = new SqlCommand(historialQuery, con))
                            {
                                cmdHistorial.Parameters.AddWithValue("@ID_Paciente", nuevoIdPersona);
                                cmdHistorial.Parameters.AddWithValue("@Tipo", "Alergia (Otras)");
                                cmdHistorial.Parameters.AddWithValue("@Desc", txtOtrasAlergias.Text);
                                cmdHistorial.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("¡Paciente registrado exitosamente con toda su información!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el paciente: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDUI.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            cmbPais.SelectedIndex = -1;
            cmbAlergias.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            dtFechaNac.Value = DateTime.Now;
            txtNombre.Focus();
        }

        private void btnAseguradoraP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDUI.Text))
            {
                MessageBox.Show("Para agregar una aseguradora, primero debes llenar el nombre completo y el DNI del paciente.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevoIdPersona = 0;

            try
            {
                string connectionString = Conexion.AppConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string personaQuery = @"
                INSERT INTO PERSONA (DUI, Nombres, Apellidos, FechaNacimiento, Direccion, Sexo, Pais, Estado)
                VALUES (@DUI, @Nombres, @Apellidos, @FechaNacimiento, @Direccion, @Sexo, @Pais, 'Activo');
                SELECT SCOPE_IDENTITY();";

                    string nombreCompleto = txtNombre.Text.Trim();
                    string nombre = nombreCompleto;
                    string apellidos = "";
                    int primerEspacio = nombreCompleto.IndexOf(' ');
                    if (primerEspacio != -1)
                    {
                        nombre = nombreCompleto.Substring(0, primerEspacio);
                        apellidos = nombreCompleto.Substring(primerEspacio + 1);
                    }

                    using (SqlCommand cmdPersona = new SqlCommand(personaQuery, con))
                    {
                        cmdPersona.Parameters.AddWithValue("@DUI", txtDUI.Text);
                        cmdPersona.Parameters.AddWithValue("@Nombres", nombre);
                        cmdPersona.Parameters.AddWithValue("@Apellidos", apellidos);
                        cmdPersona.Parameters.AddWithValue("@FechaNacimiento", dtFechaNac.Value);
                        cmdPersona.Parameters.AddWithValue("@Direccion", txtDirrec.Text);
                        cmdPersona.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
                        cmdPersona.Parameters.AddWithValue("@Pais", cmbPais.Text);

                        // Esta línea guarda al paciente y obtiene el nuevo ID
                        nuevoIdPersona = Convert.ToInt32(cmdPersona.ExecuteScalar());
                    }

                    // ---  SI EL PACIENTE SE CREÓ, GUARDAR DATOS RELACIONADOS ---
                    if (nuevoIdPersona > 0)
                    {
                        // Guardar en PACIENTE
                        string pacienteQuery = "INSERT INTO PACIENTE (ID_Paciente) VALUES (@ID_Paciente);";
                        using (SqlCommand cmdPaciente = new SqlCommand(pacienteQuery, con))
                        {
                            cmdPaciente.Parameters.AddWithValue("@ID_Paciente", nuevoIdPersona);
                            cmdPaciente.ExecuteNonQuery();
                        }


                    }

                    if (nuevoIdPersona > 0)
                    {
                        MessageBox.Show("Paciente guardado. Ahora, por favor, registra la aseguradora.", "Paso 1 Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide(); // Ocultamos el form de pacientes
                        AseguradorasYPolizas_View formAseguradora = new AseguradorasYPolizas_View(nuevoIdPersona);
                        formAseguradora.ShowDialog();
                        this.Show(); // Lo volvemos a mostrar cuando el de aseguradoras se cierre
                    }
                    else
                    {
                        // Si por alguna razón el ID sigue siendo 0 después de intentar guardar, mostramos el mensaje de error
                        MessageBox.Show("No se pudo obtener el ID del nuevo paciente. No se puede continuar al registro de la aseguradora.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el paciente: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAlergias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Revisar si el item seleccionado es "Otros..."
            if (cmbAlergias.SelectedItem != null && cmbAlergias.SelectedItem.ToString() == "Otros...")
            {
                // Si es Otros..., hacemos visible el Label y el TextBox y saldra lo que dice el label xd.
                lblInstruccionAlergia.Text = "Especifique cuál:";
                lblInstruccionAlergia.Visible = true;
                txtOtrasAlergias.Visible = true;
                txtOtrasAlergias.Focus(); 
            }
            else
            {
                // Si se selecciona cualquier otra cosa, ocultamos los controles osea el label y textbox .
                lblInstruccionAlergia.Visible = false;
                txtOtrasAlergias.Visible = false;
                txtOtrasAlergias.Clear();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpiar Campos de Texto
            txtNombre.Clear();
            txtDUI.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtContactoF.Clear();
            txtTelefono.Clear();
            txtDirrec.Clear();
            txtOtrasAlergias.Clear(); 
            cmbPais.SelectedIndex = -1;
            cmbAlergias.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            dtFechaNac.Value = DateTime.Now;
            txtNombre.Focus();
        }
    }
}