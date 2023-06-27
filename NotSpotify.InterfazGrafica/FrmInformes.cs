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

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmInformes : Form
    {
        public delegate void DelegadoLog(string message);
        public static event DelegadoLog? EventoLog;

        public FrmInformes()
        {
            InitializeComponent();
        }

        private void btn_usuariosCsv_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton usuariosCsv");
            AdministradorDatos.GuardarListaEnCsv(VerificadorDeInicio.PersonasCargadas, "Usuarios.csv");
            pbx_tickUsuarioCsv.Visible = true;
        }

        private void btn_playListsCsv_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton playListCsv");
            AdministradorDatos.GuardarListaEnCsv(AdministradorPlayLists.playLists, "PlayLists.csv");
            pbx_tickPlayListCsv.Visible = true;
        }

        private void btn_cancionesCsv_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton cancionesCsv");
            AdministradorDatos.GuardarListaEnCsv(AdministradorCanciones.CancionesCargadas, "Canciones.csv");
            pbx_tickCancionesCsv.Visible = true;
        }

        private void btn_usuariosJson_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton usuariosJson");
            AdministradorDatos.GuardarListaEnJson(VerificadorDeInicio.PersonasCargadas, "Usuarios.json");
            pbx_tickUsuarioJson.Visible = true;
        }

        private void btn_PlayListsJson_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton PlayListJson");
            AdministradorDatos.GuardarListaEnJson(AdministradorPlayLists.playLists, "PlayLists.json");
            pbx_tickPlayListJson.Visible = true;
        }

        private void btn_cancionesJson_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton cancionesJson");
            AdministradorDatos.GuardarListaEnJson(AdministradorCanciones.CancionesCargadas, "Canciones.json");
            pbx_tickCancionesJson.Visible = true;
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            EventoLog += Logs.Log;

            pbx_tickUsuarioCsv.Visible = false;
            pbx_tickPlayListCsv.Visible = false;
            pbx_tickCancionesCsv.Visible = false;
            pbx_tickUsuarioJson.Visible = false;
            pbx_tickPlayListJson.Visible = false;
            pbx_tickCancionesJson.Visible = false;
        }
    }
}
