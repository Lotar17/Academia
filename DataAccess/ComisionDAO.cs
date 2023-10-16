using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ComisionDAO
    {
        public bool altaComision(Comisione comision)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Comisiones.Add(comision);
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

        public void bajaComision(int idComision)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var comision = context.Comisiones.SingleOrDefault(c => c.IdComision == idComision);
                    context.Comisiones.Remove(comision);
                    context.SaveChanges();
            }
        }

        public Comisione getOne(int idComision)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                Comisione comision = context.Comisiones.Find(idComision);

                return comision;
            }
        }

        public bool modificarComision(int idComision, string descComision, int anioEspecialidad, int idPlan)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    Comisione comision = context.Comisiones.Find(idComision);

                    if (comision != null)
                    {
                        comision.DescComision = descComision;
                        comision.AnioEspecialidad = anioEspecialidad;
                        comision.IdPlan = idPlan;
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

        public LinkedList<Comisione> getAll()
        {
            LinkedList<Comisione> comisiones = new LinkedList<Comisione>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var comision in context.Comisiones)
                {
                    comisiones.AddLast(comision);
                }
            }
            return comisiones;
        }

        public bool getComisionXCurso(int idComision)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                var count = context.Cursos.Count(c => c.IdComision == idComision);
                if (count > 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
