using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases
{
    public class Usuario : Persona
    {
        private List<PlayList> _playLists;

        public List<PlayList> PlayLists { get => _playLists; set => _playLists = value; }

        public Usuario(string nombre, string apellido, string eMail, string password) : base(nombre, apellido, eMail, password)
        {
            _playLists = new List<PlayList>();
        }
    }
}
