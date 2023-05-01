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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void botonCerrar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnl_movimientoTopBar_Load(object sender, EventArgs e)
        {
            pnl_movimientoTopBar.EstablecerPadre(this);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuariosForm = new FrmUsuarios();
            usuariosForm.TopLevel = false;
            panel1.Controls.Add(usuariosForm);
            usuariosForm.Dock = DockStyle.Fill;
            usuariosForm.Show();
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
