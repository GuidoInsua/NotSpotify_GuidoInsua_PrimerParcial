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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            int i = 0;

            foreach (Usuario usuario in VerificadorDeInicio.UsuariosCargados)
            {
                dgv_usuariosCargados.Rows.Add();
                dgv_usuariosCargados.Rows[i].Cells[0].Value = usuario.Nombre;
                dgv_usuariosCargados.Rows[i].Cells[1].Value = usuario.Apellido;
                dgv_usuariosCargados.Rows[i].Cells[2].Value = usuario.Email;
                dgv_usuariosCargados.Rows[i].Cells[3].Value = usuario.Password;

                i++;
            }
        }
    }
}
