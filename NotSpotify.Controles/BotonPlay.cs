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
    public partial class BotonPlay : UserControl
    {
        public BotonPlay()
        {
            InitializeComponent();
        }

        new public event EventHandler Click
        {
            add { btn_paly.Click += value; }
            remove { btn_paly.Click -= value; }
        }

        public void CambiarEstadoBoton(bool estado)
        {
            if (estado)
            {
                btn_paly.ImageIndex = 1;
            }
            else
            {
                btn_paly.ImageIndex = 0;
            }
        }
    }
}
