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
        FrmHome homeForm = new FrmHome();
        FrmLibrary libraryForm = new FrmLibrary();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
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
            btn_menuLibrary.ApagarBotonLibrary();

            ManejadorForms("Home");
        }

        private void btn_menuLibrary_Click(object sender, EventArgs e)
        {
            btn_menuHome.ApagarBotonHome();

            ManejadorForms("Library");
        }

        private void ManejadorForms(string form)
        {
            if (form == "Home")
            {
                libraryForm.Hide();
                homeForm.TopLevel = false;
                pnl_menuFormChanger.Controls.Add(homeForm);
                homeForm.Dock = DockStyle.Fill;
                homeForm.Show();
            }

            if (form == "Library")
            {
                homeForm.Hide();
                libraryForm.TopLevel = false;
                pnl_menuFormChanger.Controls.Add(libraryForm);
                libraryForm.Dock = DockStyle.Fill;
                libraryForm.Show();
            }
        }

        private void botonMaximizar1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
