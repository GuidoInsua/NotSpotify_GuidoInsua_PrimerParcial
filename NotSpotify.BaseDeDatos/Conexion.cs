using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotSpotify.Clases;
using NotSpotify.Clases.Interfaces;
using NotSpotify.Utilidades;

namespace NotSpotify.BaseDeDatos
{
    public static class Conexion
    {
        private static SqlConnection? _conexionSql;
        private static SqlCommand? _comandoSql;
        private static string? _stringConexion;

        public static SqlConnection? ConexionSql { get => _conexionSql; set => _conexionSql = value; }
        public static SqlCommand? ComandoSql { get => _comandoSql; set => _comandoSql = value; }
        public static string? StringConexion { get => _stringConexion; set => _stringConexion = value; }

        static Conexion()
        {
            StringConexion = @"Server=DESKTOP-O52ODC4\SQLEXPRESS;Database=NotSpotify-SQL-SMS;Trusted_Connection=True";

            ConexionSql = new SqlConnection(StringConexion);
            ComandoSql = new SqlCommand();
            ComandoSql.Connection = ConexionSql;
            ComandoSql.CommandType = System.Data.CommandType.Text; 
        }

        static public void CargarListaDesdeSql(string tabla)
        {
           try
            {
                ConexionSql.Open();

                ComandoSql.CommandText = $"SELECT * FROM {tabla}";

                using (var dataReader = ComandoSql.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (tabla == "Personas")
                        {
                            string[] datos = { dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), dataReader["Email"].ToString(),
                            dataReader["Password"].ToString(), dataReader["Dni"].ToString(), dataReader["Tipo"].ToString() };

                            NotSpotify.Clases.Factories.PersonaFactory.CargarPersonaPorLastOrDefault(datos);
                        }

                        if (tabla == "PlayLists")
                        {
                            string[] datos = { dataReader["Nombre"].ToString(), dataReader["Descripccion"].ToString(), dataReader["DireccionDeImagen"].ToString()};

                            NotSpotify.Utilidades.AdministradorPlayLists.AgregarPlayListEnLista(datos);
                        }
                    }

                    dataReader.Close();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ConexionSql.Close();
            }
        }

        static public void GuardarListaEnSql<T>(List<T> lista, string tabla) where T : class, ICargable
        {
            try
            {
                ConexionSql.Open();

                ComandoSql.CommandText = $"TRUNCATE TABLE {tabla}";
                ComandoSql.ExecuteNonQuery();

                foreach (T objeto in lista)
                {
                    ComandoSql.CommandText = objeto.GuardarDatosEnSql();

                    ComandoSql.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ConexionSql.Close();
            }
        }
    }
}
