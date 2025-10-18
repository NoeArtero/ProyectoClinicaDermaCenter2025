using ProyectoClinicaDermaCenter2025.ConexionDB;
using System.Text;

namespace ProyectoClinicaDermaCenter2025
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // <- necesario para RDLC


            ApplicationConfiguration.Initialize();
            try { Conexion.Initialize(); }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible preparar la BD.\n\n" + ex.Message, "DermaCenter - Error");
                return;
            }

            using (var login = new Views.Login_View())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
            }

            Application.Run(new DermaCenterInicio());

        }
    }
}