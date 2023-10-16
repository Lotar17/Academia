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
    public partial class FormBajaProfesor : Form
    {
        public FormBajaProfesor()
        {
            InitializeComponent();
            retrieveProfesores();
        }


        private void retrieveProfesores()
        {
            dtgv_BajaProfesor.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Persona> profesores = ctrlBaja.getProfesores();
            foreach (Persona p in profesores)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaProfesor.Rows.Add();
                dtgv_BajaProfesor.Rows[rowIndex].Cells["ID"].Value = p.IdPersona;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["nombre"].Value = p.Nombre;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["apellido"].Value = p.Apellido;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["direccion"].Value = p.Direccion;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["email"].Value = p.Email;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["telefono"].Value = p.Telefono;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["fechaNac"].Value = p.FechaNac;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["legajo"].Value = p.Legajo;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.getProfesorXCurso(idToDelete))
            {
                MessageBox.Show("Existen CURSOS asignados con el ID de PROFESOR a borrar.\nPor favor modifique esas instancias para poder borrar al profesor.");
            }
            else if (controller.getPersonaXUsuario(idToDelete))
            {
                MessageBox.Show("Existe un USUARIO asignado al ID de PROFESOR a borrar.\nPor favor elimine el usuario relacionado a la persona para continuar.");
            }
            else if (controller.profesorGetOne(idToDelete) != null)
            {
                controller.borrarProfesor(idToDelete);
                MessageBox.Show("Profesor borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveProfesores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
