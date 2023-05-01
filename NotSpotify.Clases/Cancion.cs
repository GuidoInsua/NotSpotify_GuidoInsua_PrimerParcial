using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Cancion : ICargable
    {
        private string _nombre;
        private string _direccion;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public Cancion(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void CargarDatosDesdeLinea(string linea, string separador)
        {
            string[] fila = linea.Split(separador);
            Nombre = fila[0];
            Direccion = fila[1];
        }
    }
}
