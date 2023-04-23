using NotSpotify.Clases;
using NotSpotify.Metodos;
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
            int i = 0;

            foreach (Usuario usuario in Login.UsuariosCargados)
            {
                dgr_listaUsuarios.Rows.Add();
                dgr_listaUsuarios.Rows[i].Cells[0].Value = usuario.Nombre;
                dgr_listaUsuarios.Rows[i].Cells[1].Value = usuario.Apellido;
                dgr_listaUsuarios.Rows[i].Cells[2].Value = usuario.Email;
                dgr_listaUsuarios.Rows[i].Cells[3].Value = usuario.Password;

                i++;
            }
        }
    }
}
