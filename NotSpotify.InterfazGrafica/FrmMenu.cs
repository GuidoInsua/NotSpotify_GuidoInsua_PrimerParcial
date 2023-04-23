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
            if (btn_menuHome.ImageIndex == 1)
            {
                btn_menuHome.ImageIndex = 0;
                btn_menuHome.ForeColor = Color.Silver;
            }

            FrmLibrary libraryForm = new FrmLibrary();
            libraryForm.TopLevel = false;
            pnl_menuFormChanger.Controls.Add(libraryForm);
            libraryForm.Show();
        }

        private void btn_menuHome_Click(object sender, EventArgs e)
        {
            if (btn_menuHome.ImageIndex == 0)
            {
                btn_menuHome.ImageIndex = 1;
                btn_menuHome.ForeColor = Color.White;
            }

            FrmHome homeForm = new FrmHome();
            homeForm.TopLevel = false;
            pnl_menuFormChanger.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void btn_menuHome_MouseEnter(object sender, EventArgs e)
        {
            if (btn_menuHome.ImageIndex == 0)
            {
                btn_menuHome.ForeColor = Color.White;
            }
        }

        private void btn_menuHome_MouseLeave(object sender, EventArgs e)
        {
            if (btn_menuHome.ImageIndex == 0)
            {
                btn_menuHome.ForeColor = Color.Silver;
            }
        }
    }
}
