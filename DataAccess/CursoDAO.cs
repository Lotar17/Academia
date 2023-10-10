using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CursoDAO
    {
        public bool altaCurso(Curso curso)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Cursos.Add(curso);
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

        public bool bajaCurso(int idCurso)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    var curso = context.Cursos.SingleOrDefault(c => c.IdCurso == idCurso);
                    if (curso != null)
                    {
                        context.Cursos.Remove(curso);
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
                System.Console.WriteLine("Error al eliminar el curso: " + ex.Message);
                return false;
            }
        }

        public Curso getOne(int idCurso)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                Curso curso = context.Cursos.Find(idCurso);

                return curso;
            }
        }

        public bool modificarComision(int idCurso, int id_materia, int id_comision, int anio_calendario, int cupo)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    Curso curso = context.Cursos.Find(idCurso);

                    if (curso != null)
                    {
                        curso.IdCurso = idCurso;
                        curso.IdMateria = id_materia;
                        curso.IdComision = id_comision;
                        curso.AnioCalendario = anio_calendario;
                        curso.Cupo = cupo;
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

        public LinkedList<Curso> getAll()
        {
            LinkedList<Curso> cursos = new LinkedList<Curso>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var curso in context.Cursos)
                {
                    cursos.AddLast(curso);
                }
            }
            return cursos;
        }
    }
}
