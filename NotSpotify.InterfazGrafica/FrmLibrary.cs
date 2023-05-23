using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NotSpotify.Clases;
using NotSpotify.Utilidades;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            dgv_canciones.Rows.Clear();
            int i = 0;

            foreach (Cancion unaCancion in VerificadorDeInicio.CancionesCargadas)
            {
                dgv_canciones.Rows.Add();
                dgv_canciones.Rows[i].Cells[0].Value = unaCancion.Nombre;

                i++;
            }
        }

        private void dgv_canciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdministradorCanciones.SeleccionarCancion(UtilidadesForms.ObtenerCancionDeDataGrid(dgv_canciones));
        }
    }
}
