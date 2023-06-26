using NotSpotify.Clases;
using NotSpotify.Clases.Interfaces;
using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmCanciones : Form
    {
        public delegate void DelegadoLog(string message);
        public static event DelegadoLog? EventoLog;
        public FrmCanciones()
        {
            InitializeComponent();
        }

        private void FrmCanciones_Load(object sender, EventArgs e)
        {
            EventoLog += Logs.Log;
            ActualizarDataGridCanciones();
        }

        /// <summary>
        /// Descarga un video de youtube, lo convierte en mp3 y agraga la cancion a la lista de canciones
        /// </summary>
        /// <param name="link"></param>
        /// <param name="nombre"></param>
        private void AgregarCancion(string link, string nombre)
        {
            AdministradorCanciones.SaveMP3("..\\..\\..\\..\\Canciones", link, nombre);

            string path = $"..\\..\\..\\..\\Canciones\\{nombre}.mp3";

            AdministradorCanciones.AgregarCancionEnLista(nombre, path);

            Invoke(new Action(() =>
            {
                ActualizarDataGridCanciones();

                FrmMenu.estadoDescarga = "Terminado";
                lbl_cargando.Text = FrmMenu.estadoDescarga;
            }));
        }

        /// <summary>
        /// Llama a la funcion "Agregar Cancion" desde un nuevo thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton add");
            string link = tbx_linkCancion.Text;
            string nombre = tbx_nombre.Text;

            if (!string.IsNullOrWhiteSpace(link) && !string.IsNullOrWhiteSpace(nombre))
            {
                try
                {
                    AdministradorCanciones.NombreCancionValido(nombre);
                    AdministradorCanciones.ValidarLinkYouTube(link);

                    FrmMenu.estadoDescarga = "Descargando...";
                    lbl_cargando.Text = FrmMenu.estadoDescarga;
                    Thread thread1 = new(() => AgregarCancion(link, nombre));
                    thread1.IsBackground = true;
                    thread1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR\n{ex.Message}");
                }
            }
        }

        /// <summary>
        /// Actualiza la tabla de canciones
        /// </summary>
        public void ActualizarDataGridCanciones()
        {
            dgv_canciones.Rows.Clear();
            int i = 0;

            foreach (Cancion unaCancion in AdministradorCanciones.CancionesCargadas)
            {
                dgv_canciones.Rows.Add();
                dgv_canciones.Rows[i].Cells[0].Value = unaCancion.Nombre;
                dgv_canciones.Rows[i].Cells[1].Value = unaCancion.Direccion;

                i++;
            }
        }

        public new void Show()
        {
            ActualizarDataGridCanciones();
            lbl_cargando.Text = FrmMenu.estadoDescarga;
            base.Show();
        }

        /// <summary>
        /// Borra una cancion de la lista de canciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            EventoLog?.Invoke($"{this.Name} - Boton borrar");
            AdministradorCanciones.BorrarCancionDeLista(UtilidadesForms.ObtenerCancionDeDataGrid(dgv_canciones));
            ActualizarDataGridCanciones();
        }
    }
}
