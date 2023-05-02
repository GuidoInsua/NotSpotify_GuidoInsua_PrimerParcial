using Microsoft.VisualBasic;
using NotSpotify.Clases;
using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotSpotify.Utilidades.AdministradorABM;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmEditarUsuario : Form
    {
        public string nombre;
        public string apellido;
        public string eMail;
        public string password;

        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        private void btn_acceptar_Click(object sender, EventArgs e)
        {
            nombre = tbx_nombre.Text;
            apellido = tbx_apellido.Text;
            eMail = tbx_eMail.Text;
            password = tbx_password.Text;

            if (VerificadorDeInicio.VerificarExistePersona(eMail, password) == EnumOpcionSesion.noExiste 
                && AdministradorABM.VerificarDatosPersona(nombre, apellido, eMail, password))
            {
                DialogResult dg = MessageBox.Show("Esta seguro que desea cargar el usuario?", "",MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    AdministradorABM.CargarUsuario(nombre, apellido, eMail, password); 
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Datos no validos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
