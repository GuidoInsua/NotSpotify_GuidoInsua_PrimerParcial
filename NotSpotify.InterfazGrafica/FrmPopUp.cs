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
    public partial class FrmPopUp : Form
    {
        public string nombre;
        public string apellido;
        public string eMail;
        public string password;
        public string dni;
        public EnumOpcionSesion tipoPersona;
        public bool accepto;

        public FrmPopUp(EnumOpcionSesion tipo)
        {
            InitializeComponent();
            tipoPersona = tipo;
            nombre = string.Empty;
            apellido = string.Empty;
            eMail = string.Empty;
            password = string.Empty;
            dni = string.Empty;
            accepto = false;
        }

        private void btn_acceptar_Click(object sender, EventArgs e)
        {
            nombre = tbx_nombre.Text;
            apellido = tbx_apellido.Text;
            eMail = tbx_eMail.Text;
            password = tbx_password.Text;
            dni = tbx_dni.Text;
            accepto = true;
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            accepto = false;
            Close();
        }

        private void pnl_movimiento_Load(object sender, EventArgs e)
        {
            pnl_movimiento.EstablecerPadre(this);
        }

        private void FrmPopUp_Load(object sender, EventArgs e)
        {
            if (tipoPersona == EnumOpcionSesion.esAdmin)
            {
                lbl_dni.Visible = true;
                tbx_dni.Visible = true;
            }
            else
            {
                lbl_dni.Visible = false;
                tbx_dni.Visible = false;
            }
        }
    }
}
