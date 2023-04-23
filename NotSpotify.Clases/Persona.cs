using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _eMail;
        private string _password;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _eMail; set => _eMail = value; }
        public string Password { get => _password; set => _password = value; }

        public Persona(string nombre, string apellido, string eMail, string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = eMail;
            Password = password;
        }
    }
}
