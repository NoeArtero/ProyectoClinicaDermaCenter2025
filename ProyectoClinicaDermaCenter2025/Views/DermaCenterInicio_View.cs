using ProyectoClinicaDermaCenter2025.Recursos;
using ProyectoClinicaDermaCenter2025.Controllers;
using ProyectoClinicaDermaCenter2025.Views.Aseguradoras_Polizas;
using ProyectoClinicaDermaCenter2025.Views.Atencion_Servicios;
using ProyectoClinicaDermaCenter2025.Views.Citas;
using ProyectoClinicaDermaCenter2025.Views.Empleados;
using ProyectoClinicaDermaCenter2025.Views.Facturacion_Pagos;
using ProyectoClinicaDermaCenter2025.Views.Inventario;
using ProyectoClinicaDermaCenter2025.Views.Pacientes;
using ProyectoClinicaDermaCenter2025.Views.Pagos;
using ProyectoClinicaDermaCenter2025.Views.Proveedores;
using ProyectoClinicaDermaCenter2025.Views.Reportes;
using System;                 
using System.Windows.Forms;
using static ProyectoClinicaDermaCenter2025.Views.Login_View;



namespace ProyectoClinicaDermaCenter2025
{
    public partial class DermaCenterInicio : Form
    {
        public DermaCenterInicio()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void AplicarPermisosPorRol()
        {
            switch (Sesion.IdRol)
            {
                case 1:
                    btnFinanzas.Visible = panelFinanzas.Visible = false;
                    btnAdministraccion.Visible = panelAdministraccion.Visible = false;
                    break;
                case 2: 
                    btnEmpleados.Visible = panelFinanzas.Visible = false;
                    btnServicios.Visible = panelFinanzas.Visible = false;
                    break;
                case 3: 
                   
                    break;
                case 4:
                    btnEmpleados.Visible = panelFinanzas.Visible = false;
                    btnServicios.Visible = panelFinanzas.Visible = false;
                    break;

            }
        }

        private void CustomizeDesign()
        {
            panelAtencionCl.Visible = false;
            panelFinanzas.Visible = false;
            panelInventario.Visible = false;
            panelAdministraccion.Visible = false;
        }

        

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
            
                OcultarSubMenus();
                subMenu.Visible = true;
            }
        }



        private void DermaCenterInicio_Load(object sender, EventArgs e)
        {
           AplicarPermisosPorRol();
            OcultarSubMenus();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Pacientes_View formPacientes = new Pacientes_View();
            formPacientes.ShowDialog();
            this.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Citas_View formCitas = new Citas_View();
            formCitas.ShowDialog();
            this.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Servicios_View formServicios = new Servicios_View();
            formServicios.ShowDialog();
            this.Show();
        }

       

        private void btnAtencionCl_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelAtencionCl);
        }

        private void btnInventarioFarmacia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelInventario);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Inventario_View formInventario = new Inventario_View();
            formInventario.ShowDialog();
            this.Show();
        }
        

      

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Registro_ProveedoresYProductos formProveedores = new Registro_ProveedoresYProductos();
            formProveedores.ShowDialog();
            this.Show();
        }

        private void OcultarSubMenus()
        {
            if (panelInventario.Visible == true)
                panelInventario.Visible = false;
            if (panelFinanzas.Visible == true)
                panelFinanzas.Visible = false;
            if (panelAdministraccion.Visible == true)
                panelAdministraccion.Visible = false;

            if (panelAtencionCl.Visible == true)
                panelAtencionCl.Visible = false;
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFinanzas);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Pagos_View formPagos = new Pagos_View();
            formPagos.ShowDialog();
            this.Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Facturacion_View formFacturacion = new Facturacion_View();
            formFacturacion.ShowDialog();
            this.Show();
        }

        private void btnAdministraccion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdministraccion);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            Empleado_Roles_View formEmpleados = new Empleado_Roles_View();
            formEmpleados.ShowDialog();
            this.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OcultarSubMenus();
            this.Hide();
            ReporteQuincenalView formReportes = new ReporteQuincenalView();
            formReportes.ShowDialog();
            this.Show();
        }

        private void CerrarSesion()
        {
            var r = MessageBox.Show("¿Cerrar sesión y volver al login?", "Cerrar sesión",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            Sesion.IdEmpleado = 0;
            Sesion.IdRol = 0;
            Sesion.Nombre = null;
            Sesion.RolNombre = null;

            this.Hide();
            using (var login = new ProyectoClinicaDermaCenter2025.Views.Login_View())
            {
                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AplicarPermisosPorRol();
                    OcultarSubMenus();
                    this.Show();
                }
                else
                {
                    this.Close(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }


    }

}
