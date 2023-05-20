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
    public partial class FrmHome : Form
    {
        public bool Play;
        public PlayList PlayList = new PlayList();

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            btn_playList1.ActualizarLabel(Utilidades.AdministradorPlayLists.playLists[1].Nombre);
            btn_playList1.ActualizarImagen(Utilidades.AdministradorPlayLists.playLists[1].DireccionDeImagen);
            btn_playList2.ActualizarLabel("Sumo");
            btn_playList3.ActualizarLabel("Sumo");
            btn_playList4.ActualizarLabel("Sumo");
            btn_playList5.ActualizarLabel("Sumo");
            btn_playList6.ActualizarLabel("Sumo");
        }

        private void btn_playList1_Click(object sender, EventArgs e)
        {
            UtilidadesForms.unaPlayList = Utilidades.AdministradorPlayLists.playLists[1];
            UtilidadesForms.ManejadorFormsMenu("PlayList");
        }
    }
}
