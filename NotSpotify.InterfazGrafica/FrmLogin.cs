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
using NotSpotify.Metodos;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmLogin : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public int usuarioAutenticado;
        private string _eMail;
        private string _password;

        private string Email { get => _eMail; set => _eMail = value; }
        private string Password { get => _password; set => _password = value; }

        public int UsuarioAutenticado { get => usuarioAutenticado; private set => usuarioAutenticado = value; }

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
            UsuarioAutenticado = Login.VerificarDatosDeIngreso(Email, Password);

            if (UsuarioAutenticado == 1 || UsuarioAutenticado == 2)
            {
                Close();
            }
        }

        private void btn_loginAutoCompletar_Click(object sender, EventArgs e)
        {
            tbx_loginMail.Text = "guido@gmail.com";
            Email = tbx_loginMail.Text;
            tbx_loginPassword.Text = "123";
            Password = tbx_loginPassword.Text;
        }

        private void btn_loginCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbx_loginMail_Leave(object sender, EventArgs e)
        {
            Email = tbx_loginMail.Text;
        }

        private void tbx_loginPassword_Leave(object sender, EventArgs e)
        {
            Password = tbx_loginPassword.Text;
        }

        private void pnl_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnl_topBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pnl_topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }
    }
}
