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
            esAdmin = 1,
            esUsuario = 2,
            noExiste = 0
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

        static public EnumOpcionSesion VerificarExistePersona(string eMailIngresado, string passwordIngresada)
        {

            if (AdministradorDatos.CompararDatos<Administrador>(eMailIngresado, passwordIngresada, AdminsCargados))
            {
                return EnumOpcionSesion.esAdmin;
            }

            if (AdministradorDatos.CompararDatos<Usuario>(eMailIngresado, passwordIngresada, UsuariosCargados))
            {
                return EnumOpcionSesion.esUsuario;
            }

            return EnumOpcionSesion.noExiste;
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
