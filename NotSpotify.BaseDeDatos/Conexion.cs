using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static string Leer()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                ConexionSql.Open();

                ComandoSql.CommandText = "SELECT * FROM Prueba";

                using(var dataReader = ComandoSql.ExecuteReader())
                {
                    while(dataReader.Read()) 
                    {
                        sb.AppendLine($"{dataReader["Id"]} - {dataReader["Nombre"]}");
                    }
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

            return sb.ToString();
        }

        static public void CargarListaPersonasDesdeSql()
        {
            try
            {
                ConexionSql.Open();

                ComandoSql.CommandText = "SELECT * FROM Personas";

                using (var dataReader = ComandoSql.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string[] datos = { dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), dataReader["Email"].ToString(), dataReader["Password"].ToString(), dataReader["Dni"].ToString(), dataReader["Tipo"].ToString() };
                        NotSpotify.Clases.Factories.PersonaFactory.CargarPersonaPorLastOrDefaultSql(datos);
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
    }
}
