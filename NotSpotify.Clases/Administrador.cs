using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Administrador : Persona, ICargable
    {
        private string _dni;

        public string Dni { get => _dni; set => _dni = value; }

        public Administrador() 
        {
        }

        public Administrador(string nombre, string apellido, string eMail, string password, string dni) : base(nombre, apellido, eMail, password)
        {
            Dni = dni;
        }

        /// <summary>
        /// Completa los campos del administrador con los valores del array
        /// </summary>
        /// <param name="fila"></param>
        public void CargarDatosDesdeArray(string[] fila)
        {
            Nombre = fila[0];
            Apellido = fila[1];
            Email = fila[2];
            Password = fila[3];
            Dni = fila[4];
        }

        /// <summary>
        /// Retorna una linea string lista para cargar en CSV 
        /// </summary>
        /// <returns></returns>
        public override string GuardarDatosEnLinea()
        {
            return $"{Nombre},{Apellido},{Email},{Password},{Dni},Administrador";
        }

        public static bool operator ==(Administrador A1, Administrador A2)
        {
            return (A1.Email == A2.Email || A1.Dni == A2.Dni);
        }

        public static bool operator !=(Administrador A1, Administrador A2)
        {
            return !(A1 == A2);
        }
    }
}
