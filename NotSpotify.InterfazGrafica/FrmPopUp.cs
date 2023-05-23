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
        public string nombre = string.Empty;
        public string apellido = string.Empty;
        public string eMail = string.Empty;
        public string password = string.Empty;
        public string dni = string.Empty;
        public EnumOpcionSesion tipoPersona;
        public bool accepto = false;
        public string titulo = "Agregar";

        public FrmPopUp(EnumOpcionSesion tipo)
        {
            InitializeComponent();
            tipoPersona = tipo;
            accepto = false;
        }

        public FrmPopUp(EnumOpcionSesion tipo,string nombre, string apellido, string eMail, string password) : this(tipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.eMail = eMail;
            this.password = password;
        }

        public FrmPopUp(EnumOpcionSesion tipo, string nombre, string apellido, string eMail, string password, string dni) : this(tipo, nombre, apellido, eMail, password)
        {
            this.dni = dni;
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
            tbx_nombre.Text = nombre;
            tbx_apellido.Text = apellido;
            tbx_eMail.Text = eMail;
            tbx_password.Text = password;
            tbx_dni.Text = dni;

            lbl_titulo.Text = titulo;

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
