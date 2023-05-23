using NotSpotify.Clases;
using NotSpotify.Controles;
using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmUnaPlayList : Form
    {
        public PlayList playList = new PlayList();
        static public BotonPlay btnPlay = new BotonPlay();

        public FrmUnaPlayList()
        {
            InitializeComponent();
        }

        private void FrmUnaPlayList_Load(object sender, EventArgs e)
        {
        }

        public new void Show()
        {
            pictureBox1.ImageLocation = playList.DireccionDeImagen;
            label3.Text = playList.Nombre;
            label2.Text = playList.Descripccion;

            dgv_canciones.Rows.Clear();
            int i = 0;

            foreach (Cancion unaCancion in playList.Canciones)
            {
                dgv_canciones.Rows.Add();
                dgv_canciones.Rows[i].Cells[0].Value = unaCancion.Nombre;

                i++;
            }

            base.Show();
        }

        /// <summary>
        /// Selecciona una cancion de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_canciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdministradorCanciones.SeleccionarCancion(UtilidadesForms.ObtenerCancionDeDataGrid(dgv_canciones), playList.Canciones);
        }

        /// <summary>
        /// reproduce una cancion random de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_playListRandom_Click(object sender, EventArgs e)
        {
            UtilidadesForms.TocarCancionRandom(playList.Canciones);
            btnPlay.CambiarEstadoBoton(FrmMenu.play);

        }
    }
}
