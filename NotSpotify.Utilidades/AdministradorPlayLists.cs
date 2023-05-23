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
    }
}
