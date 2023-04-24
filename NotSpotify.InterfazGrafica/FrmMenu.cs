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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_menuLibarary_Click(object sender, EventArgs e)
        {
            btn_menuHome.ApagarBotonHome();

            FrmLibrary libraryForm = new FrmLibrary();
            libraryForm.TopLevel = false;
            pnl_menuFormChanger.Controls.Add(libraryForm);
            libraryForm.Show();
        }

        private void panelMovimiento2_Load(object sender, EventArgs e)
        {
            panelMovimiento2.EstablecerPadre(this);
        }

        private void botonCerrar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_menuHome_Click(object sender, EventArgs e)
        {
            FrmHome homeForm = new FrmHome();
            homeForm.TopLevel = false;
            pnl_menuFormChanger.Controls.Add(homeForm);
            homeForm.Show();
        }
    }
}
