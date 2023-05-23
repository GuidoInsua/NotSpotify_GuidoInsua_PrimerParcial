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


        public FrmCanciones()
        {
            InitializeComponent();
        }

        private void FrmCanciones_Load(object sender, EventArgs e)
        {
            ActualizarDataGridCanciones();
        }

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string link = tbx_linkCancion.Text;
            string nombre = tbx_nombre.Text;

            if (!string.IsNullOrWhiteSpace(link) && !string.IsNullOrWhiteSpace(nombre))
            {
                try
                {
                    AdministradorCanciones.NombreCancionValido(nombre);

                    FrmMenu.estadoDescarga = "Descargando...";
                    lbl_cargando.Text = FrmMenu.estadoDescarga;
                    Thread thread1 = new Thread(() => AgregarCancion(link, nombre));
                    thread1.IsBackground = true;
                    thread1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR\n{ex.Message}");
                }
            }
        }

        public Cancion ObtenerCancionDeDataGrid()
        {
            StringBuilder sb = new();

            sb.Append($"{dgv_canciones.SelectedRows[0].Cells[0].Value.ToString()},");
            sb.Append($"{dgv_canciones.SelectedRows[0].Cells[1].Value.ToString()},");

            string[] datos = sb.ToString().Split(",");

            Cancion unaCancion = new(datos[0], datos[1]);

            return unaCancion;
        }

        public void ActualizarDataGridCanciones()
        {
            dgv_canciones.Rows.Clear();
            int i = 0;

            foreach (Cancion unaCancion in VerificadorDeInicio.CancionesCargadas)
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

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            AdministradorCanciones.BorrarCancionDeLista(ObtenerCancionDeDataGrid());
            ActualizarDataGridCanciones();
        }
    }
}
