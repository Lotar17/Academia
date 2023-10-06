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

        public FormBajaUsuario()
        {
            InitializeComponent();
            retrieveUsuarios();
        }

        private void retrieveUsuarios()
        {
            dtgv_BajaUsuario.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<UsuarioADO> usuarios = ctrlBaja.GetUsuarios();
            foreach (UsuarioADO u in usuarios)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaUsuario.Rows.Add();
                dtgv_BajaUsuario.Rows[rowIndex].Cells["ID"].Value = u.Id;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["nombre_usuario"].Value = u.NombreUsuario;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["Habilitado"].Value = u.Habilitado;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = int.Parse(txt_IdDelete.Text);
            Controller controller = new Controller();
            if (controller.borrarUsuario(idToDelete))
            {
                MessageBox.Show("Usuario borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveUsuarios();
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
