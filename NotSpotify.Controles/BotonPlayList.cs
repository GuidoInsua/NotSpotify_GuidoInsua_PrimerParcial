using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Web;
using System.Net;

namespace NotSpotify.Controles
{
    public partial class BotonPlayList : UserControl
    {
        public string titulo = string.Empty;
        public string imagen = string.Empty;

        public EventHandler onClick;

        public BotonPlayList()
        {
            InitializeComponent();
        }

        new public event EventHandler Click
        {
            add { onClick += value; }
            remove { onClick -= value; }
        }

        private void BotonPlayList_Load(object sender, EventArgs e)
        {

            Rectangle r = new(0, 0, pbx_imagen.Width, pbx_imagen.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new();
            int d = 14;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pbx_imagen.Region = new(gp);

            Rectangle r2 = new(0, 0, pnl_backGround.Width, pnl_backGround.Height);
            System.Drawing.Drawing2D.GraphicsPath gp2 = new();
            int d2 = 20;
            gp2.AddArc(r2.X, r2.Y, d2, d2, 180, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y, d2, d2, 270, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y + r2.Height - d2, d2, d2, 0, 90);
            gp2.AddArc(r2.X, r2.Y + r2.Height - d2, d2, d2, 90, 90);
            pnl_backGround.Region = new(gp2);

            Rectangle r3 = new(0, 0, pbx_play.Width, pbx_play.Height);
            System.Drawing.Drawing2D.GraphicsPath gp3 = new();
            int d3 = 35;
            gp3.AddArc(r3.X, r3.Y, d3, d3, 180, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y, d3, d3, 270, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y + r3.Height - d3, d3, d3, 0, 90);
            gp3.AddArc(r3.X, r3.Y + r3.Height - d3, d3, d3, 90, 90);
            pbx_play.Region = new(gp3);

            lbl_titulo.Text = titulo;
            pbx_imagen.Image = Properties.Resources.A_983844_1642669708_2067;
        }

        public void ActualizarLabel(string texto)
        {
            lbl_titulo.Text = texto;
        }

        public void ActualizarImagen(string direccion)
        {
            pbx_imagen.ImageLocation = direccion;
        }

        private void pnl_backGround_MouseEnter(object sender, EventArgs e)
        {
            pnl_backGround.BackColor = Color.FromArgb(50, 50, 50);
            pbx_play.Visible = true;
        }

        private void pbx_imagen_MouseEnter(object sender, EventArgs e)
        {
            pnl_backGround.BackColor = Color.FromArgb(50, 50, 50);
            pbx_play.Visible = true;
        }

        private void pnl_backGround_MouseLeave(object sender, EventArgs e)
        {
            pnl_backGround.BackColor = Color.FromArgb(35, 35, 35);
            pbx_play.Visible = false;
        }

        private void pnl_backGround_Click(object sender, EventArgs e)
        {
            if (onClick != null)
            {
                onClick.Invoke(this, EventArgs.Empty);
                pnl_backGround.BackColor = Color.FromArgb(35, 35, 35);
                pbx_play.Visible = false;
            }
        }
    }
}
