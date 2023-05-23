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

        /// <summary>
        /// Llama al manejador de forms para abrir el form usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            ManejadorForms("Usuarios");
        }

        /// <summary>
        /// llama al manejador de forms para abrir el form admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_admins_Click(object sender, EventArgs e)
        {
            ManejadorForms("Admins");
        }

        /// <summary>
        /// llama al manejador de forms para abril el form canciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_canciones_Click(object sender, EventArgs e)
        {
            ManejadorForms("Canciones");
        }

        /// <summary>
        /// dependiendo del nombre del form, esconde los otros y abre al que se llama
        /// </summary>
        /// <param name="form"></param>
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

        /// <summary>
        /// maximiza o pone en modo ventana al form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// minimiza el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
