using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using Entities;

namespace Dominio
{
    public class Controller
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        PersonaDAO personaDAO = new PersonaDAO();
        public bool LoginUsuario(string nombre_usuario, string clave)
        {
            return usuarioDAO.Login(nombre_usuario, clave);
        }

        public bool crearUsuario(Usuario usuario, int idPersona)
        {
            return usuarioDAO.createUser(usuario, idPersona);
        }

        public bool borrarUsuario(int idUsuario)
        {
            return usuarioDAO.deleteUser(idUsuario);
        }

        public LinkedList<Usuario> GetUsuarios()
        {
            return usuarioDAO.getAll();
        }

        public bool verificarUsuarioPersona(int idPersona)
        {
            return usuarioDAO.getUsuario_Persona(idPersona);
        }

        public bool verificarPersona(int idPersona)
        {
            return personaDAO.getOne(idPersona);
        }

        public bool modificarUsuario(int idUsuario, string nombreUsuario, int habilitado)
        {
            return usuarioDAO.modificarUsuario(idUsuario, nombreUsuario, habilitado);
        }

        public Usuario usuarioGetOne(int idUsuario)
        {
            return usuarioDAO.getOne(idUsuario);
        }
    }
}