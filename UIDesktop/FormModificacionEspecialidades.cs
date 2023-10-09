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
    public partial class FormModificacionEspecialidades : Form
    {
        public FormModificacionEspecialidades()
        {
            InitializeComponent();
            retrieveEspecialidades();
        }

        private void retrieveEspecialidades()
        {
            dtgv_ModificacionEspecialidad.Rows.Clear();
            Controller ctrlModificacion = new Controller();
            LinkedList<Especialidade> especialidades = ctrlModificacion.getEspecialidades();
            foreach (Especialidade e in especialidades)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_ModificacionEspecialidad.Rows.Add();
                dtgv_ModificacionEspecialidad.Rows[rowIndex].Cells["ID"].Value = e.IdEspecialidad;
                dtgv_ModificacionEspecialidad.Rows[rowIndex].Cells["desc_especialidad"].Value = e.DescEspecialidad;
            }
        }

        private void dtgv_ModificacionEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_DescEspecialidad.Text = dtgv_ModificacionEspecialidad.SelectedRows[0].Cells["desc_especialidad"].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idEspecialidad = int.Parse(dtgv_ModificacionEspecialidad.SelectedRows[0].Cells["ID"].Value.ToString());
            string descEspecialidad = txt_DescEspecialidad.Text;
            if (controller.modificarEspecialidad(idEspecialidad, descEspecialidad))
            {
                MessageBox.Show("Especialidad modificada con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar la especialidad, intente nuevamente");
            }
            retrieveEspecialidades();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
