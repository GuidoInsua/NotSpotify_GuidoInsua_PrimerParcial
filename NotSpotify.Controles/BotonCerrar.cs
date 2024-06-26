﻿using System;
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
    public partial class BotonCerrar : UserControl
    {
        public BotonCerrar()
        {
            InitializeComponent();
        }

        new public event EventHandler MyClick
        {
            add { pbx_imagen.Click += value; }
            remove { pbx_imagen.Click -= value; }
        }

        private void pbx_imagen_MouseEnter(object sender, EventArgs e)
        {
            pbx_imagen.BackColor = Color.Red;
        }

        private void pbx_imagen_MouseLeave(object sender, EventArgs e)
        {
            pbx_imagen.BackColor = Color.Transparent;
        }
    }
}
