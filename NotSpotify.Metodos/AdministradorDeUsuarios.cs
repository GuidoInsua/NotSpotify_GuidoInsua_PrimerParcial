using NotSpotify.Clases;
using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Metodos
{
    static public class AdministradorDeUsuarios
    {

        static public List<T> CargarDatosDesdeArchivo<T>(string path) where T : ICargable, new()
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
    }
}
