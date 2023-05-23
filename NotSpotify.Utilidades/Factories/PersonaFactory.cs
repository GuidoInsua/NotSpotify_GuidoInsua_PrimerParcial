using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases.Factories
{
    public class PersonaFactory
    {
        /// <summary>
        /// carga las personas desde un SCV y las diferencia por su ultimo parametro
        /// </summary>
        /// <param name="linea"></param>
        /// <param name="separador"></param>
        /// <exception cref="Exception"></exception>
        static public void CargarPersonaPorLastOrDefault(string linea, string separador)
        {
            string[] fila = linea.Split(separador);

            try
            {
                switch (fila.LastOrDefault())
                {
                    case "Administrador":
                        AdministradorABM.AgregarPersonaEnLista<Administrador>(fila);
                        break;
                    case "Usuario":
                        AdministradorABM.AgregarPersonaEnLista<Usuario>(fila);
                        break;
                    default:
                        throw new ArgumentException("Error no es Usuario o Administrador");
                }
            }
            catch
            {
                throw new Exception("Datos incorrectos no fue cargado");
            }
        }
    }
}
