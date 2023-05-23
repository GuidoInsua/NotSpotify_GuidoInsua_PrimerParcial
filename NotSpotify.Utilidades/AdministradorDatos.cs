using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NotSpotify.Clases;
using NotSpotify.Clases.Factories;
using NotSpotify.Clases.Interfaces;

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
                    PersonaFactory.CargarPersonaPorLastOrDefault(linea, ",");
                }
                catch { }
            }
        }

        /// <summary>
        /// pasa la lista de personas a un archivo csv
        /// </summary>
        /// <param name="path"></param>
        static public void GuardarListaPersonasEnArchivo(string path)
        {
            using StreamWriter writer = new(path);
            string unaPersonaCsv;

            foreach (Persona perosona in VerificadorDeInicio.PersonasCargadas)
            {
                unaPersonaCsv = perosona.GuardarDatosEnLinea();

                writer.WriteLine(unaPersonaCsv);
            }
        }

        /// <summary>
        /// retorna la persona que concida con los valores ingresados
        /// </summary>
        /// <param name="eMailIngresado"></param>
        /// <param name="passwordIngresada"></param>
        /// <param name="personas"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        static public Persona BuscarPersonaLogueada(string eMailIngresado, string passwordIngresada, List<Persona> personas)
        {
            foreach (Persona persona in personas)
            {
                if (persona.Email == eMailIngresado && persona.Password == passwordIngresada)
                {
                    return persona;
                }
            }

            throw new Exception("Persona no logueada");
        }
    }
}
