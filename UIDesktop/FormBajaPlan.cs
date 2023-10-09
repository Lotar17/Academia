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
    public partial class FormBajaPlan : Form
    {
        public FormBajaPlan()
        {
            InitializeComponent();
            retrievePlanes();
        }

        private void retrievePlanes()
        {
            dtgv_BajaPlan.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Plane> planes = ctrlBaja.getPlanes();
            foreach (Plane p in planes)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaPlan.Rows.Add();
                dtgv_BajaPlan.Rows[rowIndex].Cells["ID"].Value = p.IdPlan;
                dtgv_BajaPlan.Rows[rowIndex].Cells["desc_plan"].Value = p.DescPlan;
                dtgv_BajaPlan.Rows[rowIndex].Cells["idPlan"].Value = p.IdEspecialidad;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = int.Parse(txt_IdDelete.Text);
            Controller controller = new Controller();
            if (controller.borrarEspecialidad(idToDelete))
            {
                MessageBox.Show("Plan borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrievePlanes();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
