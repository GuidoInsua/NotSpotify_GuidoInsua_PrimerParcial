using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary.Exceptions;
using System.Media;
using VideoLibrary;
using MediaToolkit.Model;
using MediaToolkit;
using NotSpotify.Clases;



namespace NotSpotify.Utilidades
{
    public static class AdministradorCanciones
    {
        static private List<Cancion> _cancionesCargadas = new();
        static public string tema = "..\\..\\..\\..\\Canciones\\Estallando.mp3";

        static public List<Cancion> CancionesCargadas { get => _cancionesCargadas; set => _cancionesCargadas = value; }

        public static void SaveMP3(string SaveToFolder, string VideoURL, string MP3Name)
        {
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, vid.FullName);
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, vid.FullName) };
            var outputFile = new MediaFile { Filename = Path.Combine(source, $"{MP3Name}.mp3") };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);


                engine.Convert(inputFile, outputFile);
            }

            File.Delete(Path.Combine(source, vid.FullName));
        }

        public static void CargarListaCancionesDesdeDirectorio(string path)
        {
            string[] pathCanciones = Directory.GetFiles(path, "*.mp3");

            for (int i = 0; i < pathCanciones.Length; i++)
            {
                string[] nombreIncompleto = pathCanciones[i].Split(@"\");
                string[] nombre = nombreIncompleto[5].Split(".");

                Cancion unaCancion = new(nombre[0], pathCanciones[i]);

                AdministradorCanciones.CancionesCargadas.Add(unaCancion);
            }
        }

        public static void AgregarCancionEnLista(string nombre, string path) 
        {
            Cancion unaCancion = new(nombre, path);

            AdministradorCanciones.CancionesCargadas.Add(unaCancion);
        }

        public static void NombreCancionValido(string nombre)
        {
            foreach(Cancion cancion in AdministradorCanciones.CancionesCargadas)
            {
                if (cancion.Nombre == nombre)
                {
                    throw new Exception("Ya existe esa cancion");
                }
            }
        }

        public static void BorrarCancionDeLista(Cancion unaCancion)
        {
            foreach (Cancion cancion in AdministradorCanciones.CancionesCargadas)
            {
                if (cancion.Nombre == unaCancion.Nombre)
                {
                    AdministradorCanciones.CancionesCargadas.Remove(cancion);
                    break;
                }
            }
        }

        public static void SeleccionarCancion(Cancion unaCancion, List<Cancion> listaCanciones)
        {
            foreach (Cancion cancion in listaCanciones)
            {
                if (cancion.Nombre == unaCancion.Nombre)
                {
                    tema = cancion.Direccion;
                }
            }
        }
    }
}
