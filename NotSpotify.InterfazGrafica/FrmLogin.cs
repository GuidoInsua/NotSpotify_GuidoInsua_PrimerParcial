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
        public EnumOpcionSesion estadoUsuarioAutenticado;
        private string _eMail;
        private string _password;

        private string Email { get => _eMail; set => _eMail = value; }
        private string Password { get => _password; set => _password = value; }

        public EnumOpcionSesion EstadoUsuarioAutenticado { get => estadoUsuarioAutenticado; private set => estadoUsuarioAutenticado = value; }

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
            EstadoUsuarioAutenticado = VerificadorDeInicio.VerificarExistePersona(Email, Password);

            if (EstadoUsuarioAutenticado == EnumOpcionSesion.esAdmin || EstadoUsuarioAutenticado == EnumOpcionSesion.esUsuario)
            {
                Close();
            }
            else
            {
                lbl_mensajeError.Text = "ERROR, Ingrese un Usuario valido";
            }
        }

        private void btn_completarUsuario_Click(object sender, EventArgs e)
        {
            VerificadorDeInicio.AutoCompletarUsuario(out _eMail, out _password);
            tbx_loginMail.Text = Email;
            tbx_loginPassword.Text = Password;
        }

        private void btn_completarAdmin_Click(object sender, EventArgs e)
        {
            VerificadorDeInicio.AutoCompletarAdmin(out _eMail, out _password);
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
