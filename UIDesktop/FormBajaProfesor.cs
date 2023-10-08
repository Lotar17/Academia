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
    public partial class FormBajaProfesor : Form
    {
        public FormBajaProfesor()
        {
            InitializeComponent();
            retrieveProfesores();
        }


        private void retrieveProfesores()
        {
            dtgv_BajaProfesor.Rows.Clear();
            Controller ctrlBaja = new Controller();
            LinkedList<Persona> profesores = ctrlBaja.getProfesores();
            foreach (Persona p in profesores)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_BajaProfesor.Rows.Add();
                dtgv_BajaProfesor.Rows[rowIndex].Cells["ID"].Value = p.IdPersona;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["nombre"].Value = p.Nombre;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["apellido"].Value = p.Apellido;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["direccion"].Value = p.Direccion;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["email"].Value = p.Email;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["telefono"].Value = p.Telefono;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["fechaNac"].Value = p.FechaNac;
                dtgv_BajaProfesor.Rows[rowIndex].Cells["legajo"].Value = p.Legajo;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int idToDelete = (int)dtgv_BajaUsuario.Rows[rowIndexToDelete].Cells["ID"].Value;
            int idToDelete = int.Parse(txt_IdDelete.Text);
            Controller controller = new Controller();
            if (controller.borrarProfesor(idToDelete))
            {
                MessageBox.Show("Profesor borrado con exito");
            }
            else
            {
                MessageBox.Show("El ID ingresado no existe");
            }
            retrieveProfesores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_IdDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como borrar o retroceder).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número ni una tecla de control, se ignora.
                e.Handled = true;
            }
        }
    }
}
