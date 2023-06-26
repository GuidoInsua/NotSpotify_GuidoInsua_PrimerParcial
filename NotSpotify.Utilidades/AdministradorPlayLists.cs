using NotSpotify.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Utilidades
{
    public static class AdministradorPlayLists
    {
        public static List<PlayList> playLists = new List<PlayList>();

        /// <summary>
        /// carga la lista de playlist desde el archivo csv
        /// </summary>
        public static void CargarPlayLists()
        {
            playLists = AdministradorDatos.CrearListaDesdeArchivo<PlayList>("..\\..\\..\\..\\Archivos\\PlayLists.csv");
        }

        public static void AgregarPlayListEnLista(string[] datos)
        {
            try
            {
                PlayList unaPlayList = new PlayList();
                unaPlayList.CargarDatosDesdeArray(datos);

                playLists.Insert(0, unaPlayList);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// genera listas de canciones aleatorias para cada playList
        /// </summary>
        public static void GenerarListasDeCanciones()
        {
            Random r = new Random();
            for (int i = 0; i < playLists.Count; i++) 
            {
                List<Cancion> canciones = new();

                for (int j = 0; j < 15 ; j++) 
                {
                    int k = r.Next(1,95);
                    canciones.Add(AdministradorCanciones.CancionesCargadas[j + k]);                               
                }

                playLists[i].Canciones = canciones;
            }
        }
    }
}
