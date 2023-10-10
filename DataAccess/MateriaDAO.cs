using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MateriaDAO
    {
        public bool altaMateria(Materia materia)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Materias.Add(materia);
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

        public bool bajaMateria(int idMateria)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    var materia = context.Materias.SingleOrDefault(p => p.IdMateria == idMateria);
                    if (materia != null)
                    {
                        context.Materias.Remove(materia);
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
                System.Console.WriteLine("Error al eliminar la materia: " + ex.Message);
                return false;
            }
        }

        public Materia getOne(int idMateria)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                Materia materia = context.Materias.Find(idMateria);

                return materia;
            }
        }

        public bool modificarMateria(int idMateria, string desc_materia, int hs_semanales, int hs_totales, int idPlan)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    Materia materia = context.Materias.Find(idMateria);

                    if (materia != null)
                    {
                        materia.DescMateria = desc_materia;
                        materia.HsSemanales = hs_semanales;
                        materia.HsTotales = hs_totales;
                        materia.IdPlan = idPlan;
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

        public LinkedList<Materia> getAll()
        {
            LinkedList<Materia> materias = new LinkedList<Materia>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var materia in context.Materias)
                {
                    materias.AddLast(materia);
                }
            }
            return materias;
        }
    }
}
