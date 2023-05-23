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

        public static void CargarPlayLists()
        {
            playLists = AdministradorDatos.CrearListaDesdeArchivo<PlayList>("..\\..\\..\\..\\Archivos\\PlayLists.csv");
        }

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
