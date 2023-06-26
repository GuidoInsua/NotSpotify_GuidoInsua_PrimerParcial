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
        }

        static private List<Persona> _personasCargadas = new();

        static public List<Persona> PersonasCargadas { get => _personasCargadas; set => _personasCargadas = value; }

        /// <summary>
        /// carga las listas de personas, canciones y playlists
        /// </summary>
        static VerificadorDeInicio()
        {
            _personasCargadas = new List<Persona>();
            AdministradorCanciones.CargarListaCancionesDesdeDirectorio("..\\..\\..\\..\\Canciones");
        }

        /// <summary>
        /// varifica el tipo de persona logeada
        /// </summary>
        /// <param name="eMailIngresado"></param>
        /// <param name="passwordIngresada"></param>
        /// <returns></returns>
        static public EnumOpcionSesion VerificarTipoDePersona(string eMailIngresado, string passwordIngresada)
        {
            try
            {
                foreach (Persona persona in PersonasCargadas)
                {
                    if (persona.Email == eMailIngresado && persona.Password == passwordIngresada)
                    {
                        if (persona is Administrador)
                        {
                            return EnumOpcionSesion.esAdmin;
                        }

                        if (persona is Usuario)
                        {
                            return EnumOpcionSesion.esUsuario;
                        }                        
                    }
                }

                throw new Exception("Persona no logueada, no existe clase");
            }
            catch
            {
                throw new Exception("Persona no logueada");
            }         
        }

        /// <summary>
        /// autocompleta los valores de logeo con una persona valida
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="eMail"></param>
        /// <param name="password"></param>
        static public void AutoCompletarLogin<T>(ref string eMail, ref string password) where T : Persona
        {
            foreach (Persona persona in PersonasCargadas)
            {
                if(persona is T)
                {
                    eMail = persona.Email;
                    password = persona.Password;
                    break;
                }
            }
        }
    }
}
