using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSpotify.Controles
{
    public partial class BotonHome : UserControl
    {
        public BotonHome()
        {
            InitializeComponent();
        }

        new public event EventHandler MyClick
        {
            add { btn_home.Click += value; }
            remove { btn_home.Click -= value; }
        }

        private void BotonHome_Click(object sender, EventArgs e)
        {
            if (btn_home.ImageIndex == 0 || btn_home.ImageIndex == 1)
            {
                btn_home.ImageIndex = 2;
                btn_home.ForeColor = Color.White;
            }
        }

        private void btn_home_MouseEnter(object sender, EventArgs e)
        {
            if (btn_home.ImageIndex == 0)
            {
                btn_home.ImageIndex = 1;
                btn_home.ForeColor = Color.White;
            }
        }

        private void btn_home_MouseLeave(object sender, EventArgs e)
        {
            if (btn_home.ImageIndex == 1)
            {
                btn_home.ImageIndex = 0;
                btn_home.ForeColor = Color.Silver;
            }
        }

        public void ApagarBotonHome()
        {
            if (btn_home.ImageIndex == 1 || btn_home.ImageIndex == 2)
            {
                btn_home.ImageIndex = 0;
                btn_home.ForeColor = Color.Silver;
            }
        }
    }
}
