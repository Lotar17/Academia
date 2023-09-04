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
            Controller ctrlBaja = new Controller();
            LinkedList<Usuario> usuarios = ctrlBaja.GetUsuarios();
            foreach (Usuario u in usuarios)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaUsuario.Rows.Add();
                dtgv_BajaUsuario.Rows[rowIndex].Cells["ID"].Value = u.Id;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["nombre_usuario"].Value = u.NombreUsuario;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["Habilitado"].Value = u.Habilitado;
                dtgv_BajaUsuario.Rows[rowIndex].Cells["id_persona"].Value = u.IdPersona;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
