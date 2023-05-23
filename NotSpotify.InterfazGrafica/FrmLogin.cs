using NotSpotify.Clases;
using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmLogin : Form
    {
        private EnumOpcionSesion _tipoDeUsuarioAutenticado;
        private string _eMail = string.Empty;
        private string _password = string.Empty;

        private string Email { get => _eMail; set => _eMail = value; }
        private string Password { get => _password; set => _password = value; }
        public EnumOpcionSesion TipoDeUsuarioAutenticado { get => _tipoDeUsuarioAutenticado; private set => _tipoDeUsuarioAutenticado = value; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Email = "ejemplo@correo.com";
            Password = "0";
        }

        private void btn_loginAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoDeUsuarioAutenticado = VerificadorDeInicio.VerificarTipoDePersona(Email, Password);
                Close();
            }
            catch 
            {
                lbl_mensajeError.Text = "ERROR, Ingrese un Usuario valido";
            }
        }

        private void btn_completarUsuario_Click(object sender, EventArgs e)
        {
            VerificadorDeInicio.AutoCompletarLogin<Usuario>(ref _eMail, ref _password);
            tbx_loginMail.Text = Email;
            tbx_loginPassword.Text = Password;
        }

        private void btn_completarAdmin_Click(object sender, EventArgs e)
        {
            VerificadorDeInicio.AutoCompletarLogin<Administrador>(ref _eMail, ref _password);
            tbx_loginMail.Text = Email;
            tbx_loginPassword.Text = Password;
        }

        private void tbx_loginMail_Leave(object sender, EventArgs e)
        {
            Email = tbx_loginMail.Text;
        }

        private void tbx_loginPassword_Leave(object sender, EventArgs e)
        {
            Password = tbx_loginPassword.Text;
        }

        private void pnl_topBar_Load(object sender, EventArgs e)
        {
            pnl_topBar.EstablecerPadre(this);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
