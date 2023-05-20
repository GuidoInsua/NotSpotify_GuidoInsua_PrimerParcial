using NotSpotify.Clases;
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

        public FrmUnaPlayList()
        {
            InitializeComponent();
        }

        private void FrmUnaPlayList_Load(object sender, EventArgs e)
        {
            label1.Text = playList.Descripccion;
        }

        public new void Show()
        {
            pictureBox1.ImageLocation = playList.DireccionDeImagen;
            label1.Text = playList.Descripccion;
            base.Show();
        }

    }
}
