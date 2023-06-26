using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Usuario : Persona
    {
        private List<PlayList> _playLists;

        public List<PlayList> PlayLists { get => _playLists; set => _playLists = value; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellido, string eMail, string password) : base(nombre, apellido, eMail, password)
        {
            _playLists = new List<PlayList>();
        }

        /// <summary>
        /// Completa los campos del usuario con los valores del array
        /// </summary>
        /// <param name="fila"></param>
        public override void CargarDatosDesdeArray(string[] fila)
        {
            Nombre = fila[0];
            Apellido = fila[1];
            Email = fila[2];
            Password = fila[3];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GuardarDatosEnSql()
        {
            return "INSERT INTO Personas (Nombre, Apellido, Email, Password, Dni, Tipo) " +
                    $"VALUES ('{Nombre}', '{Apellido}', '{Email}', '{Password}', '', 'Usuario')";
        }

        /// <summary>
        /// Retorna una linea string lista para cargar en CSV 
        /// </summary>
        /// <returns></returns>
        public override string GuardarEnCsv()
        {
            return $"{Nombre},{Apellido},{Email},{Password},Usuario";
        }

        public static bool operator ==(Usuario U1, Usuario U2)
        {
            return (U1.Email == U2.Email);
        }

        public static bool operator !=(Usuario U1, Usuario U2)
        {
            return !(U1 == U2);
        }
    }
}
