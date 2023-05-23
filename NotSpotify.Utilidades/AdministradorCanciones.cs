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

        /// <summary>
        /// Descarga un video de youtube, lo convierte en mp3 y lo guarda en el directorio
        /// </summary>
        /// <param name="directorio"></param>
        /// <param name="VideoURL"></param>
        /// <param name="MP3Name"></param>
        public static void SaveMP3(string directorio, string VideoURL, string MP3Name)
        {
            string source = directorio;
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

        /// <summary>
        /// lee los archivos mp3 de un directorio y los guarda en una lista de canciones
        /// </summary>
        /// <param name="path"></param>
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

        /// <summary>
        /// agrega una cancion a la lista de canciones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="path"></param>
        public static void AgregarCancionEnLista(string nombre, string path) 
        {
            Cancion unaCancion = new(nombre, path);

            AdministradorCanciones.CancionesCargadas.Add(unaCancion);
        }

        /// <summary>
        /// valida que el nombre de la cancion no exista
        /// </summary>
        /// <param name="nombre"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// elimina una cancion de la lista de canciones
        /// </summary>
        /// <param name="unaCancion"></param>
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

        /// <summary>
        /// guarda la direccion de la cancion en la variable tema
        /// </summary>
        /// <param name="unaCancion"></param>
        /// <param name="listaCanciones"></param>
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
