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

        static private List<Cancion> _cancionesCargadas = new();
        static private List<Persona> _personasCargadas = new();
        static private Persona _personaLogueada = new();   

        static public List<Cancion> CancionesCargadas { get => _cancionesCargadas; set => _cancionesCargadas = value; }
        static public Persona PersonaLogueada { get => _personaLogueada; set => _personaLogueada = value; }
        static public List<Persona> PersonasCargadas { get => _personasCargadas; set => _personasCargadas = value; }

        static VerificadorDeInicio()
        {
            _personasCargadas = new List<Persona>();
            AdministradorDatos.CargarListaPersonasDesdeArchivo("..\\..\\..\\..\\Archivos\\Personas.csv");
            AdministradorCanciones.CargarListaCancionesDesdeDirectorio("..\\..\\..\\..\\Canciones");
            AdministradorPlayLists.CargarPlayLists();
        }

        static public EnumOpcionSesion VerificarTipoDePersona(string eMailIngresado, string passwordIngresada)
        {
            try
            {
                PersonaLogueada = AdministradorDatos.BuscarPersonaLogueada(eMailIngresado, passwordIngresada, PersonasCargadas);

                if (PersonaLogueada is Administrador)
                {
                    return EnumOpcionSesion.esAdmin;
                }

                if (PersonaLogueada is Usuario)
                {
                    return EnumOpcionSesion.esUsuario;
                }

                throw new Exception("Datos correctos, no existe clase");
            }
            catch
            {
                throw;
            }         
        }

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
