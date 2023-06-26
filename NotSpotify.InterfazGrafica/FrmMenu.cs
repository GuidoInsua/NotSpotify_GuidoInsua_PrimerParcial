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
using NAudio;
using NAudio.Wave;
using NotSpotify.Utilidades;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmMenu : Form
    {
        public delegate void DelegadoLog(string message);
        public static event DelegadoLog? EventoLog;

        private readonly EnumOpcionSesion _tipoDeUsuarioAutenticado;
        public bool reproduciendo = false;
        static public string estadoDescarga = string.Empty;

        static public IWavePlayer waveOutDevice = new WaveOut();
        static public AudioFileReader audioFileReader = new(AdministradorCanciones.tema);
        static public bool play = false;


        public FrmMenu(EnumOpcionSesion tipoUsuario)
        {
            InitializeComponent();
            _tipoDeUsuarioAutenticado = tipoUsuario;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            EventoLog += Logs.Log;

            if (_tipoDeUsuarioAutenticado == EnumOpcionSesion.esAdmin)
            {
                btn_admin.Visible = true;
            }

            UtilidadesForms.PanelChanger = pnl_menuFormChanger;

            UtilidadesForms.ManejadorFormsMenu("Home");

            FrmUnaPlayList.btnPlay = btn_play;
        }

        private void panelMovimiento2_Load(object sender, EventArgs e)
        {
            panelMovimiento2.EstablecerPadre(this);
        }

        /// <summary>
        /// Cierra el programa y termina los threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonCerrar1_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton cerrar");

            waveOutDevice.Dispose();
            Environment.Exit(Environment.ExitCode);

            Logs.Log("Cerrar");

            Close();
        }

        /// <summary>
        /// llama al manejador de forms y abre el form home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_menuHome_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton home");

            btn_menuLibrary.ApagarBotonLibrary();

            UtilidadesForms.ManejadorFormsMenu("Home");
        }

        /// <summary>
        /// llama al manejador de forms y abre el form Library
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_menuLibrary_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton library");

            btn_menuHome.ApagarBotonHome();

            UtilidadesForms.ManejadorFormsMenu("Library");
        }

        /// <summary>
        /// maximiza o pone el form en modo ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonMaximizar1_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton maximizar");

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Abre el form de ABM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_admin_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton admin");

            FrmEditorDatos frmEditorDatos = new();
            frmEditorDatos.ShowDialog();
        }

        /// <summary>
        /// minimiza el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonMinimizar1_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton minimizar");
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// reproduce el tema que este seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_play_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton play");
            IniciarDetenerTema();
            btn_play.CambiarEstadoBoton(play);
        }

        /// <summary>
        /// inicia o detiene el tema que este seleccionado
        /// </summary>
        public static void IniciarDetenerTema()
        {
            audioFileReader = new AudioFileReader(AdministradorCanciones.tema);
            waveOutDevice.Init(audioFileReader);

            if (play)
            {
                waveOutDevice.Stop();
                audioFileReader.Dispose();
                play = false;
            }
            else
            {
                waveOutDevice.Play();
                play = true;
            }
        }

        /// <summary>
        /// reproduce una cancion random de la lista de canciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_siguiente_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton siguiente");

            UtilidadesForms.TocarCancionRandom(AdministradorCanciones.CancionesCargadas);
            btn_play.CambiarEstadoBoton(play);
        }

        /// <summary>
        /// reproduce una cancion random de la lista de canciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_anterior_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton anterior");

            UtilidadesForms.TocarCancionRandom(AdministradorCanciones.CancionesCargadas);
            btn_play.CambiarEstadoBoton(play);
        }
    }
}
