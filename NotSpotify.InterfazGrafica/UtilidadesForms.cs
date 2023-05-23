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
    public static class UtilidadesForms
    {
        private static Panel _panelChanger = new();
        private static PlayList _unaPlayList = new();

        public static Panel PanelChanger { get => _panelChanger; set => _panelChanger = value; }
        public static PlayList UnaPlayList { get => _unaPlayList; set => _unaPlayList = value; }

        static readonly FrmHome homeForm = new();
        static readonly FrmLibrary libraryForm = new();
        static readonly FrmUnaPlayList unaPlayListForm = new();

        static public T ObtenerPersonaDeDataGrid<T>(DataGridView dataGrid) where T : Persona, ICargable, new()
        {
            T persona = new();
            StringBuilder sb = new();

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

                    if (persona is Administrador administrador)
                    {
                        dataGrid.Rows[i].Cells[4].Value = administrador.Dni;
                    }

                    i++;
                }
            }

            AdministradorDatos.GuardarListaPersonasEnArchivo("..\\..\\..\\..\\Archivos\\Personas.csv");
        }

        static public void ManejadorFormsMenu(string form)
        {
            switch (form)
            {
                case "Home":
                    libraryForm.Hide();
                    unaPlayListForm.Hide();
                    homeForm.TopLevel = false;
                    PanelChanger.Controls.Add(homeForm);
                    homeForm.Dock = DockStyle.Fill;
                    homeForm.Show();
                    break;
                case "Library":               
                    homeForm.Hide();
                    unaPlayListForm.Hide();
                    libraryForm.TopLevel = false;
                    PanelChanger.Controls.Add(libraryForm);
                    libraryForm.Dock = DockStyle.Fill;
                    libraryForm.Show();
                    break;
                case "PlayList":
                    homeForm.Hide();
                    unaPlayListForm.TopLevel = false;
                    PanelChanger.Controls.Add(unaPlayListForm);
                    unaPlayListForm.Dock = DockStyle.Fill;
                    unaPlayListForm.playList = UnaPlayList;
                    unaPlayListForm.Show();
                    break;
            }
        }

        static public Cancion ObtenerCancionDeDataGrid(DataGridView dataGrid)
        {
            StringBuilder sb = new();

            sb.Append($"{dataGrid.SelectedRows[0].Cells[0].Value.ToString()},");

            string[] datos = sb.ToString().Split(",");

            Cancion unaCancion = new(datos[0], datos[1]);

            return unaCancion;
        }

        static public void TocarCancionRandom(List<Cancion> listaCanciones)
        {
            Random r = new();

            AdministradorCanciones.tema = listaCanciones[r.Next(0, listaCanciones.Count)].Direccion;

            FrmMenu.IniciarDetenerTema();
        }
    }
}
