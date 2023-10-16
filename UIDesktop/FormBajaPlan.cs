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
                // Agrega una nueva fila al DataGridView y obtiene su índiceS
                int rowIndex = dtgv_BajaPlan.Rows.Add();
                dtgv_BajaPlan.Rows[rowIndex].Cells["ID"].Value = p.IdPlan;
                dtgv_BajaPlan.Rows[rowIndex].Cells["desc_especialidad"].Value = p.DescPlan;
                dtgv_BajaPlan.Rows[rowIndex].Cells["idEspecialidad"].Value = p.IdEspecialidad;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.getPlanxPersona(idToDelete))
            {
                MessageBox.Show("Existen instancias de PERSONAS con el ID de PLAN a borrar.\nPor favor modifique esas instancias para poder borrar el plan.");
            }
            else if (controller.getPlanxMateria(idToDelete))
            {
                MessageBox.Show("Existen instancias de MATERIAS con el ID de PLAN a borrar.\nPor favor modifique esas instancias para poder borrar el plan.");
            }
            else if (controller.getPlanxComision(idToDelete))
            {
                MessageBox.Show("Existen instancias de COMISIONES con el ID de PLAN a borrar.\nPor favor modifique esas instancias para poder borrar el plan.");
            }
            else if (controller.planGetOne(idToDelete) != null)
            {
                controller.borrarPlan(idToDelete);
                MessageBox.Show("Plan borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrievePlanes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
