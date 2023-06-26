using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NotSpotify.Clases;
using NotSpotify.Clases.Factories;
using NotSpotify.Clases.Interfaces;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.Utilidades
{
    static public class AdministradorDatos
    {
        /// <summary>
        /// crea una lista desde un archivo csv
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        static public List<T> CrearListaDesdeArchivo<T>(string path) where T : ICargable, new()
        {
            string separador = ",";
            string linea;

            using StreamReader sr = File.OpenText(path);
            List<T> listaDeCargable = new();
            T unCargable;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);

                unCargable = new T();
                unCargable.CargarDatosDesdeArray(fila);

                listaDeCargable.Add(unCargable);
            }

            return listaDeCargable;
        }

        /// <summary>
        /// carga la lista de personas con los datos del archivo csv
        /// </summary>
        /// <param name="path"></param>
        static public void CargarListaPersonasDesdeArchivo(string path)
        {            
            using StreamReader sr = File.OpenText(path);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                try
                {
                    string[] datos = linea.Split(",");
                    PersonaFactory.CargarPersonaPorLastOrDefault(datos);
                }
                catch { }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objetos"></param>
        /// <param name="path"></param>
        static public void GuardarListaEnCsv<T>(List<T> objetos, string nombre) where T : ICargable
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(escritorio, nombre);

            using StreamWriter writer = new(rutaArchivo);
            string lineaCsv;

            foreach (T objeto in objetos)
            {
                lineaCsv = objeto.GuardarEnCsv();

                writer.WriteLine(lineaCsv);
            }
        }

        static public void GuardarListaEnJson<T>(List<T> objetos, string nombre) where T : ICargable
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(escritorio, nombre);

            using StreamWriter writer = new(rutaArchivo);

            string json = JsonConvert.SerializeObject(objetos, Formatting.Indented);

            writer.Write(json);
        }
    }
}
