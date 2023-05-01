using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using NotSpotify.Clases;

namespace NotSpotify.Metodos
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
            UsuariosCargados = AdministradorDeUsuarios.CargarDatosDesdeArchivo<Usuario>("D:\\Code\\C#\\PrimerParcial_GuidoInsua_C#\\NotSpotify\\Archivos\\Usuarios.csv");
            AdminsCargados = AdministradorDeUsuarios.CargarDatosDesdeArchivo<Administrador>("D:\\Code\\C#\\PrimerParcial_GuidoInsua_C#\\NotSpotify\\Archivos\\Administradores.csv");
        }

        static public EnumOpcionSesion VerificarDatosDeIngreso(string eMailIngresado, string passwordIngresada)
        {

            if (EsAdmin(eMailIngresado, passwordIngresada))
            {
                return EnumOpcionSesion.admin;
            }

            if (EsUsuario(eMailIngresado, passwordIngresada))
            {
                return EnumOpcionSesion.usuario;
            }

            return EnumOpcionSesion.error;
        }

        static private bool EsUsuario(string eMailIngresado, string passwordIngresada)
        {
            foreach (Usuario usuario in UsuariosCargados)
            {
                if (usuario.Email == eMailIngresado && usuario.Password == passwordIngresada)
                {
                    return true;
                }
            }

            return false;
        }

        static private bool EsAdmin(string eMailIngresado, string passwordIngresada)
        {
            foreach (Administrador admin in AdminsCargados)
            {
                if (admin.Email == eMailIngresado && admin.Password == passwordIngresada)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
