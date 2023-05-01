using NotSpotify.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Utilidades
{
    static public class VerificadorDeInicio
    {
        public enum EnumOpcionSesion
        {
            admin = 1,
            usuario = 2,
            error = 0
        }

        static private List<Usuario> _usuariosCargados;
        static private List<Administrador> _adminsCargados;

        static public List<Usuario> UsuariosCargados { get => _usuariosCargados; set => _usuariosCargados = value; }
        static public List<Administrador> AdminsCargados { get => _adminsCargados; set => _adminsCargados = value; }

        static VerificadorDeInicio()
        {
            string[] dir = Directory.GetDirectories(".\\");

            UsuariosCargados = AdministradorDatos.CargarListaDesdeArchivo<Usuario>("..\\..\\..\\..\\Archivos\\Usuarios.csv");
            AdminsCargados = AdministradorDatos.CargarListaDesdeArchivo<Administrador>("..\\..\\..\\..\\Archivos\\Administradores.csv");
        }

        static public EnumOpcionSesion VerificarDatosDeIngreso(string eMailIngresado, string passwordIngresada)
        {

            if (CompararDatos<Administrador>(eMailIngresado, passwordIngresada, AdminsCargados))
            {
                return EnumOpcionSesion.admin;
            }

            if (CompararDatos<Usuario>(eMailIngresado, passwordIngresada, UsuariosCargados))
            {
                return EnumOpcionSesion.usuario;
            }

            return EnumOpcionSesion.error;
        }

        static private bool CompararDatos<T>(string eMailIngresado, string passwordIngresada, List<T> personas) where T : Persona
        {
            foreach (T persona in personas)
            {
                if (persona.Email == eMailIngresado && persona.Password == passwordIngresada)
                {
                    return true;
                }
            }

            return false;
        }

        static public void AutoCompletarUsuario(out string eMail, out string password)
        {
            Random numRandom = new Random();

            Usuario usuario = UsuariosCargados[numRandom.Next(UsuariosCargados.Count)];

            eMail = usuario.Email;
            password = usuario.Password;
        }

        static public void AutoCompletarAdmin(out string eMail, out string password)
        {
            Random numRandom = new Random();

            Administrador admin = AdminsCargados[numRandom.Next(AdminsCargados.Count)];

            eMail = admin.Email;
            password = admin.Password;
        }
    }
}
