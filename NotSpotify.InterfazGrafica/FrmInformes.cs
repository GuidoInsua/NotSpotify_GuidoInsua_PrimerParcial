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
        }

        private void btn_playListsCsv_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton playListCsv");
            AdministradorDatos.GuardarListaEnCsv(AdministradorPlayLists.playLists, "PlayLists.csv");
        }

        private void btn_cancionesCsv_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton cancionesCsv");
            AdministradorDatos.GuardarListaEnCsv(AdministradorCanciones.CancionesCargadas, "Canciones.csv");
        }

        private void btn_usuariosJson_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton usuariosJson");
            AdministradorDatos.GuardarListaEnJson(VerificadorDeInicio.PersonasCargadas, "Usuarios.json");
        }

        private void btn_PlayListsJson_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton PlayListJson");
            AdministradorDatos.GuardarListaEnJson(AdministradorPlayLists.playLists, "PlayLists.json");
        }

        private void btn_cancionesJson_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton cancionesJson");
            AdministradorDatos.GuardarListaEnJson(AdministradorCanciones.CancionesCargadas, "Canciones.json");
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            EventoLog += Logs.Log;
        }
    }
}
