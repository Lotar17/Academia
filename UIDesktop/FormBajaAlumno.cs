using Dominio;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class FormBajaAlumno : Form
    {
        public FormBajaAlumno()
        {
            InitializeComponent();
            retrieveAlumnos();
        }

        private void retrieveAlumnos()
        {
            dtgv_BajaAlumno.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Persona> alumnos = ctrlBaja.getAlumnos();
            foreach (Persona p in alumnos)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaAlumno.Rows.Add();
                dtgv_BajaAlumno.Rows[rowIndex].Cells["ID"].Value = p.IdPersona;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["nombre"].Value = p.Nombre;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["apellido"].Value = p.Apellido;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["direccion"].Value = p.Direccion;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["email"].Value = p.Email;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["telefono"].Value = p.Telefono;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["fechaNac"].Value = p.FechaNac;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["legajo"].Value = p.Legajo;
                dtgv_BajaAlumno.Rows[rowIndex].Cells["idPlan"].Value = p.IdPlan;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.getAlumnoXInscripciones(idToDelete))
            {
                MessageBox.Show("Existen INSCRIPCIONES asignadas con el ID de ALUMNO a borrar.\nPor favor elimine las inscripciones para poder borrar al alumno.");
            }
            else if (controller.getPersonaXUsuario(idToDelete))
            {
                MessageBox.Show("Existe un USUARIO asignado al ID de ALUMNO a borrar.\nPor favor elimine el usuario relacionado a la persona para continuar.");
            }
            else if (controller.alumnoGetOne(idToDelete) != null)
            {
                controller.borrarAlumno(idToDelete);
                MessageBox.Show("Alumno borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveAlumnos();
        }
    }
}
