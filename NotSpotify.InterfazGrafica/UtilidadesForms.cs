using NotSpotify.Clases;
using NotSpotify.Clases.Interfaces;
using NotSpotify.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NotSpotify.Utilidades.VerificadorDeInicio;

namespace NotSpotify.InterfazGrafica
{
    public class UtilidadesForms
    {
        static public Panel panel;
        static public PlayList unaPlayList;

        static FrmHome homeForm = new FrmHome();
        static FrmLibrary libraryForm = new FrmLibrary();
        static FrmUnaPlayList unaPlayListForm = new FrmUnaPlayList();

        static public T ObtenerPersonaDeDataGrid<T>(DataGridView dataGrid) where T : Persona, ICargable, new()
        {
            T persona = new T();
            StringBuilder sb = new StringBuilder();

            sb.Append($"{dataGrid.SelectedRows[0].Cells[0].Value.ToString()},"); 
            sb.Append($"{dataGrid.SelectedRows[0].Cells[1].Value.ToString()},");
            sb.Append($"{dataGrid.SelectedRows[0].Cells[2].Value.ToString()},");
            sb.Append($"{dataGrid.SelectedRows[0].Cells[3].Value.ToString()},");

            if (persona is Administrador)
            {
                sb.Append($"{dataGrid.SelectedRows[0].Cells[4].Value.ToString()}");
            }

            string[] datos = sb.ToString().Split(",");
            persona.CargarDatosDesdeArray(datos);

            return persona;
        }

        static public void ActualizarDataGridPersona<T>(DataGridView dataGrid) where T : Persona
        {
            dataGrid.Rows.Clear();
            int i = 0;

            foreach (Persona persona in VerificadorDeInicio.PersonasCargadas)
            {
                if (persona is T)
                {
                    dataGrid.Rows.Add();
                    dataGrid.Rows[i].Cells[0].Value = persona.Nombre;
                    dataGrid.Rows[i].Cells[1].Value = persona.Apellido;
                    dataGrid.Rows[i].Cells[2].Value = persona.Email;
                    dataGrid.Rows[i].Cells[3].Value = persona.Password;

                    if (persona is Administrador)
                    {
                        dataGrid.Rows[i].Cells[4].Value = ((Administrador)persona).Dni;
                    }

                    i++;
                }
            }
        }

        static public void ManejadorFormsMenu(string form)
        {
            switch (form)
            {
                case "Home":
                    libraryForm.Hide();
                    unaPlayListForm.Hide();
                    homeForm.TopLevel = false;
                    panel.Controls.Add(homeForm);
                    homeForm.Dock = DockStyle.Fill;
                    homeForm.Show();
                    break;
                case "Library":               
                    homeForm.Hide();
                    unaPlayListForm.Hide();
                    libraryForm.TopLevel = false;
                    panel.Controls.Add(libraryForm);
                    libraryForm.Dock = DockStyle.Fill;
                    libraryForm.Show();
                    break;
                case "PlayList":
                    homeForm.Hide();
                    unaPlayListForm.TopLevel = false;
                    panel.Controls.Add(unaPlayListForm);
                    unaPlayListForm.Dock = DockStyle.Fill;
                    unaPlayListForm.playList = unaPlayList;
                    unaPlayListForm.Show();
                    break;
            }
        }
    }
}
