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

        private void botonCerrar1_Click(object sender, EventArgs e)
        {
            waveOutDevice.Dispose();
            Environment.Exit(Environment.ExitCode);
            Close();
        }

        private void btn_menuHome_Click(object sender, EventArgs e)
        {
            btn_menuLibrary.ApagarBotonLibrary();

            UtilidadesForms.ManejadorFormsMenu("Home");
        }

        private void btn_menuLibrary_Click(object sender, EventArgs e)
        {
            btn_menuHome.ApagarBotonHome();

            UtilidadesForms.ManejadorFormsMenu("Library");
        }

        private void botonMaximizar1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FrmEditorDatos frmEditorDatos = new();
            frmEditorDatos.ShowDialog();
        }

        private void botonMinimizar1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            IniciarDetenerTema();
            btn_play.CambiarEstadoBoton(play);
        }

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

        private void pbx_siguiente_Click(object sender, EventArgs e)
        {
            UtilidadesForms.TocarCancionRandom(AdministradorCanciones.CancionesCargadas);
            btn_play.CambiarEstadoBoton(play);
        }

        private void pbx_anterior_Click(object sender, EventArgs e)
        {
            UtilidadesForms.TocarCancionRandom(AdministradorCanciones.CancionesCargadas);
            btn_play.CambiarEstadoBoton(play);
        }
    }
}
