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
        static public void CargarPersonaPorLastOrDefault(string linea, string separador)
        {
            string[] fila = linea.Split(separador);

            switch (fila.LastOrDefault())
            {
                case "Administrador":
                    AdministradorABM.AgregarPersonaEnLista<Administrador>(fila);
                    break;
                case "Usuario":
                    AdministradorABM.AgregarPersonaEnLista<Usuario>(fila);
                    break;
                default:
                    throw new ArgumentException("Error");
            }
        }
    }
}
