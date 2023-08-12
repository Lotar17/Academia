using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class UsuarioDAO : ConnectionToSql
    {
        public bool Login(string nombre_usuario, string clave)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandText = "SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario AND clave = @clave";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
