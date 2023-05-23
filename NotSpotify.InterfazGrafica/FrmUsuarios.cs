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
            UtilidadesForms.ActualizarDataGridPersona<Usuario>(dgv_usuariosCargados);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmPopUp frmPopUp = new(VerificadorDeInicio.EnumOpcionSesion.esUsuario);
            frmPopUp.ShowDialog();

            while (frmPopUp.accepto)
            {
                string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password };

                try
                {
                    AdministradorABM.AgregarPersonaEnLista<Usuario>(datos);

                    MessageBox.Show("Usuario Cargado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    frmPopUp.accepto = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    frmPopUp.ShowDialog();
                }
            }

            UtilidadesForms.ActualizarDataGridPersona<Usuario>(dgv_usuariosCargados);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = UtilidadesForms.ObtenerPersonaDeDataGrid<Usuario>(dgv_usuariosCargados);

                FrmInformacion informacionForm = new(FrmInformacion.modoForm.borrarUsuario, usuario.Nombre, usuario.Email);
                informacionForm.ShowDialog();

                if (informacionForm.accepto)
                {
                    if (AdministradorABM.BorrarPersonaDeLista(usuario))
                    {
                        MessageBox.Show("Usuario eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show($"Error", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }

                UtilidadesForms.ActualizarDataGridPersona<Usuario>(dgv_usuariosCargados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obj null {ex}");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = UtilidadesForms.ObtenerPersonaDeDataGrid<Usuario>(dgv_usuariosCargados);

                FrmPopUp frmPopUp = new(VerificadorDeInicio.EnumOpcionSesion.esUsuario, usuario.Nombre, usuario.Apellido, usuario.Email, usuario.Password);
                frmPopUp.titulo = "Editar";
                frmPopUp.ShowDialog();

                while (frmPopUp.accepto)
                {
                    string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password };

                    try
                    {
                        AdministradorABM.ModificarPersonaEnLista<Usuario>(usuario, datos);

                        MessageBox.Show("Usuario actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        frmPopUp.accepto = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ERROR\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        frmPopUp.ShowDialog();
                    }
                }

                UtilidadesForms.ActualizarDataGridPersona<Usuario>(dgv_usuariosCargados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obj null {ex}");
            }
        }

        public new void Show()
        {
            UtilidadesForms.ActualizarDataGridPersona<Usuario>(dgv_usuariosCargados);
            base.Show();
        }

        private void btn_ascender_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = UtilidadesForms.ObtenerPersonaDeDataGrid<Usuario>(dgv_usuariosCargados);

                FrmInformacion informacionForm = new(FrmInformacion.modoForm.ascenderUsuario, usuario.Nombre, usuario.Email);
                informacionForm.ShowDialog();

                while (informacionForm.accepto)
                {
                    try
                    {
                        AdministradorABM.ConveritUsuarioEnAdmin(usuario, informacionForm.dni);

                        MessageBox.Show("Usuario ascendido", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        informacionForm.accepto = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ERROR\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        informacionForm.ShowDialog();
                    }
                }

                UtilidadesForms.ActualizarDataGridPersona<Usuario>(dgv_usuariosCargados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obj null {ex}");
            }
        }
    }
}
