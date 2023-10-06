using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EspecialidadDAO
    {
        public bool altaEspecialidad(Especialidade especialidade)
        {
            try
            {
                using (AcademiaDbContext context = new AcademiaDbContext())
                {
                    context.Especialidades.Add(especialidade);
                    context.SaveChanges();
                    return true;
                }
            }catch(DbUpdateException ex) 
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
            
        }

        public bool bajaEspecialidad(int idEspecialidad)
        {
            try
            {
                using(AcademiaDbContext context = new AcademiaDbContext())
                {
                    var especialidad = context.Especialidades.SingleOrDefault(e => e.IdEspecialidad == idEspecialidad);
                    if (especialidad != null)
                    {
                        context.Especialidades.Remove(especialidad);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }        
                }
            }catch (DbUpdateException ex)
            {
                System.Console.WriteLine("Error al eliminar la especialidad: " +ex.Message);
                return false;
            }
        }

        public Especialidade getOne(int idEspecialidad)
        {
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                Especialidade especialidad = context.Especialidades.Find(idEspecialidad);

                return especialidad;
            }
        }

        public bool modificarEspecialidad(int idEspecialidad, string descEspecialidad)
        {
            try
            {
                using(AcademiaDbContext context = new AcademiaDbContext())
                {
                    Especialidade especialidad = context.Especialidades.Find(idEspecialidad);
                    
                    if(especialidad != null)
                    {
                        especialidad.DescEspecialidad = descEspecialidad;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } catch (DbUpdateException ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public LinkedList<Especialidade> getAll()
        {
            LinkedList<Especialidade> especialidades = new LinkedList<Especialidade>();
            using (AcademiaDbContext context = new AcademiaDbContext())
            {
                foreach (var especialidad in context.Especialidades)
                {
                    especialidades.AddLast(especialidad);
                }
            }
            return especialidades;

        }



    }
}
