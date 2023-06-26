using NotSpotify.Clases;
using NotSpotify.Controles;
using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmHome : Form
    {
        public bool Play;
        public PlayList PlayList = new();
        readonly List<BotonPlayList> ControlList = new();

        public delegate void DelegadoLog(string message);
        public static event DelegadoLog? EventoLog;

        /// <summary>
        /// Actualiza la playList y abre el form playList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BotonPlayList_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton playList");
            UtilidadesForms.UnaPlayList = Utilidades.AdministradorPlayLists.playLists[((BotonPlayList)sender).TabIndex];
            UtilidadesForms.ManejadorFormsMenu("PlayList");
        }

        public FrmHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Genera una lista con todos los botones 'BotonPlayList'
        /// </summary>
        /// <param name="container"></param>
        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);
                if (c is BotonPlayList a) ControlList.Insert(0, a);
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            EventoLog += Logs.Log;
            GetAllControls(this);

            for (int i = 0; i < 20; i++)
            {
                ControlList[i].ActualizarLabel(Utilidades.AdministradorPlayLists.playLists[i].Nombre);
                ControlList[i].ActualizarImagen(Utilidades.AdministradorPlayLists.playLists[i].DireccionDeImagen);
            }

            Random r = new();
            int num = r.Next(1, 4);
            switch (num)
            {
                case 1:
                    pbx_banner.Image = Properties.Resources.imgBanner1;
                    break;
                case 2:
                    pbx_banner.Image = Properties.Resources.imgBanner2;
                    break;
                case 3:
                    pbx_banner.Image = Properties.Resources.imgBanner3;
                    break;
            }


        }
    }
}
