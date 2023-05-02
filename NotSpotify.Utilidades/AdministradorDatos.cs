using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NotSpotify.Clases;
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
                unCargable = new T();
                unCargable.CargarDatosDesdeLinea(linea, separador);

                listaDeCargabe.Add(unCargable);
            }

            sr.Close();
            sr.Dispose();

            return listaDeCargabe;
        }

        static public void AgregarUsuarioEnLista(string nombre, string apellido, string eMail, string password)
        {
            Usuario unUsuario = new Usuario(nombre,apellido,eMail,password);

            VerificadorDeInicio.UsuariosCargados.Add(unUsuario);
        }

        static public bool CompararDatos<T>(string eMailIngresado, string passwordIngresada, List<T> personas) where T : Persona
        {
            foreach (T persona in personas)
            {
                if (persona.Email == eMailIngresado && persona.Password == passwordIngresada)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
