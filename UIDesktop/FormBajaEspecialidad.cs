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
    public partial class FormBajaEspecialidad : Form
    {

        private int rowIndexToDelete;

        public FormBajaEspecialidad()
        {
            InitializeComponent();
            retrieveEspecialidades();
        }

        private void retrieveEspecialidades()
        {
            dtgv_BajaEspecialidad.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Especialidade> especialidades = ctrlBaja.GetEspecialidades();
            foreach (Especialidade e in especialidades)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaEspecialidad.Rows.Add();
                dtgv_BajaEspecialidad.Rows[rowIndex].Cells["ID"].Value = e.IdEspecialidad;
                dtgv_BajaEspecialidad.Rows[rowIndex].Cells["desc_especialidad"].Value = e.DescEspecialidad;
            }
        }

        private void dtgv_BajaEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexToDelete = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rowIndexToDelete >= 0)
            {
                // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
                int idToDelete = int.Parse(txt_IdDelete.Text);
                Controller controller = new Controller();
                if (controller.borrarEspecialidad(idToDelete))
                {
                    MessageBox.Show("Especialidad borrada con exito");
                }
                else
                {
                    MessageBox.Show("El ID ingresado no existe");
                }
                retrieveEspecialidades();
            }
        }

        private void txt_IdDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como borrar o retroceso).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignora la tecla presionada.
                e.Handled = true;
            }
        }

    }
}
