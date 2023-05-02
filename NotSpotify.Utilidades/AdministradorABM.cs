using NotSpotify.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.Utilidades
{
    public class AdministradorABM
    {

        static public void CargarUsuario(string nombre, string apellido, string eMail, string password)
        {
            Usuario unUsuario = new Usuario(nombre,apellido,eMail,password);
            VerificadorDeInicio.UsuariosCargados.Insert(0, unUsuario);
        }

        public static bool VerificarDatosPersona(string nombre, string apellido, string eMail, string password)
        {
            if (VerificadorDeInicio.VerificarExistePersona(eMail, password) == EnumOpcionSesion.noExiste
                && IsValidEmail(eMail) && VerificarAlphabetico(nombre) && VerificarAlphabetico(apellido) && !string.IsNullOrWhiteSpace(password))
            {
                return true;
            }

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool VerificarAlphabetico(string palabra)
        {
            Regex name_validation = new Regex(@"^[a-zA-Z]+$");

            if (!name_validation.IsMatch(palabra))
            {
                return false;
            }

            return true;
        }
    }
}
