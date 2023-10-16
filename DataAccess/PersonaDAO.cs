using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PersonaDAO : ConnectionToSql
    {
        public bool getOne(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@id_persona", id);
                    command.CommandText = "SELECT * FROM personas WHERE id_persona = @id_persona";
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

        //INICIO METODOS ALUMNO//

        public bool altaAlumno(Persona alumno)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Personas.Add(alumno);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void bajaAlumno(int idAlumno)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var alumno = context.Personas.SingleOrDefault(e => e.IdPersona == idAlumno);
                context.Personas.Remove(alumno);
                context.SaveChanges();
            }
        }

        public LinkedList<Persona> alumnosGetAll()
        {
            LinkedList<Persona> alumnos = new LinkedList<Persona>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var alumno in context.Personas.Where(a => a.TipoPersona.Equals("Alumno")))
                {
                    alumnos.AddLast(alumno);
                }
            }
            return alumnos;
        }

        public bool modificarAlumno(int idAlumno, string nombre, string apellido, string direccion, string email, string telefono, DateTime fecha_nac, int legajo)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    Persona persona = context.Personas.Find(idAlumno);

                    if (persona != null)
                    {
                        persona.Nombre = nombre;
                        persona.Apellido = apellido;
                        persona.Direccion = direccion;
                        persona.Email = email;
                        persona.Telefono = telefono;
                        persona.FechaNac = fecha_nac;
                        persona.Legajo = legajo;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Persona alumnoGetOne(int idAlumno)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var alumno = context.Personas.Where(p => p.IdPersona == idAlumno && p.TipoPersona.Equals("Alumno")).FirstOrDefault();


                return alumno;
            }
        }

        //FIN METODOS ALUMNOS


        //INICIO METODOS PROFESOR//
        public bool altaProfesor(Persona profesor)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Personas.Add(profesor);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public LinkedList<Persona> profesoresGetAll()
        {
            LinkedList<Persona> profesores = new LinkedList<Persona>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var profesor in context.Personas.Where(a => a.TipoPersona.Equals("Docente")))
                {
                    profesores.AddLast(profesor);
                }
            }
            return profesores;
        }

        public void bajaProfesor(int idProfesor)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var profesor = context.Personas.SingleOrDefault(e => e.IdPersona == idProfesor);
                context.Personas.Remove(profesor);
                context.SaveChanges();
            }
        }

        public Persona profesorGetOne(int idProfesor)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var profesor = context.Personas.Where(p => p.IdPersona == idProfesor && p.TipoPersona.Equals("Docente")).FirstOrDefault();


                return profesor;
            }
        }

        //FIN METODOS PROFESOR//

        public bool getAlumnoXInscripciones(int idAlumno)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.AlumnosInscripciones.Count(a => a.IdAlumno == idAlumno);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool getProfesorXCurso(int idProfesor)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.DocentesCursos.Count(d => d.IdDocente == idProfesor);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool getPersonaXUsuario(int idPersona)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.Usuarios.Count(u => u.IdPersona == idPersona);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
