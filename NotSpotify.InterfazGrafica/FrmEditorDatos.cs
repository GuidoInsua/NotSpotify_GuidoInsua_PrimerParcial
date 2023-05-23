using NotSpotify.Clases;
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
    public partial class FrmEditorDatos : Form
    {
        readonly FrmUsuarios usuariosForm = new();
        readonly FrmAdministradores administradoresForm = new();
        readonly FrmCanciones cancionesForm = new();

        public FrmEditorDatos()
        {
            InitializeComponent();
        }

        private void FrmEditorDatos_Load(object sender, EventArgs e)
        {
            ManejadorForms("Usuarios");
        }

        private void pnl_movimientoTopBar_Load(object sender, EventArgs e)
        {
            pnl_movimientoTopBar.EstablecerPadre(this);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            ManejadorForms("Usuarios");
        }

        private void btn_admins_Click(object sender, EventArgs e)
        {
            ManejadorForms("Admins");
        }

        private void btn_canciones_Click(object sender, EventArgs e)
        {
            ManejadorForms("Canciones");
        }

        private void ManejadorForms(string form)
        {
            switch (form)
            {
                case "Usuarios":
                    administradoresForm.Hide();
                    cancionesForm.Hide();
                    usuariosForm.TopLevel = false;
                    pnl_FrmChanger.Controls.Add(usuariosForm);
                    usuariosForm.Dock = DockStyle.Fill;
                    usuariosForm.Show();
                    break;
                case "Admins":
                    usuariosForm.Hide();
                    cancionesForm.Hide();
                    administradoresForm.TopLevel = false;
                    pnl_FrmChanger.Controls.Add(administradoresForm);
                    administradoresForm.Dock = DockStyle.Fill;
                    administradoresForm.Show();
                    break;
                case "Canciones":
                    usuariosForm.Hide();
                    administradoresForm.Hide();
                    cancionesForm.TopLevel = false;
                    pnl_FrmChanger.Controls.Add(cancionesForm);
                    cancionesForm.Dock = DockStyle.Fill;
                    cancionesForm.Show();
                    break;
            }
        }

        private void btn_maximizar_Click_1(object sender, EventArgs e)
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

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
