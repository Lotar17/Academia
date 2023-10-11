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
    public partial class FormModificacionMaterias : Form
    {
        public FormModificacionMaterias()
        {
            InitializeComponent();
            retrieveMaterias();
        }

        private void retrieveMaterias()
        {
            dtgv_modificacionMateria.Rows.Clear();
            Controller ctrlModificacion = new Controller();
            LinkedList<Materia> materias = ctrlModificacion.getMaterias();
            foreach (Materia m in materias)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_modificacionMateria.Rows.Add();
                dtgv_modificacionMateria.Rows[rowIndex].Cells["ID"].Value = m.IdMateria;
                dtgv_modificacionMateria.Rows[rowIndex].Cells["desc_materia"].Value = m.DescMateria;
                dtgv_modificacionMateria.Rows[rowIndex].Cells["hsSemanales"].Value = m.HsSemanales;
                dtgv_modificacionMateria.Rows[rowIndex].Cells["hsTotales"].Value = m.HsTotales;
                dtgv_modificacionMateria.Rows[rowIndex].Cells["idPlan"].Value = m.IdPlan;
            }
        }

        private void dtgv_modificacionMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_descMateria.Text = dtgv_modificacionMateria.SelectedRows[0].Cells["desc_materia"].Value.ToString();
            nud_hsSemanales.Value = int.Parse(dtgv_modificacionMateria.SelectedRows[0].Cells["hsSemanales"].Value.ToString());
            nud_hsTotales.Value = int.Parse(dtgv_modificacionMateria.SelectedRows[0].Cells["hsTotales"].Value.ToString());
            nud_idPlan.Value = int.Parse(dtgv_modificacionMateria.SelectedRows[0].Cells["idPlan"].Value.ToString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idMateria = int.Parse(dtgv_modificacionMateria.SelectedRows[0].Cells["ID"].Value.ToString());
            string descMateria = txt_descMateria.Text;
            int hsSemanales = (int)nud_hsSemanales.Value;
            int hsTotales = (int)nud_hsTotales.Value;
            int idPlan = (int)nud_idPlan.Value;

            if (controller.modificarMateria(idMateria, descMateria, hsSemanales, hsTotales, idPlan))
            {
                MessageBox.Show("Materia modificada con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar la materia, intente nuevamente");
            }
            retrieveMaterias();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
