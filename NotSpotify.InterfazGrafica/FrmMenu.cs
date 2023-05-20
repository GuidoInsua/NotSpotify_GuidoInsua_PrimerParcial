using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmMenu : Form
    {
        private EnumOpcionSesion _tipoDeUsuarioAutenticado;
        public bool reproduciendo = false;
        SoundPlayer musicPlayer = new SoundPlayer();

        public FrmMenu(EnumOpcionSesion tipoUsuario)
        {
            InitializeComponent();
            _tipoDeUsuarioAutenticado = tipoUsuario;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (_tipoDeUsuarioAutenticado == EnumOpcionSesion.esAdmin)
            {
                btn_admin.Visible = true;
            }

            UtilidadesForms.panel = pnl_menuFormChanger;

            UtilidadesForms.ManejadorFormsMenu("Home");
        }

        private void panelMovimiento2_Load(object sender, EventArgs e)
        {
            panelMovimiento2.EstablecerPadre(this);
        }

        private void botonCerrar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_menuHome_Click(object sender, EventArgs e)
        {
            btn_menuLibrary.ApagarBotonLibrary();

            UtilidadesForms.ManejadorFormsMenu("Home");
        }

        private void btn_menuLibrary_Click(object sender, EventArgs e)
        {
            btn_menuHome.ApagarBotonHome();

            UtilidadesForms.ManejadorFormsMenu("Library");
        }

        private void ManejadorForms(string form)
        {
            //switch (form)
            //{
            //    case "Home":
            //        libraryForm.Hide();
            //        homeForm.TopLevel = false;
            //        pnl_menuFormChanger.Controls.Add(homeForm);
            //        homeForm.Dock = DockStyle.Fill;
            //        homeForm.Show();
            //        break;
            //    case "Library":
            //        homeForm.Hide();
            //        libraryForm.TopLevel = false;
            //        pnl_menuFormChanger.Controls.Add(libraryForm);
            //        libraryForm.Dock = DockStyle.Fill;
            //        libraryForm.Show();
            //        break;
            //}
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

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FrmEditorDatos frmEditorDatos = new FrmEditorDatos();
            frmEditorDatos.ShowDialog();
        }

        private void botonMinimizar1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (reproduciendo == false || musicPlayer.SoundLocation != libraryForm.tema)
            //{
            //    musicPlayer.SoundLocation = libraryForm.tema;
            //    musicPlayer.Play();
            //    reproduciendo = true;
            //}
            //else
            //{
            //    musicPlayer.Stop();
            //    reproduciendo = false;
            //}
        }
    }
}
