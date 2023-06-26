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
    public partial class BotonMaximizar : UserControl
    {
        public BotonMaximizar()
        {
            InitializeComponent();
        }

        new public event EventHandler MyClick
        {
            add { btn_maximizar.Click += value; }
            remove { btn_maximizar.Click -= value; }
        }

        private void BotonMaximizar_Click(object sender, EventArgs e)
        {
            if (btn_maximizar.ImageIndex == 0)
            {
                btn_maximizar.ImageIndex = 1;
            }
            else
            {
                btn_maximizar.ImageIndex = 0;
            }
        }
    }
}
