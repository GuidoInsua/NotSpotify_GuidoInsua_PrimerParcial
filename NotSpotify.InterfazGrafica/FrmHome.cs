using NotSpotify.Clases;
using NotSpotify.Controles;
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

        private void BotonPlayList_Click(object sender, EventArgs e)
        {
            UtilidadesForms.UnaPlayList = Utilidades.AdministradorPlayLists.playLists[((BotonPlayList)sender).TabIndex];
            UtilidadesForms.ManejadorFormsMenu("PlayList");
        }

        public FrmHome()
        {
            InitializeComponent();
        }

        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);
                if (c is BotonPlayList a) ControlList.Insert(0,a);
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            GetAllControls(this);

            for (int i = 0; i < 20; i++)
            {
                ControlList[i].Click += BotonPlayList_Click;
                ControlList[i].ActualizarLabel(Utilidades.AdministradorPlayLists.playLists[i].Nombre);
                ControlList[i].ActualizarImagen(Utilidades.AdministradorPlayLists.playLists[i].DireccionDeImagen);
            }
        }
    }
}
