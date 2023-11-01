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
    public partial class FormInscripcionCursos : Form
    {
        public FormInscripcionCursos()
        {
            InitializeComponent();
            retrieveCursos();
        }

        private void retrieveCursos()
        {
            dgv_Cursos.Rows.Clear();
            Controller controller = new Controller();
            LinkedList<Curso> cursos = controller.getCursos();

            foreach (Curso c in cursos)
            {
                if (controller.getCupo(c))
                {
                    // Agrega una nueva fila al DataGridView y obtiene su índice
                    int rowIndex = dgv_Cursos.Rows.Add();
                    dgv_Cursos.Rows[rowIndex].Cells["ID"].Value = c.IdCurso;
                    dgv_Cursos.Rows[rowIndex].Cells["materia"].Value = controller.materiaGetOne((int)c.IdMateria).DescMateria;
                    dgv_Cursos.Rows[rowIndex].Cells["comision"].Value = controller.comisionGetOne((int)c.IdComision).DescComision;
                    dgv_Cursos.Rows[rowIndex].Cells["anioCalendario"].Value = c.AnioCalendario;
                }

            }
        }

        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
            int idCurso = int.Parse(dgv_Cursos.SelectedRows[0].Cells["ID"].Value.ToString());
            Controller controller = new Controller();
            if (controller.getCursoXAlumno(idCurso))
            {
                if (controller.inscribirAlumno(idCurso))
                {
                    MessageBox.Show("Inscripcion cargada con exito");
                }
                else
                {
                    MessageBox.Show("Inscripcion fallida");
                }
            }
            else
            {
                MessageBox.Show("Ya se encuentra inscripto a este curso");
            }
            
        }
    }
}
