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

namespace Academia
{
    public partial class FormBajaUsuario : Form
    {
        private int rowIndexToDelete;

        public FormBajaUsuario()
        {
            InitializeComponent();
            retrieveUsuarios();
        }

        private void retrieveUsuarios()
        {
            dtgv_BajaUsuario.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Usuario> usuarios = ctrlBaja.GetUsuarios();
            foreach (Usuario u in usuarios)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaUsuario.Rows.Add();
                dtgv_BajaUsuario.Rows[rowIndex].Cells["ID"].Value = u.Id;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["nombre_usuario"].Value = u.NombreUsuario;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["Habilitado"].Value = u.Habilitado;
            }
        }

        private void dtgv_BajaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexToDelete = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rowIndexToDelete >= 0)
            {
                int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
                Controller controller = new Controller();
                controller.borrarUsuario(idToDelete);
                retrieveUsuarios();
            }
        }
    }
}
