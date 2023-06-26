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
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmInformacion : Form
    {
        public delegate void DelegadoLog(string message);
        public static event DelegadoLog? EventoLog;

        public bool accepto = false;
        public string titulo = "Agregar";
        public string dni = string.Empty;
        public modoForm tipo;
        public string nombre = string.Empty;
        public string eMail = string.Empty;

        public enum modoForm
        {
            degradarAdministrador = 0,
            ascenderUsuario = 1,
            borrarAdministrador = 2,
            borrarUsuario = 3,
        }

        public FrmInformacion(modoForm modo, string nombre, string eMail)
        {
            InitializeComponent();
            tipo = modo;
            accepto = false;
            this.nombre = nombre;
            this.eMail = eMail;
        }


        private void btn_acceptar_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton acceptar");
            dni = tbx_dni.Text;
            accepto = true;
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton cancelar");
            accepto = false;
            Close();
        }

        private void pnl_movimiento_Load(object sender, EventArgs e)
        {
            pnl_movimiento.EstablecerPadre(this);
        }

        private void FrmInformacion_Load(object sender, EventArgs e)
        {
            EventoLog += Logs.Log;

            switch (tipo)
            {
                case modoForm.ascenderUsuario:
                    lbl_dni.Visible = true;
                    tbx_dni.Visible = true;

                    lbl_titulo.Text = "Ascender";
                    lbl_texto.Text = $"Esta seguro de que desea ascender al usuario: \n-{nombre} \n-{eMail}";
                    break;

                case modoForm.degradarAdministrador:
                    lbl_dni.Visible = false;
                    tbx_dni.Visible = false;

                    lbl_titulo.Text = "Degradar";
                    lbl_texto.Text = $"Esta seguro de que desea degradar al administrador: \n-{nombre} \n-{eMail}";
                    break;

                case modoForm.borrarUsuario:
                    lbl_dni.Visible = false;
                    tbx_dni.Visible = false;

                    lbl_titulo.Text = "Eliminar";
                    lbl_texto.Text = $"Esta seguro de que desea eliminar al usuario: \n-{nombre} \n-{eMail}";
                    break;

                case modoForm.borrarAdministrador:
                    lbl_dni.Visible = false;
                    tbx_dni.Visible = false;

                    lbl_titulo.Text = "Eliminar";
                    lbl_texto.Text = $"Esta seguro de que desea eliminar al administrador: \n-{nombre} \n-{eMail}";
                    break;

            }
        }
    }
}
