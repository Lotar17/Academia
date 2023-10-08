﻿using System;
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


        //INICIO METODOS USUARIO//

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

        //FIN METODOS USUARIO//


        //INICIO METODOS ALUMNO
        
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
            return personaDAO.getAllAlumnos();
        }

        public Persona alumnoGetOne(int idAlumno)
        {
            return personaDAO.alumnoGetOne(idAlumno);
        }

        public bool modificarAlumno(int idAlumno, string nombre, string apellido, string direccion, string email, string telefono, DateTime fecha_nac, int legajo)
        {
            return personaDAO.modificarAlumno(idAlumno,nombre, apellido, direccion, email,telefono, fecha_nac,legajo);
        }

        //FIN METODOS ALUMNO//



        //INICIO METODOS PROFESOR
        public bool crearProfesor(Persona p)
        {
            return personaDAO.altaProfesor(p);
        }

        public LinkedList<Persona> getProfesores()
        {
            return personaDAO.getAllProfesores();
        }

        public bool borrarProfesor(int idProfesor)
        {
            return personaDAO.bajaProfesor(idProfesor);
        }

        public bool modificarProfesor(int idProfesor, string nombre, string apellido, string direccion, string email, string telefono, DateTime fecha_nac, int legajo)
        {
            return personaDAO.modificarAlumno(idProfesor, nombre, apellido, direccion, email, telefono, fecha_nac, legajo);
        }

        public Persona profesorGetOne(int idProfesor)
        {
            return personaDAO.profesorGetOne(idProfesor);
        }


        //FIN METODOS PROFESOR//



        //INICIO METODOS ESPECIALIADES//
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

        //FIN METODOS ESPECIALIDADES//

    }
}