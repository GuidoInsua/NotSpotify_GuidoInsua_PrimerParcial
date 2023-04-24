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
        static private List<Usuario> _usuariosCargados;
        static private Administrador _admin;

        static public List<Usuario> UsuariosCargados { get => _usuariosCargados; set => _usuariosCargados = value; }
        static public Administrador Admin { get => _admin; set => _admin = value; }

        static VerificadorDeInicio()
        {
            UsuariosCargados = ModificadorDeUsuraios.HardCodearUsuarios();
            Admin = ModificadorDeUsuraios.HardCodearAdmin();
        }

        static public int VerificarDatosDeIngreso(string eMailIngresado, string passwordIngresada)
        {

            if (EsAdmin(eMailIngresado,passwordIngresada))
            {
                return 1;
            }

            if (EsUsuario(eMailIngresado, passwordIngresada))
            {
                return 2;
            }

            return 0;
        }

        static private bool EsUsuario(string eMailIngresado, string passwordIngresada)
        {
            foreach (Usuario usuario in _usuariosCargados)
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
            if (Admin.Email == eMailIngresado && Admin.Password == passwordIngresada)
            {
                return true;
            }

            return false;
        }
    }
}
