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
                    command.CommandText = "SELECT * FROM usuarios u INNER JOIN personas p ON u.id_persona = p.id_persona WHERE nombre_usuario = @nombre_usuario AND clave = @clave";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioLoginCache._IdUsuario = reader.GetInt32(0);  //guarda el usuario logeado actual en el cache
                            UsuarioLoginCache._NombreUsuario = reader.GetString(1);
                            UsuarioLoginCache._Nombre = reader.GetString(7);
                            UsuarioLoginCache._Apellido = reader.GetString(8);
                            UsuarioLoginCache._Email = reader.GetString(10);
                            UsuarioLoginCache._TipoUsuario = reader.GetInt32(14);
                        }
                        return true;
                    }
                    return false;
                }
            }
        }

        public bool createUser(Usuario usuario, int idPersona)
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

        public bool deleteUser(int idUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("id", idUsuario);
                    command.CommandText = "DELETE FROM usuarios WHERE id_usuario = @id";
                    command.CommandType = CommandType.Text;
                    int filasAfectadas = command.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public bool getUsuario_Persona(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id_persona", id);
                    command.CommandText = "SELECT * FROM personas p INNER JOIN usuarios u ON p.id_persona = u.id_persona WHERE u.id_persona = @id_persona";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
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
                    while(reader.Read())
                    {
                        int id = reader.GetInt32("id_usuario");
                        string nombreUsuario = reader.GetString("nombre_usuario");
                        bool habilitado = reader.GetBoolean("habilitado");
                        int idPersona;
                        if (reader.IsDBNull("id_persona"))
                        {
                            idPersona = 0;
                        }
                        else
                        {
                            idPersona = reader.GetInt32("id_persona");
                        }
                        Usuario usuario = new Usuario(id, nombreUsuario, habilitado, idPersona);
                        usuarios.AddLast(usuario);
                    }
                }
            }
            return usuarios;
        }

        public bool modificarUsuario(int id, string nombreUsuario, int habilitado)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("name", nombreUsuario);
                    command.Parameters.AddWithValue("habilitado", habilitado);
                    command.CommandText = "UPDATE usuarios SET nombre_usuario = @name, habilitado = @habilitado WHERE id_usuario = @id";
                    command.CommandType = CommandType.Text;
                    int filasAfectadas = command.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public Usuario getOne(int idUsuario)
        {
            Usuario usuario = new Usuario(0, "null", false, 0);
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("id", idUsuario);
                    command.CommandText = "SELECT * FROM usuarios WHERE id_usuario = @id";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        reader.Read();
                        int id = reader.GetInt32("id_usuario");
                        string nombreUsuario = reader.GetString("nombre_usuario");
                        bool habilitado = reader.GetBoolean("habilitado");
                        int idPersona;
                        if (reader.IsDBNull("id_persona"))
                        {
                            idPersona = 0;
                        }
                        else
                        {
                            idPersona = reader.GetInt32("id_persona");
                        }
                        usuario.Id = id;
                        usuario.NombreUsuario = nombreUsuario;
                        usuario.Habilitado = habilitado;
                        usuario.IdPersona = idPersona;
                    }
                    
                }
            }
            return usuario;
        }

    }
}
