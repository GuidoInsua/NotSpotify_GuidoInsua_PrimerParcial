using NotSpotify.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Usuario : Persona, ICargable
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

        public void CargarDatosDesdeLinea(string linea, string separador)
        {
            string[] fila = linea.Split(separador);
            Nombre = fila[0];
            Apellido = fila[1];
            Email = fila[2];
            Password = fila[3];
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
