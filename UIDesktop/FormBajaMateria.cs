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
    public partial class FormBajaMateria : Form
    {
        public FormBajaMateria()
        {
            InitializeComponent();
            retrieveMaterias();
        }

        private void retrieveMaterias()
        {
            dtgv_BajaMateria.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Materia> materias = ctrlBaja.getMaterias();
            foreach (Materia m in materias)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaMateria.Rows.Add();
                dtgv_BajaMateria.Rows[rowIndex].Cells["ID"].Value = m.IdMateria;
                dtgv_BajaMateria.Rows[rowIndex].Cells["desc_materia"].Value = m.DescMateria;
                dtgv_BajaMateria.Rows[rowIndex].Cells["hsSemanales"].Value = m.HsSemanales;
                dtgv_BajaMateria.Rows[rowIndex].Cells["hsTotales"].Value = m.HsTotales;
                dtgv_BajaMateria.Rows[rowIndex].Cells["idPlan"].Value = m.IdPlan;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.materiaGetOne(idToDelete) != null)
            {
                if (controller.getMateriaxCurso(idToDelete))
                {
                    controller.borrarEspecialidad(idToDelete);
                    MessageBox.Show("Materia borrada con exito");
                }
                else
                {
                    MessageBox.Show("Existen instancias de CURSOS con el ID de MATERIAS a borrar.\n Por favor modifique esas instancias para poder borrar la materia.");
                }
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveMaterias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
