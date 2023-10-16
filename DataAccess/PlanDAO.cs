using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PlanDAO
    {
        public bool altaPlan(Plane plan)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Planes.Add(plan);
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

        public void bajaPlan(int idPlan)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var plan = context.Planes.SingleOrDefault(p => p.IdPlan == idPlan);
                context.Planes.Remove(plan);
                context.SaveChanges();
            }
        }

        public Plane getOne(int idPlan)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                Plane plan = context.Planes.Find(idPlan);

                return plan;
            }
        }

        public bool modificarPlan(int idPlan, string descPlan, int idEspecialidad)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    Plane plan = context.Planes.Find(idPlan);

                    if (plan != null)
                    {
                        plan.DescPlan = descPlan;
                        plan.IdEspecialidad = idEspecialidad;
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

        public LinkedList<Plane> getAll()
        {
            LinkedList<Plane> planes = new LinkedList<Plane>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var plan in context.Planes)
                {
                    planes.AddLast(plan);
                }
            }
            return planes;

        }

        public bool getPlanxPersona(int idPlan)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.Personas.Count(p => p.IdPlan == idPlan);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool getPlanxMateria(int idPlan)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.Materias.Count(m => m.IdPlan == idPlan);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool getPlanxComision(int idPlan)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.Comisiones.Count(c => c.IdPlan == idPlan);
                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
