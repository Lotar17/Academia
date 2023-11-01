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
    public partial class FormDocentesCursos : Form
    {
        private List<Curso> cursos;

        public FormDocentesCursos()
        {
            InitializeComponent();
            retrieveCursos();
        }

        public async void retrieveCursos()
        {
            Controller controller = new Controller();
            cursos = await controller.cursosGetAll();
            dgv_Cursos.DataSource = cursos;
            dgv_Cursos.Columns["IdComisionNavigation"].Visible = false;
            dgv_Cursos.Columns["IdMateriaNavigation"].Visible = false;
        }

        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
            int idCurso = int.Parse(dgv_Cursos.SelectedRows[0].Cells["IdCurso"].Value.ToString());
            Controller controller = new Controller();
            if (controller.getCursoXDocente(idCurso) == false)
            {
                if (controller.inscribirDocente(idCurso))
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
            retrieveCursos();
        }
    }
}
