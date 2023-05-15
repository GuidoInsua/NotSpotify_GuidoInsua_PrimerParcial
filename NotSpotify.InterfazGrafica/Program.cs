

using static NotSpotify.Utilidades.VerificadorDeInicio;

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

            if(loginForm.TipoDeUsuarioAutenticado == EnumOpcionSesion.esUsuario || loginForm.TipoDeUsuarioAutenticado == EnumOpcionSesion.esAdmin)
            {
                Application.Run(new FrmMenu(loginForm.TipoDeUsuarioAutenticado));
            }
        }
    }
}