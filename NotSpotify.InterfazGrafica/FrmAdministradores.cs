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

        private void dgv_adminsCargados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAdministradores_Load(object sender, EventArgs e)
        {
            int i = 0;

            foreach (Administrador admin in VerificadorDeInicio.AdminsCargados)
            {
                dgv_adminsCargados.Rows.Add();
                dgv_adminsCargados.Rows[i].Cells[0].Value = admin.Nombre;
                dgv_adminsCargados.Rows[i].Cells[1].Value = admin.Apellido;
                dgv_adminsCargados.Rows[i].Cells[2].Value = admin.Email;
                dgv_adminsCargados.Rows[i].Cells[3].Value = admin.Password;
                dgv_adminsCargados.Rows[i].Cells[4].Value = admin.Dni;

                i++;
            }
        }

        private void lbl_administradores_Click(object sender, EventArgs e)
        {

        }
    }
}
