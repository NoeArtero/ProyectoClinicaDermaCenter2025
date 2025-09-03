using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using ProyectoClinicaDermaCenter2025.Controllers;
using ProyectoClinicaDermaCenter2025.Interfaces.Repositorios;
using ProyectoClinicaDermaCenter2025.Models.Pacientes;
using ProyectoClinicaDermaCenter2025.Models.stubs; 

namespace ProyectoClinicaDermaCenter2025.Views.Pacientes
{
    public partial class Pacientes_View : Form
    {
        private readonly PacienteController _controller;
        private readonly BindingSource _bs = new BindingSource();

        public Pacientes_View() : this(new PacienteController(new PacienteRepositoryStub())) { }

        public Pacientes_View(PacienteController controller)
        {
            InitializeComponent();
            _controller = controller;

            this.Load += Pacientes_View_Load;
            dgvPacientes.SelectionChanged += (s, e) => LlenarCamposDesdeSeleccion();
            btnListar.Click += (s, e) => CargarPacientes();
            btnBuscar.Click += (s, e) => Buscar();
            btnNuevo.Click += (s, e) => Limpiar();
            btnGuardar.Click += (s, e) => GuardarNuevo();
            btnEditar.Click += (s, e) => GuardarEdicion();
            btnEliminar.Click += (s, e) => EliminarSeleccionado();

            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            dgvPacientes.AutoGenerateColumns = false;
            dgvPacientes.Columns.Clear();

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true,
                Width = 60
            });
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDocumento",
                HeaderText = "Documento",
                DataPropertyName = "Documento",
                Width = 150
            });

            dgvPacientes.DataSource = _bs;
        }

        private void Pacientes_View_Load(object sender, EventArgs e) => CargarPacientes();

        private void CargarPacientes()
        {
            try
            {
                var data = _controller.Listar(txtFiltro.Text?.Trim());
                var rows = data.Select(ToRow).ToList();
                _bs.DataSource = new BindingList<PacienteRow>(rows);
                dgvPacientes.Refresh();
                if (dgvPacientes.Rows.Count > 0) dgvPacientes.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {
                var filtro = txtFiltro.Text?.Trim();
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    CargarPacientes();
                    return;
                }

                var p = _controller.BuscarPorDocumento(filtro);
                var lista = new List<Paciente>();
                if (p != null) lista.Add(p);

                _bs.DataSource = new BindingList<PacienteRow>(lista.Select(ToRow).ToList());
                dgvPacientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarNuevo()
        {
            try
            {
                var p = new Paciente();
                SetPropSiExiste(p, "Nombre", txtNombre.Text?.Trim());
                SetPropSiExiste(p, "Documento", txtDocumento.Text?.Trim());

                var res = _controller.crear(p); 
                MessageBox.Show(res.msg, res.ok ? "OK" : "Error",
                    MessageBoxButtons.OK, res.ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (res.ok) { Limpiar(); CargarPacientes(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarEdicion()
        {
            try
            {
                if (dgvPacientes.CurrentRow?.DataBoundItem is PacienteRow row)
                {
                    var p = new Paciente();
                    SetPropSiExiste(p, "Id", row.Id); 
                    SetPropSiExiste(p, "Nombre", txtNombre.Text?.Trim());
                    SetPropSiExiste(p, "Documento", txtDocumento.Text?.Trim());

                    var res = _controller.Editar(p);
                    MessageBox.Show(res.msg, res.ok ? "OK" : "Error",
                        MessageBoxButtons.OK, res.ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (res.ok) { Limpiar(); CargarPacientes(); }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para editar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarSeleccionado()
        {
            try
            {
                if (dgvPacientes.CurrentRow?.DataBoundItem is PacienteRow row)
                {
                    if (MessageBox.Show("¿Eliminar el paciente seleccionado?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                    var res = _controller.Eliminar(row.Id);
                    MessageBox.Show(res.msg, res.ok ? "OK" : "Error",
                        MessageBoxButtons.OK, res.ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (res.ok) { Limpiar(); CargarPacientes(); }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            dgvPacientes.ClearSelection();
        }

        private void LlenarCamposDesdeSeleccion()
        {
            if (dgvPacientes.CurrentRow?.DataBoundItem is PacienteRow row)
            {
                txtNombre.Text = row.Nombre ?? string.Empty;
                txtDocumento.Text = row.Documento ?? string.Empty;
            }
        }

        private sealed class PacienteRow
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Documento { get; set; }
        }

        private static PacienteRow ToRow(Paciente p) => new PacienteRow
        {
            Id = GetIntProp(p, "Id") ?? 0,
            Nombre = GetStringProp(p, "Nombre") ?? GetStringProp(p, "Nombres") ?? "",
            Documento = GetStringProp(p, "Documento") ?? GetStringProp(p, "DUI") ?? ""
        };

        private static void SetPropSiExiste(object obj, string propName, object value)
        {
            var p = obj.GetType().GetProperty(propName, BindingFlags.Public | BindingFlags.Instance);
            if (p != null && p.CanWrite) p.SetValue(obj, value);
        }

        private static int? GetIntProp(object obj, string prop)
        {
            var p = obj.GetType().GetProperty(prop, BindingFlags.Public | BindingFlags.Instance);
            if (p == null) return null;
            var v = p.GetValue(obj);
            if (v == null) return null;
            if (v is int i) return i;
            return int.TryParse(v.ToString(), out var parsed) ? parsed : null;
        }

        private static string GetStringProp(object obj, string prop)
        {
            var p = obj.GetType().GetProperty(prop, BindingFlags.Public | BindingFlags.Instance);
            return p?.GetValue(obj)?.ToString();
        }
    }
}
