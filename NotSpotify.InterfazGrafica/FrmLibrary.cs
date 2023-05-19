using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmLibrary : Form
    {
        public string tema = "Sumo.wav";

        public FrmLibrary()
        {
            InitializeComponent();
        }

        private void btn_tema1_Click(object sender, EventArgs e)
        {
            tema = "Sumo.wav";
        }

        private void btn_tema2_Click(object sender, EventArgs e)
        {
            tema = "1.wav";
        }

        private void btn_tema3_Click(object sender, EventArgs e)
        {
            tema = "2.wav";
        }

        private void btn_tema4_Click(object sender, EventArgs e)
        {
            tema = "3.wav";
        }
    }
}
