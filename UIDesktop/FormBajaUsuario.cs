﻿using Dominio;
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
            LinkedList<UsuarioADO> usuarios = ctrlBaja.getUsuarios();
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
            int idToDelete = (int)nud_IdToDelete.Value;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
