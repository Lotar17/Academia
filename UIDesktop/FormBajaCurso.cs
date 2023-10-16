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
    public partial class FormBajaCurso : Form
    {
        public FormBajaCurso()
        {
            InitializeComponent();
            retrieveCursos();
        }

        private void retrieveCursos()
        {
            dtgv_BajaCurso.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Curso> cursos = ctrlBaja.getCursos();
            foreach (Curso c in cursos)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaCurso.Rows.Add();
                dtgv_BajaCurso.Rows[rowIndex].Cells["ID"].Value = c.IdCurso;
                dtgv_BajaCurso.Rows[rowIndex].Cells["idMateria"].Value = c.IdMateria;
                dtgv_BajaCurso.Rows[rowIndex].Cells["idComision"].Value = c.IdComision;
                dtgv_BajaCurso.Rows[rowIndex].Cells["anioCalendario"].Value = c.AnioCalendario;
                dtgv_BajaCurso.Rows[rowIndex].Cells["cupo"].Value = c.Cupo;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.getCursoXDocente(idToDelete))
            {
                MessageBox.Show("Existen DOCENTES asignados al ID del CURSO a borrar.\n Por favor reasigne los docentes de esas instancias para poder borrar el curso.");

            }
            else if (controller.getCursoXInscripciones(idToDelete))
            {
                MessageBox.Show("Existen INSCRIPCIONES de alumnos asignadas al ID del CURSO a borrar.\n Por favor modifique esas instancias para poder borrar el curso.");
            }
            else if (controller.cursoGetOne(idToDelete) != null)
            {
                controller.borrarCurso(idToDelete);
                MessageBox.Show("Curso borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveCursos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
