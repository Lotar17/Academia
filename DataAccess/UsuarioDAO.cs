using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;


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

        public bool create_user(Usuario usuario, int idPersona)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@clave", usuario.Clave);
                    command.Parameters.AddWithValue("@habilitado", usuario.Habilitado);
                    command.Parameters.AddWithValue("@idPersona", idPersona);
                    command.CommandText =
                        "INSERT INTO usuarios(nombre_usuario,clave,habilitado,id_persona) VALUES (@nombre_usuario,@clave,@habilitado,@idPersona)";
                    command.CommandType = CommandType.Text;
                    int filasAfectadas = command.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool verificarUser (int idPersona)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue ("id", idPersona);
                    command.CommandText = "SELECT * FROM usuarios WHERE id_persona = @id";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public LinkedList<Usuario> getAll()
        {
            LinkedList<Usuario> usuarios = new LinkedList<Usuario>();
            using (var connection = GetConnection())
            {
                connection.Open ();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM usuarios";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader ();
                    while(reader.HasRows)
                    {
                        int id = reader.GetInt32("id");
                        string nombreUsuario = reader.GetString("nombre_usuario");
                        bool habilitado = reader.GetBoolean("habilitado");
                        int idPersona = reader.GetInt32 ("id_persona");
                        Usuario usuario = new Usuario(id, nombreUsuario, habilitado, idPersona);
                        usuarios.AddLast(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
}
