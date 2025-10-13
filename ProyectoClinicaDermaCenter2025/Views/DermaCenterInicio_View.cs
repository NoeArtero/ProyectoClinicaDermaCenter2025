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
using ProyectoClinicaDermaCenter2025.Views.Vencimientos;
using System;                 
using System.Windows.Forms;  



namespace ProyectoClinicaDermaCenter2025
{
    public partial class DermaCenterInicio : Form
    {
        public DermaCenterInicio()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelAtencionCl.Visible = false;
            panelFinanzas.Visible = false;
            panelAdministraccion.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAtencionCl.Visible == true)
                panelAtencionCl.Visible = false;
            if (panelFinanzas.Visible == true)
                panelFinanzas.Visible = false;
            if (panelAdministraccion.Visible == true)
                panelAdministraccion.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ;
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }



        private void DermaCenterInicio_Load(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pacientes_View formPacientes = new Pacientes_View();
            formPacientes.ShowDialog();
            this.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            Citas_View formCitas = new Citas_View();
            formCitas.Show();
            this.Hide();

            hideSubMenu();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicios_View formServicios = new Servicios_View();
            formServicios.Show();
            this.Hide();

            hideSubMenu();
        }

        private void btnAseguradoras_Click(object sender, EventArgs e)
        {
            AseguradorasYPolizas_View formAseguradoras = new AseguradorasYPolizas_View();
            formAseguradoras.Show();
            this.Hide();

            hideSubMenu();
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
            Inventario_View formInventario = new Inventario_View();
            formInventario.Show();
            this.Hide();

            hideSubMenu();

        }

        private void btnVencimiento_Click(object sender, EventArgs e)
        {
           Vencimiento_View formVencimiento = new Vencimiento_View();
            formVencimiento.Show();
            this.Hide();

            hideSubMenu();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
           Proveedores_View formProveedores = new Proveedores_View();
            formProveedores.Show();
            this.Hide();

            hideSubMenu();
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFinanzas);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            PagosDeudas_View formPagos = new PagosDeudas_View();    
            formPagos.Show();
            this.Hide();

            hideSubMenu();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            Facturacion_View formFacturacion = new Facturacion_View();
            formFacturacion.Show();
            this.Hide();

            hideSubMenu();
        }

        private void btnAdministraccion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdministraccion);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleado_Roles_View formEmpleados = new Empleado_Roles_View();
            formEmpleados.Show();
            this.Hide();
             hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReporteQuincenalView formReportes = new ReporteQuincenalView();
            formReportes.Show();
            this.Hide();

            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }

}
