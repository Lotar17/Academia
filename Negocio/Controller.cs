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
        PlanDAO planDAO = new PlanDAO();
        MateriaDAO materiaDAO = new MateriaDAO();
        ComisionDAO comisionDAO = new ComisionDAO();
        CursoDAO cursoDAO = new CursoDAO();


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

        public LinkedList<UsuarioADO> getUsuarios()
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
            return personaDAO.alumnosGetAll();
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
            return personaDAO.profesoresGetAll();
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
        public bool crearEspecialidad(Especialidade e)
        {
            return especialidadDAO.altaEspecialidad(e);
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

        public LinkedList<Especialidade> getEspecialidades()
        {
            return especialidadDAO.getAll();
        }

        //FIN METODOS ESPECIALIDADES//

        //INICIO METODOS PLANES//

        public bool crearPlan(Plane p)
        {
            return planDAO.altaPlan(p);
        }

        public bool borrarPlan(int idPlan)
        {
            return planDAO.bajaPlan(idPlan);
        }

        public bool modificarPlan(int idPlan, string descPlan, int idEspecialidad)
        {
            return planDAO.modificarPlan(idPlan, descPlan, idEspecialidad);
        }

        public Plane planGetOne(int idPlan)
        {
            return planDAO.getOne(idPlan);
        }

        public LinkedList<Plane> getPlanes()
        {
            return planDAO.getAll();
        }

        //FIN METODOS PLANES//

        //INICIO METODOS MATERIAS//

        public bool crearMateria(Materia m)
        {
            return materiaDAO.altaMateria(m);
        }

        public bool borrarMateria(int idMateria)
        {
            return materiaDAO.bajaMateria(idMateria);
        }

        public bool modificarMateria(int idMateria, string desc_materia, int hs_semanales, int hs_totales, int idPlan)
        {
            return materiaDAO.modificarMateria(idMateria, desc_materia, hs_semanales, hs_totales, idPlan);
        }

        public Materia materiaGetOne(int idMateria)
        {
            return materiaDAO.getOne(idMateria);
        }

        public LinkedList<Materia> getMaterias()
        {
            return materiaDAO.getAll();
        }

        //FIN METODOS MATERIAS//

        //INICIO METODOS COMISIONES//

        public bool crearComision(Comisione c)
        {
            return comisionDAO.altaComision(c);
        }

        public bool borrarComision(int idComision)
        {
            return comisionDAO.bajaComision(idComision);
        }

        public bool modificarComision(int idComision, string descComision, int anioEspecialidad, int idPlan)
        {
            return comisionDAO.modificarComision(idComision, descComision, anioEspecialidad, idPlan);
        }

        public Comisione comisionGetOne(int idComision)
        {
            return comisionDAO.getOne(idComision);
        }

        public LinkedList<Comisione> getComisiones()
        {
            return comisionDAO.getAll();
        }

        //FIN METODOS COMISIONES//

        //INICIO METODOS CURSOS//

        public bool crearCurso(Curso c)
        {
            return cursoDAO.altaCurso(c);
        }

        public bool borrarCurso(int idCurso)
        {
            return cursoDAO.bajaCurso(idCurso);
        }

        public bool modificarCurso(int idCurso, int id_materia, int id_comision, int anio_calendario, int cupo)
        {
            return cursoDAO.modificarComision(idCurso, id_materia, id_comision, anio_calendario, cupo);
        }

        public Curso cursoGetOne(int idCurso)
        {
            return cursoDAO.getOne(idCurso);
        }

        public LinkedList<Curso> getCursos()
        {
            return cursoDAO.getAll();
        }

        //FIN METODOS CURSOS//
    }
}