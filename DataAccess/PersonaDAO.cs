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

        public bool bajaAlumno(int idAlumno)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    var alumno = context.Personas.SingleOrDefault(e => e.IdPersona == idAlumno);
                    if (alumno != null)
                    {
                        context.Personas.Remove(alumno);
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
                System.Console.WriteLine("Error al eliminar la especialidad: " + ex.Message);
                return false;
            }
        }

        public Persona retrieveAlumno(int idAlumno)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var alumno = context.Personas.Include(p => p.IdPlan).SingleOrDefault(p => p.IdPersona == idAlumno);

                return alumno;
            }
        }

        public LinkedList<Persona> getAll()
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
    }
}
