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

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuariosForm = new FrmUsuarios();
            usuariosForm.TopLevel = false;
            pnl_adminFormChanger.Controls.Add(usuariosForm);
            usuariosForm.Show();
        }

        private void btn_canciones_Click(object sender, EventArgs e)
        {
            FrmCanciones cancionesForm = new FrmCanciones();
            cancionesForm.TopLevel = false;
            pnl_adminFormChanger.Controls.Add(cancionesForm);
            cancionesForm.Show();
        }
    }
}
