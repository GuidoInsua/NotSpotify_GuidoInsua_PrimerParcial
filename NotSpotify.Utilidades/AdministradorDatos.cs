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
        static public List<T> CargarListaDesdeArchivo<T>(string path) where T : ICargable, new()
        {
            string separador = ",";
            string linea;
            StreamReader sr = File.OpenText(path);
            List<T> listaDeCargabe = new List<T>();
            T unCargable;

            sr.ReadLine();

            while ((linea = sr.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);

                unCargable = new T();
                unCargable.CargarDatosDesdeArray(fila);

                listaDeCargabe.Add(unCargable);
            }

            sr.Close();
            sr.Dispose();

            return listaDeCargabe;
        }

        static public void CargarListaPersonasDesdeArchivo(string path)
        {            
            using StreamReader sr = File.OpenText(path);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                PersonaFactory.CargarPersonaPorLastOrDefault(linea, ",");
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
