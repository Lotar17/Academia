using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using Entities;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

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

        public void borrarAlumno(int idAlumno)
        {
            personaDAO.bajaAlumno(idAlumno);
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

        public bool getAlumnoXInscripciones(int idAlumno)
        {
            return personaDAO.getAlumnoXInscripciones(idAlumno);
        }

        public bool getPersonaXUsuario(int idPersona)
        {
            return personaDAO.getPersonaXUsuario(idPersona);
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

        public void borrarProfesor(int idProfesor)
        {
            personaDAO.bajaProfesor(idProfesor);
        }

        public bool modificarProfesor(int idProfesor, string nombre, string apellido, string direccion, string email, string telefono, DateTime fecha_nac, int legajo)
        {
            return personaDAO.modificarAlumno(idProfesor, nombre, apellido, direccion, email, telefono, fecha_nac, legajo);
        }

        public Persona profesorGetOne(int idProfesor)
        {
            return personaDAO.profesorGetOne(idProfesor);
        }

        public bool getProfesorXCurso(int idProfesor)
        {
            return personaDAO.getProfesorXCurso(idProfesor);
        }
        //FIN METODOS PROFESOR//



        //INICIO METODOS ESPECIALIADES//
        public bool crearEspecialidad(Especialidade e)
        {
            return especialidadDAO.altaEspecialidad(e);
        } 

        public void borrarEspecialidad(int idEspecialidad)
        {
            especialidadDAO.bajaEspecialidad(idEspecialidad);
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

        public bool getEspecialidadxPlan(int idPlan)
        {
            return especialidadDAO.getEspecialidadxPlan(idPlan);
        }

        //FIN METODOS ESPECIALIDADES//

        //INICIO METODOS PLANES//

        public bool crearPlan(Plane p)
        {
            return planDAO.altaPlan(p);
        }

        public void borrarPlan(int idPlan)
        {
            planDAO.bajaPlan(idPlan);
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

        public bool getPlanxPersona(int idPlan)
        {
            return planDAO.getPlanxPersona(idPlan);
        }

        public bool getPlanxMateria(int idPlan)
        {
            return planDAO.getPlanxMateria(idPlan);
        }

        public bool getPlanxComision(int idPlan)
        {
            return planDAO.getPlanxComision(idPlan);
        }

        //FIN METODOS PLANES//

        //INICIO METODOS MATERIAS//

        public bool crearMateria(Materia m)
        {
            return materiaDAO.altaMateria(m);
        }

        public void borrarMateria(int idMateria)
        {
            materiaDAO.bajaMateria(idMateria);
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

        public bool getMateriaxCurso(int idMateria)
        {
            return materiaDAO.getMateriaXCurso(idMateria);
        }

        //FIN METODOS MATERIAS//

        //INICIO METODOS COMISIONES//

        public bool crearComision(Comisione c)
        {
            return comisionDAO.altaComision(c);
        }

        public void borrarComision(int idComision)
        {
            comisionDAO.bajaComision(idComision);
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

        public bool getComisionXCurso (int idComision)
        {
            return comisionDAO.getComisionXCurso(idComision);
        }

        //FIN METODOS COMISIONES//

        //INICIO METODOS CURSOS//

        public bool crearCurso(Curso c)
        {
            return cursoDAO.altaCurso(c);
        }

        public void borrarCurso(int idCurso)
        {
            cursoDAO.bajaCurso(idCurso);
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

        public bool getCursoXDocente(int idCurso)
        {
            return cursoDAO.getCursoXDocente(idCurso);
        }

        public bool getCursoXInscripciones(int idCurso)
        {
            return cursoDAO.getCursoXInscripciones(idCurso);
        }

        //FIN METODOS CURSOS//

        //METODOS INSCRIPCION ALUMNO A CURSO//

        public bool inscribirAlumno(int idCurso)
        {
            return cursoDAO.inscribirAlumno(idCurso);
        }

        public bool getCupo(Curso curso)
        {
            return cursoDAO.getCupo(curso);
        }

        public bool getCursoXAlumno(int idCurso)
        {
            return cursoDAO.getCursoXAlumno(idCurso);
        }

        //FIN METODOS INSCRIPCION ALUMNO A CURSO//

        //INICIO METODOS INSCRIPCION DOCENTE A CURSO//

        public async Task<List<Curso>> cursosGetAll()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:7197/api/Cursos");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<Curso>>(content);
                return cursos;

            }
            else
            {
                return null;
            }
        }

        public bool inscribirDocente(int idCurso)
        {
            return cursoDAO.inscribirDocente(idCurso) ;
        }

    }
}