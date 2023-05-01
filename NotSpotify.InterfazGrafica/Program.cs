using NotSpotify.Metodos;
using static NotSpotify.Metodos.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
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
            ApplicationConfiguration.Initialize();

            FrmLogin loginForm = new FrmLogin();
            Application.Run(loginForm);

            if(loginForm.EstadoUsuarioAutenticado == EnumOpcionSesion.usuario)
            {
                Application.Run(new FrmMenu());
            }

            if (loginForm.EstadoUsuarioAutenticado == EnumOpcionSesion.admin)
            {
                Application.Run(new FrmAdmin());
            }
        }
    }
}