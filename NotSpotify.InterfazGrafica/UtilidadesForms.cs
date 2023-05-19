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

        static public void actualizarDataGridPersona<T>(DataGridView dataGrid) where T : Persona
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
    }
}
