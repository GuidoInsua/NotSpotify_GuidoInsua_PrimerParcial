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

namespace NotSpotify.InterfazGrafica
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmPopUp frmPopUp = new FrmPopUp(VerificadorDeInicio.EnumOpcionSesion.esUsuario);
            frmPopUp.ShowDialog();

            while (frmPopUp.accepto)
            {
                string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password };

                if (AdministradorABM.CargarPersonaEnLista<Usuario>(datos))
                {
                    MessageBox.Show("Usuario Cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPopUp.accepto = false;
                }
                else
                {
                    MessageBox.Show("Datos no validos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmPopUp.ShowDialog();
                }
            }

            actualizarDataGrid();
        }

        private void actualizarDataGrid()
        {
            dgv_usuariosCargados.Rows.Clear();
            int i = 0;

            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas)
            {
                if (persona is Usuario)
                {
                    Usuario usuario = (Usuario)persona;

                    dgv_usuariosCargados.Rows.Add();
                    dgv_usuariosCargados.Rows[i].Cells[0].Value = usuario.Nombre;
                    dgv_usuariosCargados.Rows[i].Cells[1].Value = usuario.Apellido;
                    dgv_usuariosCargados.Rows[i].Cells[2].Value = usuario.Email;
                    dgv_usuariosCargados.Rows[i].Cells[3].Value = usuario.Password;

                    i++;
                }
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = dgv_usuariosCargados.SelectedRows[0].Cells[0].Value.ToString();
                string apellido = dgv_usuariosCargados.SelectedRows[0].Cells[1].Value.ToString();
                string eMail = dgv_usuariosCargados.SelectedRows[0].Cells[2].Value.ToString();
                string password = dgv_usuariosCargados.SelectedRows[0].Cells[3].Value.ToString();

                Usuario usuario = new Usuario(nombre, apellido, eMail, password);

                DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea borrar a: \n\n {nombre} \n {eMail}", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (AdministradorABM.BorrarPersonaDeLista(usuario))
                    {
                        MessageBox.Show($"Usuario eliminado");
                    }
                }

                actualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Obj null");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = dgv_usuariosCargados.SelectedRows[0].Cells[0].Value.ToString();
                string apellido = dgv_usuariosCargados.SelectedRows[0].Cells[1].Value.ToString();
                string eMail = dgv_usuariosCargados.SelectedRows[0].Cells[2].Value.ToString();
                string password = dgv_usuariosCargados.SelectedRows[0].Cells[3].Value.ToString();

                Usuario usuario = new Usuario(nombre, apellido, eMail, password);

                FrmPopUp frmPopUp = new FrmPopUp(VerificadorDeInicio.EnumOpcionSesion.esUsuario);

                frmPopUp.titulo = "Editar";

                frmPopUp.nombre = nombre;
                frmPopUp.apellido = apellido;
                frmPopUp.eMail = eMail;
                frmPopUp.password = password;

                frmPopUp.ShowDialog();

                while (frmPopUp.accepto)
                {
                    string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password};

                    if (AdministradorABM.ModificarPersonaEnLista<Usuario>(usuario, datos))
                    {
                        MessageBox.Show("Usuario actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPopUp.accepto = false;
                    }
                    else
                    {
                        MessageBox.Show($"Datos no validos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frmPopUp.ShowDialog();
                    }
                }

                actualizarDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Obj null");
            }
        }
    }
}
