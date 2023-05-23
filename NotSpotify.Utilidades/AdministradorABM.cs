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
        public static void AgregarPersonaEnLista<T>(string[] datos) where T : Persona, ICargable, new()
        {
            try
            {
                T unaPersona = new();
                unaPersona.CargarDatosDesdeArray(datos);

                VerificarDatosPersona(unaPersona); 
                VerificarPersonaNoExiste(unaPersona);
                
                VerificadorDeInicio.PersonasCargadas.Insert(0, unaPersona);            
            }
            catch (Exception)
            {
                throw;
            }
        }

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

        public static void ModificarPersonaEnLista<T>(T unaPersona, string[] datos) where T : Persona, ICargable, new()
        {
            T personaModificada = new();
            personaModificada.CargarDatosDesdeArray(datos);

            try
            {
                VerificarDatosPersona(personaModificada);
                VerificarPersonaNoExisteConExeccpion(personaModificada, unaPersona);

                for (int i = 0; i < VerificadorDeInicio.PersonasCargadas.Count; i++)
                {
                    if (VerificadorDeInicio.PersonasCargadas[i] == unaPersona)
                    {
                        VerificadorDeInicio.PersonasCargadas[i] = personaModificada;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public static void VerificarDatosPersona(Persona unaPersona)
        {
            try
            {
                EmailEsValido(unaPersona.Email);
                ValidarEsAlphabetico(unaPersona.Nombre);
                ValidarEsAlphabetico(unaPersona.Apellido);
                PasswordEsValida(unaPersona.Password);
                             
                if (unaPersona is Administrador administrador)
                {
                    DniEsValido(administrador.Dni);
                }
            }
            catch (Exception)
            {
                throw;
            }    
        }

        public static void VerificarPersonaNoExisteConExeccpion(Persona unaPersona, Persona exepcion)
        {
            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas)
            {
                if (persona == exepcion) 
                {
                    continue;
                }

                if (unaPersona == persona || (unaPersona is Administrador unAdministrador && persona is Administrador administrador && unAdministrador == administrador))
                {
                    throw new Exception("La persona ya existe");
                }
            }
        }

        public static void VerificarPersonaNoExiste(Persona unaPersona)
        {
            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas) 
            {
                if(unaPersona == persona || (unaPersona is Administrador unAdministrador && persona is Administrador administrador && unAdministrador == administrador))
                {
                    throw new Exception("La persona ya existe");
                }
            }
        }

        public static void VerificarDniLibre(string dni)
        {
            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas)
            {
                if (persona is Administrador administrador && dni == administrador.Dni)
                {
                    throw new Exception("La persona ya existe");
                }
            }
        }

        public static void EmailEsValido(string eMail)
        {
            String sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (eMail.Length > 40 || string.IsNullOrWhiteSpace(eMail) || !Regex.IsMatch(eMail, sFormato) || Regex.Replace(eMail, sFormato, String.Empty).Length != 0)
            {
                throw new Exception("El email no es valido");
            }
        }

        public static void ValidarEsAlphabetico(string palabra)
        {
            Regex name_validation = new(@"^[a-zA-Z]+$");

            if (!name_validation.IsMatch(palabra) || palabra.Length > 40 || string.IsNullOrWhiteSpace(palabra))
            {
                throw new Exception("El nombre y apellido solo puede contener letras y no mas de 40");          
            }
        }

        public static void DniEsValido(string dni)
        {
            if (!int.TryParse(dni, out _) || dni.Length != 8)
            {
                throw new Exception("El dni tiene que estar formado solo por 8 numeros");
            }
        }

        public static void PasswordEsValida(string password)
        {
            if(password.Length < 5 || password.Length > 40)
            {
                throw new Exception("La password debe tener mas de 5 caracteres y menos de 40");
            }
        }

        public static bool ConveritAdminEnUsuario(Administrador unAdmin)
        {          
            if (BorrarPersonaDeLista(unAdmin))
            {
                string[] datos = { unAdmin.Nombre, unAdmin.Apellido, unAdmin.Email, unAdmin.Password };
                AgregarPersonaEnLista<Usuario>(datos);
                return true;
            }           
            return false;
        }

        public static void ConveritUsuarioEnAdmin(Usuario unUsuario, string dni)
        {
            try
            {
                DniEsValido(dni);
                VerificarDniLibre(dni);

                if (BorrarPersonaDeLista(unUsuario))
                {
                    string[] datos = { unUsuario.Nombre, unUsuario.Apellido, unUsuario.Email, unUsuario.Password, dni };
                    AgregarPersonaEnLista<Administrador>(datos);
                }
            }
            catch 
            {
                throw;
            }
        }
    }
}
