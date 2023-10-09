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
    public partial class FormModificacionPlanes : Form
    {
        public FormModificacionPlanes()
        {
            InitializeComponent();
            retrievePlanes();
        }

        private void retrievePlanes()
        {
            dtgv_modificacionPlan.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Plane> planes = ctrlBaja.getPlanes();
            foreach (Plane p in planes)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_modificacionPlan.Rows.Add();
                dtgv_modificacionPlan.Rows[rowIndex].Cells["ID"].Value = p.IdPlan;
                dtgv_modificacionPlan.Rows[rowIndex].Cells["desc_plan"].Value = p.DescPlan;
                dtgv_modificacionPlan.Rows[rowIndex].Cells["idPlan"].Value = p.IdEspecialidad;
            }
        }

        private void dtgv_modificacionPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_descPlan.Text = dtgv_modificacionPlan.SelectedRows[0].Cells["desc_plan"].Value.ToString();
            txt_idPlan.Text = dtgv_modificacionPlan.SelectedRows[0].Cells["idPlan"].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idPlan = int.Parse(dtgv_modificacionPlan.SelectedRows[0].Cells["ID"].Value.ToString());
            string descPlan = txt_descPlan.Text;
            int idEspecialidad = int.Parse(txt_idPlan.Text);
            if (controller.modificarPlan(idPlan, descPlan, idEspecialidad))
            {
                MessageBox.Show("Plan modificado con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar el plan, intente nuevamente");
            }
            retrievePlanes();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
