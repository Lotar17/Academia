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
    public partial class FormModificacionUsuarios : Form
    {
        public FormModificacionUsuarios()
        {
            InitializeComponent();
            retrieveUsuarios();

        }


        private void retrieveUsuarios()
        {
            dtgv_ModificacionUsuario.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<UsuarioADO> usuarios = ctrlBaja.getUsuarios();
            foreach (UsuarioADO u in usuarios)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_ModificacionUsuario.Rows.Add();
                dtgv_ModificacionUsuario.Rows[rowIndex].Cells["id_usuario"].Value = u.Id;
                dtgv_ModificacionUsuario.Rows[rowIndex].Cells["nombre_usuario"].Value = u.NombreUsuario;
                dtgv_ModificacionUsuario.Rows[rowIndex].Cells["habilitado"].Value = u.Habilitado;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_ModificacionUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_NombreUsuario.Text = dtgv_ModificacionUsuario.SelectedRows[0].Cells["nombre_usuario"].Value.ToString();
            if (dtgv_ModificacionUsuario.SelectedRows[0].Cells["habilitado"].Value.ToString() == "True")
            {
                cbx_Habilitado.SelectedItem = "Si";
            }
            else
            {
                cbx_Habilitado.SelectedItem = "No";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idUsuario = int.Parse(dtgv_ModificacionUsuario.SelectedRows[0].Cells["id_usuario"].Value.ToString());
            string nombreUsuario = txt_NombreUsuario.Text;
            int habilitado;
            if (cbx_Habilitado.Text == "Si")
            {
                habilitado = 1;
            }
            else
            {
                habilitado = 0;
            }
            if (controller.modificarUsuario(idUsuario, nombreUsuario, habilitado))
            {
                MessageBox.Show("Usuario modificado con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario, intente nuevamente");
            }
            retrieveUsuarios();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModificacionUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
