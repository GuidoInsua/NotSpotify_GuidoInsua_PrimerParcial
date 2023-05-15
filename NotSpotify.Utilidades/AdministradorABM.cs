using NotSpotify.Clases;
using NotSpotify.Clases.Interfaces;
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
        static public bool BorrarPersonaDeLista(Persona unaPersona)
        {
            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas)
            {
                if (persona == unaPersona)
                {
                    return VerificadorDeInicio.PersonasCargadas.Remove(persona);                
                }
            }
            return false; 
        }

        public static bool CargarPersonaEnLista<T>(string[] datos) where T : Persona, ICargable, new()
        {
            T unaPersona = new T();
            unaPersona.CargarDatosDesdeArray(datos);

            if (VerificarDatosPersona(unaPersona) && VerificarEmailLibre(unaPersona.Email))
            {
                VerificadorDeInicio.PersonasCargadas.Insert(0, unaPersona);
                return true;
            }
            return false;
        }

        public static bool ModificarPersonaEnLista<T>(Persona unaPersona, string[] datos) where T : Persona, ICargable, new()
        {
            T personaModificada = new T();
            personaModificada.CargarDatosDesdeArray(datos);

            if(!VerificarDatosPersona(personaModificada))
            {
                return false;
            }

            for (int i = 0; i < VerificadorDeInicio.PersonasCargadas.Count; i++)
            {
                if (VerificadorDeInicio.PersonasCargadas[i] == unaPersona)
                {
                    VerificadorDeInicio.PersonasCargadas[i] = personaModificada;
                    return true;
                }
            }
            return false;
        }

        public static bool VerificarDatosPersona(Persona unaPersona)
        {
            if (IsValidEmail(unaPersona.Email) && VerificarAlphabetico(unaPersona.Nombre) && VerificarAlphabetico(unaPersona.Apellido) && !string.IsNullOrWhiteSpace(unaPersona.Password))
            {
                if (unaPersona is Administrador && string.IsNullOrWhiteSpace(((Administrador)unaPersona).Dni))
                {
                    return false;
                }

                return true;
            }
            return false;
        }

        public static bool VerificarEmailLibre(string eMail)
        {
            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas) 
            {
                if(persona.Email == eMail)
                {
                    return false;
                }
            }
            return true;
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
