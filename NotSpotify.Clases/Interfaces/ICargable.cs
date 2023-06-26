using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Clases.Interfaces
{
    public interface ICargable
    {
        public void CargarDatosDesdeArray(string[] fila);

        public string GuardarDatosEnSql();

        public string GuardarEnCsv();
    }
}
