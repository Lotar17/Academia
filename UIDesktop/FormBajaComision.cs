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
    public partial class FormBajaComision : Form
    {
        public FormBajaComision()
        {
            InitializeComponent();
            retrieveComisiones();
        }

        private void retrieveComisiones()
        {
            dtgv_BajaComision.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Comisione> comisiones = ctrlBaja.getComisiones();
            foreach (Comisione c in comisiones)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaComision.Rows.Add();
                dtgv_BajaComision.Rows[rowIndex].Cells["ID"].Value = c.IdComision;
                dtgv_BajaComision.Rows[rowIndex].Cells["desc_comision"].Value = c.DescComision;
                dtgv_BajaComision.Rows[rowIndex].Cells["anioEspecialidad"].Value = c.AnioEspecialidad;
                dtgv_BajaComision.Rows[rowIndex].Cells["idPlan"].Value = c.IdPlan;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.comisionGetOne(idToDelete) != null)
            {
                if (controller.getComisionXCurso(idToDelete))
                {
                    controller.borrarComision(idToDelete);
                    MessageBox.Show("Comision borrada con exito");
                }
                else
                {
                    MessageBox.Show("Existen instancias de CURSOS con el ID de COMISION a borrar.\n Por favor modifique esas instancias para poder borrar la comision.");
                }
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveComisiones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
