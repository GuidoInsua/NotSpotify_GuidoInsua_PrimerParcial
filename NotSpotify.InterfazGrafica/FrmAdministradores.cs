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
    public partial class FrmAdministradores : Form
    {
        public FrmAdministradores()
        {
            InitializeComponent();
        }

        private void FrmAdministradores_Load(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmPopUp frmPopUp = new FrmPopUp(VerificadorDeInicio.EnumOpcionSesion.esAdmin);
            frmPopUp.ShowDialog();

            while (frmPopUp.accepto)
            {
                string[] datos = { frmPopUp.nombre, frmPopUp.apellido, frmPopUp.eMail, frmPopUp.password, frmPopUp.dni};

                if (AdministradorABM.CargarPersonaEnLista<Administrador>(datos))
                {
                    MessageBox.Show("Administrador Cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPopUp.accepto = false;
                }
                else
                {
                    MessageBox.Show($"{frmPopUp.dni}Datos no validos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmPopUp.ShowDialog();
                }
            }

            actualizarDataGrid();
        }

        private void actualizarDataGrid()
        {
            dgv_adminsCargados.Rows.Clear();
            int i = 0;

            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas)
            {
                if (persona is Administrador)
                {
                    Administrador admin = (Administrador)persona;

                    dgv_adminsCargados.Rows.Add();
                    dgv_adminsCargados.Rows[i].Cells[0].Value = admin.Nombre;
                    dgv_adminsCargados.Rows[i].Cells[1].Value = admin.Apellido;
                    dgv_adminsCargados.Rows[i].Cells[2].Value = admin.Email;
                    dgv_adminsCargados.Rows[i].Cells[3].Value = admin.Password;
                    dgv_adminsCargados.Rows[i].Cells[4].Value = admin.Dni;

                    i++;
                }
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = dgv_adminsCargados.SelectedRows[0].Cells[0].Value.ToString();
                string apellido = dgv_adminsCargados.SelectedRows[0].Cells[1].Value.ToString();
                string eMail = dgv_adminsCargados.SelectedRows[0].Cells[2].Value.ToString();
                string password = dgv_adminsCargados.SelectedRows[0].Cells[3].Value.ToString();
                string dni = dgv_adminsCargados.SelectedRows[0].Cells[4].Value.ToString();

                MessageBox.Show($" {nombre} \n {apellido} \n {eMail} \n {password} \n {dni}");

                Administrador admin = new Administrador(nombre, apellido, eMail, password, dni);

                if (AdministradorABM.BorrarPersonaDeLista(admin))
                {
                    MessageBox.Show("ok");
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
