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

        /// <summary>
        /// Completa los campos de la playList con los valores del array
        /// </summary>
        /// <param name="fila"></param>
        public void CargarDatosDesdeArray(string[] fila)
        {
            Nombre = fila[0];
            Descripccion = fila[1];
            DireccionDeImagen = fila[2];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GuardarDatosEnSql()
        {
            return "INSERT INTO PlayLists (Nombre, Descripccion, DireccionDeImagen) " +
                 $"VALUES ('{Nombre}', '{Descripccion}', '{DireccionDeImagen}')";
        }

        public string GuardarEnCsv()
        {
            return $"{Nombre},{Descripccion},{DireccionDeImagen}";
        }
    }
}
