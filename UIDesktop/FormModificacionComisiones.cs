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
    public partial class FormModificacionComisiones : Form
    {
        public FormModificacionComisiones()
        {
            InitializeComponent();
            retrieveComisiones();
        }

        private void retrieveComisiones()
        {
            dtgv_modificacionComision.Rows.Clear();
            Controller ctrlModificacion = new Controller();
            LinkedList<Comisione> comisiones = ctrlModificacion.getComisiones();
            foreach (Comisione c in comisiones)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_modificacionComision.Rows.Add();
                dtgv_modificacionComision.Rows[rowIndex].Cells["ID"].Value = c.IdComision;
                dtgv_modificacionComision.Rows[rowIndex].Cells["desc_comision"].Value = c.DescComision;
                dtgv_modificacionComision.Rows[rowIndex].Cells["anioEspecialidad"].Value = c.AnioEspecialidad;
                dtgv_modificacionComision.Rows[rowIndex].Cells["id_plan"].Value = c.IdPlan;
            }
        }

        private void dtgv_modificacionPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_descComision.Text = dtgv_modificacionComision.SelectedRows[0].Cells["desc_materia"].Value.ToString();
            nud_anioEspecialidad.Value = int.Parse(dtgv_modificacionComision.SelectedRows[0].Cells["hsSemanales"].Value.ToString());
            nud_idPlan.Value = int.Parse(dtgv_modificacionComision.SelectedRows[0].Cells["id_plan"].Value.ToString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idComision = int.Parse(dtgv_modificacionComision.SelectedRows[0].Cells["ID"].Value.ToString());
            string descComision = txt_descComision.Text;
            int anioEspecialidad = (int)nud_anioEspecialidad.Value;
            int idPlan = (int)nud_idPlan.Value;
            if (controller.modificarComision(idComision, descComision, anioEspecialidad, idPlan))
            {
                MessageBox.Show("Comision modificada con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar la comision, intente nuevamente");
            }
            retrieveComisiones();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
