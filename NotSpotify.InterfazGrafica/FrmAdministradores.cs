﻿using NotSpotify.Clases;
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
    public partial class FrmAdministradores : Form
    {
        public FrmAdministradores()
        {
            InitializeComponent();
        }

        private void FrmAdministradores_Load(object sender, EventArgs e)
        {
            UtilidadesForms.ActualizarDataGridPersona<Administrador>(dgv_adminsCargados);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmPopUp frmPopUp = new(VerificadorDeInicio.EnumOpcionSesion.esAdmin);
            frmPopUp.ShowDialog();

            while (frmPopUp.accepto)
            {
                string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password, frmPopUp.dni };

                try
                {
                    AdministradorABM.AgregarPersonaEnLista<Administrador>(datos);

                    MessageBox.Show("Administrador Cargado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    frmPopUp.accepto = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    frmPopUp.ShowDialog();
                }
            }

            UtilidadesForms.ActualizarDataGridPersona<Administrador>(dgv_adminsCargados);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador admin = UtilidadesForms.ObtenerPersonaDeDataGrid<Administrador>(dgv_adminsCargados);

                FrmInformacion informacionForm = new(FrmInformacion.modoForm.borrarAdministrador, admin.Nombre, admin.Email);
                informacionForm.ShowDialog();

                if (informacionForm.accepto)
                {
                    if (AdministradorABM.BorrarPersonaDeLista(admin))
                    {
                        MessageBox.Show("Administrador eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show($"Error", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }

                UtilidadesForms.ActualizarDataGridPersona<Administrador>(dgv_adminsCargados);
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
                Administrador admin = UtilidadesForms.ObtenerPersonaDeDataGrid<Administrador>(dgv_adminsCargados);

                FrmPopUp frmPopUp = new(VerificadorDeInicio.EnumOpcionSesion.esAdmin, admin.Nombre, admin.Apellido, admin.Email, admin.Password, admin.Dni);
                frmPopUp.titulo = "Editar";
                frmPopUp.ShowDialog();

                while (frmPopUp.accepto)
                {
                    string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password, frmPopUp.dni };

                    try
                    {
                        AdministradorABM.ModificarPersonaEnLista<Administrador>(admin, datos);

                        MessageBox.Show("Administrador actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        frmPopUp.accepto = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ERROR\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        frmPopUp.ShowDialog();
                    }
                }

                UtilidadesForms.ActualizarDataGridPersona<Administrador>(dgv_adminsCargados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obj null {ex}");
            }
        }

        public new void Show()
        {
            UtilidadesForms.ActualizarDataGridPersona<Administrador>(dgv_adminsCargados);
            base.Show();
        }

        private void btn_degradar_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador admin = UtilidadesForms.ObtenerPersonaDeDataGrid<Administrador>(dgv_adminsCargados);

                FrmInformacion informacionForm = new(FrmInformacion.modoForm.degradarAdministrador, admin.Nombre, admin.Email);
                informacionForm.ShowDialog();

                while (informacionForm.accepto)
                {
                    if (AdministradorABM.ConveritAdminEnUsuario(admin))
                    {
                        MessageBox.Show("Administrador degradado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        informacionForm.accepto = false;
                    }
                    else
                    {
                        MessageBox.Show($"Error", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }

                UtilidadesForms.ActualizarDataGridPersona<Administrador>(dgv_adminsCargados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Obj null {ex}");
            }
        }
    }
}
