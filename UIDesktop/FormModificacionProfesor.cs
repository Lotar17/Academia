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
    public partial class FormModificacionProfesor : Form
    {
        public FormModificacionProfesor()
        {
            InitializeComponent();
            retrieveProfesores();
        }


        private void retrieveProfesores()
        {
            dtgv_ModificacionProfesores.Rows.Clear();
            Controller ctrlModificacion = new Controller();
            LinkedList<Persona> profesores = ctrlModificacion.getProfesores();
            foreach (Persona p in profesores)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_ModificacionProfesores.Rows.Add();
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["ID"].Value = p.IdPersona;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["nombre"].Value = p.Nombre;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["apellido"].Value = p.Apellido;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["direccion"].Value = p.Direccion;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["email"].Value = p.Email;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["telefono"].Value = p.Telefono;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["fecha_nac"].Value = p.FechaNac;
                dtgv_ModificacionProfesores.Rows[rowIndex].Cells["legajo"].Value = p.Legajo;

            }
            txt_nombre.Text = txt_apellido.Text = txt_direccion.Text = txt_email.Text = txt_legajo.Text = txt_telefono.Text = dtp_fechaNac.Text = null;
        }

        private void dtgv_ModificacionProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["nombre"].Value.ToString();
            txt_apellido.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["apellido"].Value.ToString();
            txt_direccion.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["direccion"].Value.ToString();
            txt_email.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["email"].Value.ToString();
            txt_telefono.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["telefono"].Value.ToString();
            dtp_fechaNac.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["fecha_nac"].Value.ToString();
            txt_legajo.Text = dtgv_ModificacionProfesores.SelectedRows[0].Cells["legajo"].Value.ToString();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idProfesor = int.Parse(dtgv_ModificacionProfesores.SelectedRows[0].Cells["ID"].Value.ToString());
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string direccion = txt_direccion.Text;
            string email = txt_email.Text;
            string telefono = txt_telefono.Text;
            DateTime fecha_nac = dtp_fechaNac.Value;
            int legajo = int.Parse(txt_legajo.Text);
            if (controller.modificarProfesor(idProfesor, nombre, apellido, direccion, email, telefono, fecha_nac, legajo))
            {
                MessageBox.Show("Profesor modificado con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar el profesor, intente nuevamente");
            }
            retrieveProfesores();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como borrar o retroceder).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número ni una tecla de control, se ignora.
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
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
