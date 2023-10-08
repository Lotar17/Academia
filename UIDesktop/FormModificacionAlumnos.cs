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
    public partial class FormModificacionAlumnos : Form
    {
        public FormModificacionAlumnos()
        {
            InitializeComponent();
            retrieveAlumnos();
        }

        private void FormModificacionAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void retrieveAlumnos()
        {
            dtgv_ModificacionAlumnos.Rows.Clear();
            Controller ctrlModificacion = new Controller();
            LinkedList<Persona> alumnos = ctrlModificacion.getAlumnos();
            foreach (Persona p in alumnos)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_ModificacionAlumnos.Rows.Add();
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["ID"].Value = p.IdPersona;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["nombre"].Value = p.Nombre;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["apellido"].Value = p.Apellido;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["direccion"].Value = p.Direccion;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["email"].Value = p.Email;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["telefono"].Value = p.Telefono;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["fecha_nac"].Value = p.FechaNac;
                dtgv_ModificacionAlumnos.Rows[rowIndex].Cells["legajo"].Value = p.Legajo;

            }
            txt_nombre.Text = txt_apellido.Text = txt_direccion.Text = txt_email.Text = txt_legajo.Text = txt_telefono.Text = dtp_fechaNac.Text = null;
            dtp_fechaNac.Value = DateTime.MinValue;
            dtgv_ModificacionAlumnos.SelectedRows.Clear();
        }

        private void dtgv_ModificacionAlumnnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["nombre"].Value.ToString();
            txt_apellido.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["apellido"].Value.ToString();
            txt_direccion.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["direccion"].Value.ToString();
            txt_email.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["email"].Value.ToString();
            txt_telefono.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["telefono"].Value.ToString();
            dtp_fechaNac.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["fecha_nac"].Value.ToString();
            txt_legajo.Text = dtgv_ModificacionAlumnos.SelectedRows[0].Cells["legajo"].Value.ToString();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            int idAlumno = int.Parse(dtgv_ModificacionAlumnos.SelectedRows[0].Cells["ID"].Value.ToString());
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string direccion = txt_direccion.Text;
            string email = txt_email.Text;
            string telefono = txt_telefono.Text;
            DateTime fecha_nac = dtp_fechaNac.Value;
            int legajo = int.Parse(txt_legajo.Text);
            if (controller.modificarAlumno(idAlumno, nombre, apellido, direccion, email, telefono, fecha_nac, legajo))
            {
                MessageBox.Show("Alumno modificado con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar el alumno, intente nuevamente");
            }
            retrieveAlumnos();

        }

    }
}
