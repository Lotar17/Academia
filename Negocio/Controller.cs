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
        EspecialidadDAO especialidadDAO = new EspecialidadDAO();
        public bool LoginUsuario(string nombre_usuario, string clave)
        {
            return usuarioDAO.Login(nombre_usuario, clave);
        }

        public bool crearUsuario(UsuarioADO usuario, int idPersona)
        {
            return usuarioDAO.createUser(usuario, idPersona);
        }

        public bool borrarUsuario(int idUsuario)
        {
            return usuarioDAO.deleteUser(idUsuario);
        }

        public LinkedList<UsuarioADO> GetUsuarios()
        {
            return usuarioDAO.getAll();
        }

        public bool verificarUsuarioPersona(int idPersona)
        {
            return usuarioDAO.getUsuario_Persona(idPersona);
        }

        public bool modificarUsuario(int idUsuario, string nombreUsuario, int habilitado)
        {
            return usuarioDAO.modificarUsuario(idUsuario, nombreUsuario, habilitado);
        }

        public UsuarioADO usuarioGetOne(int idUsuario)
        {
            return usuarioDAO.getOne(idUsuario);
        }

        public bool verificarPersona(int idPersona)
        {
            return personaDAO.getOne(idPersona);
        }
        
        public bool crearAlumno(Persona a)
        {
            return personaDAO.altaAlumno(a);
        }

        public bool borrarAlumno(int idAlumno)
        {
            return personaDAO.bajaAlumno(idAlumno);
        }

        public LinkedList<Persona> getAlumnos()
        {
            return personaDAO.getAll();
        }

        public bool crearEspecialidad(Especialidade especialidad)
        {
            return especialidadDAO.altaEspecialidad(especialidad);
        } 

        public bool borrarEspecialidad(int idEspecialidad)
        {
            return especialidadDAO.bajaEspecialidad(idEspecialidad);
        }

        public bool modificarEspecialidad(int idEspecialidad, string descEspecialidad)
        {
            return especialidadDAO.modificarEspecialidad(idEspecialidad, descEspecialidad);
        }

        public Especialidade especialidadGetOne(int idEspecialidad)
        {
            return especialidadDAO.getOne(idEspecialidad);
        }

        public LinkedList<Especialidade> GetEspecialidades()
        {
            return especialidadDAO.getAll();
        }

    }
}