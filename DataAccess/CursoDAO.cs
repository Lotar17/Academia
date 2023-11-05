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

        public void bajaCurso(int idCurso)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var curso = context.Cursos.SingleOrDefault(c => c.IdCurso == idCurso);
                context.Cursos.Remove(curso);
                context.SaveChanges();
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

        public bool getCursoXDocente(int idCurso)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.DocentesCursos.Count(d => d.IdCurso == idCurso);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool getCursoXInscripciones(int idCurso)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.AlumnosInscripciones.Count(a => a.IdCurso == idCurso);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool inscribirAlumno(int idCurso)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                AlumnosInscripcione alumnosInscripcione = new AlumnosInscripcione();
                alumnosInscripcione.IdCurso = idCurso;
                alumnosInscripcione.IdAlumno = UsuarioLoginCache._IdPersona;
                alumnosInscripcione.Condicion = "INSCRIPTO";
                alumnosInscripcione.Nota = null;
                context.AlumnosInscripciones.Add(alumnosInscripcione);
                Curso cursoAActualizar = context.Cursos.Find(idCurso);
                if (cursoAActualizar != null)
                {
                    cursoAActualizar.Cupo -= 1;

                    context.SaveChanges();
                }
                return true;
            }
        }

        public bool inscribirDocente(int idCurso)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                DocentesCurso docentesCurso = new DocentesCurso();
                docentesCurso.IdCurso = idCurso;
                docentesCurso.IdDocente = UsuarioLoginCache._IdPersona;
                docentesCurso.Cargo= null;
                context.DocentesCursos.Add(docentesCurso);
                return true;
            }
        }

        public bool getCursoXAlumno(int idCurso)
        {
            int idAlumno = UsuarioLoginCache._IdPersona;
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.AlumnosInscripciones.Count(a => a.IdCurso == idCurso && a.IdAlumno == idAlumno);
                if (count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool getCupo(Curso c)
        {
            int cantidadInscriptos = 0;
            int cupo = (int)c.Cupo;
            using(AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach(AlumnosInscripcione alu in context.AlumnosInscripciones)
                {
                    if (c.IdCurso == alu.IdCurso)
                    { cantidadInscriptos++;}
                }
            }
            if(cantidadInscriptos <= cupo)
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
