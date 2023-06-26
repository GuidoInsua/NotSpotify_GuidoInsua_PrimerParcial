﻿using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Cancion : ICargable
    {
        private string _nombre = string.Empty;
        private string _direccion = string.Empty;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public Cancion()
        { 
        }

        public Cancion(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void CargarDatosDesdeArray(string[] fila)
        {
            throw new NotImplementedException();
        }

        public string GuardarDatosEnSql()
        {
            throw new NotImplementedException();
        }

        public string GuardarEnCsv()
        {
            return $"{Nombre},{Direccion}";
        }
    }
}
