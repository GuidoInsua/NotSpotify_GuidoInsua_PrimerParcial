using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases.Interfaces
{
    public interface ICargable
    {
        public void CargarDatosDesdeLinea(string linea, string separador);
    }
}
