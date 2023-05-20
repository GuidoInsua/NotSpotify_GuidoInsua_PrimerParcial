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
            PlayList unaPlayList = new PlayList("PlayList1", "Rock", "..\\..\\..\\..\\Imagenes\\sumo.png");

            for (int i = 0; i < 10; i++)
            {
                playLists.Add(unaPlayList);
            }
        }

    }
}
