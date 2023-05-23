﻿using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class PlayList : ICargable
    {
        private string _nombre;
        private string _descripccion;
        private List<Cancion> _canciones;
        private string _direccionDeImagen;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripccion { get => _descripccion; set => _descripccion = value; }
        public List<Cancion> Canciones { get => _canciones; set => _canciones = value; }
        public string DireccionDeImagen { get => _direccionDeImagen; set => _direccionDeImagen = value; }

        public PlayList()
        {
        }

        public PlayList(string nombre, List<Cancion> canciones)
        {
            Nombre = nombre;
            Canciones = canciones;
        }

        public PlayList(string nombre, List<Cancion> canciones, string descripccion, string direccionDeImagen) : this(nombre, canciones)
        {
            Descripccion = descripccion;
            DireccionDeImagen = direccionDeImagen;
        }

        public PlayList(string nombre, string descripccion, string direccionDeImagen)
        {
            Nombre = nombre;
            Descripccion = descripccion;
            DireccionDeImagen = direccionDeImagen;
        }

        public void CargarDatosDesdeArray(string[] fila)
        {
            Nombre = fila[0];
            Descripccion = fila[1];
            DireccionDeImagen = fila[2];
        }
    }
}
