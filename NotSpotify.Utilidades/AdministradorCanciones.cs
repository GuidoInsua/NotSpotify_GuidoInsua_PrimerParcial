using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary.Exceptions;
using VideoLibrary;
using MediaToolkit.Model;
using MediaToolkit;
using NotSpotify.Clases;

namespace NotSpotify.Utilidades
{
    public static class AdministradorCanciones
    {
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

                VerificadorDeInicio.CancionesCargadas.Add(unaCancion);
            }
        }

        public static void AgregarCancionEnLista(string nombre, string path) 
        {
            Cancion unaCancion = new(nombre, path);

            VerificadorDeInicio.CancionesCargadas.Add(unaCancion);
        }

        public static void NombreCancionValido(string nombre)
        {
            foreach(Cancion cancion in VerificadorDeInicio.CancionesCargadas)
            {
                if (cancion.Nombre == nombre)
                {
                    throw new Exception("Ya existe esa cancion");
                }
            }
        }

        public static void BorrarCancionDeLista(Cancion unaCancion)
        {
            foreach (Cancion cancion in VerificadorDeInicio.CancionesCargadas)
            {
                if (cancion.Nombre == unaCancion.Nombre)
                {
                    VerificadorDeInicio.CancionesCargadas.Remove(cancion);
                    break;
                }
            }
        }
    }
}
