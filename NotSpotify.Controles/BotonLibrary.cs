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
    public partial class BotonLibrary : UserControl
    {
        public BotonLibrary()
        {
            InitializeComponent();
        }

        new public event EventHandler Click
        {
            add { btn_library.Click += value; }
            remove { btn_library.Click -= value; }
        }

        private void BotonLibrary_Click(object sender, EventArgs e)
        {
            if (btn_library.ImageIndex == 0 || btn_library.ImageIndex == 1)
            {
                btn_library.ImageIndex = 2;
                btn_library.ForeColor = Color.White;
            }
        }

        private void btn_library_MouseEnter(object sender, EventArgs e)
        {
            if (btn_library.ImageIndex == 0)
            {
                btn_library.ImageIndex = 1;
                btn_library.ForeColor = Color.White;
            }
        }

        private void btn_library_MouseLeave(object sender, EventArgs e)
        {
            if (btn_library.ImageIndex == 1)
            {
                btn_library.ImageIndex = 0;
                btn_library.ForeColor = Color.Silver;
            }
        }

        public void ApagarBotonLibrary()
        {
            if (btn_library.ImageIndex == 1 || btn_library.ImageIndex == 2)
            {
                btn_library.ImageIndex = 0;
                btn_library.ForeColor = Color.Silver;
            }
        }
    }
}
