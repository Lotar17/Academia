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

namespace UIDesktop
{
    public partial class FormBajaEspecialidad : Form
    {
        public FormBajaEspecialidad()
        {
            InitializeComponent();
            retrieveEspecialidades();
        }

        private void retrieveEspecialidades()
        {
            dtgv_BajaEspecialidad.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Especialidade> especialidades = ctrlBaja.getEspecialidades();
            foreach (Especialidade e in especialidades)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaEspecialidad.Rows.Add();
                dtgv_BajaEspecialidad.Rows[rowIndex].Cells["ID"].Value = e.IdEspecialidad;
                dtgv_BajaEspecialidad.Rows[rowIndex].Cells["desc_especialidad"].Value = e.DescEspecialidad;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = (int)nud_IdToDelete.Value;
            Controller controller = new Controller();
            if (controller.especialidadGetOne(idToDelete) != null)
            {
                if (controller.getEspecialidadxPlan(idToDelete))
                {
                    controller.borrarEspecialidad(idToDelete);
                    MessageBox.Show("Especialidad borrada con exito");
                }
                else
                {
                    MessageBox.Show("Existen instancias de PLANES con el ID de ESPECIALIDAD a borrar.\n Por favor modifique esas instancias para poder borrar la especialidad.");
                }
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveEspecialidades();
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
