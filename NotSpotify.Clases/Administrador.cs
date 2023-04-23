using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Administrador : Persona
    {
        private string _dni;

        public string Dni { get => _dni; set => _dni = value; }

        public Administrador(string nombre, string apellido, string eMail, string password, string dni) : base(nombre, apellido, eMail, password)
        {
            Dni = dni;
        }
    }
}
