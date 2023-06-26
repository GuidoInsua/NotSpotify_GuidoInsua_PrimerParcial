using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.InterfazGrafica
{
    public class Loger
    {
        public delegate void MiEventoHandler(object sender, EventArgs e);

        public event MiEventoHandler MiEvento;

        public void ActivarEvento()
        {
            // Verifica si hay suscriptores antes de activar el evento
            if (MiEvento != null)
            {
                EventArgs args = new EventArgs();
                MiEvento(this, args);
            }
        }
    }
}
