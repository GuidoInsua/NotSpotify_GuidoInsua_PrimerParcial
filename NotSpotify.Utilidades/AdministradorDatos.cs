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
