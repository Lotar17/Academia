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
    public partial class FormModificacionCursos : Form
    {
        public FormModificacionCursos()
        {
            InitializeComponent();
            retrieveCursos();
        }

        private void retrieveCursos()
        {
            dtgv_modificacionCursos.Rows.Clear();
            Controller ctrlModificacion = new Controller();
            LinkedList<Curso> cursos = ctrlModificacion.getCursos();
            foreach (Curso c in cursos)
            {
                // Agrega una nueva fila al DataGridView y obtiene su índice
                int rowIndex = dtgv_modificacionCursos.Rows.Add();
                dtgv_modificacionCursos.Rows[rowIndex].Cells["ID"].Value = c.IdCurso;
                dtgv_modificacionCursos.Rows[rowIndex].Cells["idMateria"].Value = c.IdMateria;
                dtgv_modificacionCursos.Rows[rowIndex].Cells["idComision"].Value = c.IdComision;
                dtgv_modificacionCursos.Rows[rowIndex].Cells["anioCalendario"].Value = c.AnioCalendario;
                dtgv_modificacionCursos.Rows[rowIndex].Cells["cupo"].Value = c.Cupo;
            }
        }

        private void dtgv_modificacionCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nud_idMateria.Value = int.Parse(dtgv_modificacionCursos.SelectedRows[0].Cells["idMateria"].Value.ToString());
            nud_idComision.Value = int.Parse(dtgv_modificacionCursos.SelectedRows[0].Cells["idComision"].Value.ToString());
            nud_anioCalendario.Value = int.Parse(dtgv_modificacionCursos.SelectedRows[0].Cells["anioCalendario"].Value.ToString());
            nud_cupo.Value = int.Parse(dtgv_modificacionCursos.SelectedRows[0].Cells["cupo"].Value.ToString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            Controller controller = new Controller();
            int idCurso = int.Parse(dtgv_modificacionCursos.SelectedRows[0].Cells["ID"].Value.ToString());
            int idMateria = (int)nud_idMateria.Value;
            int idComision = (int)nud_idComision.Value;
            int anioCalendario = (int)nud_anioCalendario.Value;
            int cupo = (int)nud_cupo.Value;
            if (controller.materiaGetOne(idMateria) == null || controller.comisionGetOne(idComision) == null)
            {
                if (controller.comisionGetOne(idComision) == null)
                {
                    mensaje += "         El ID ingresado no corresponde a ninguna comision.\n";
                }
                if (controller.materiaGetOne(idMateria) == null)
                {
                    mensaje += "         El ID ingresado no corresponde a ninguna materia.\n";
                }
                mensajeError(mensaje);
            }
            else
            {
                if (controller.modificarCurso(idCurso, idMateria, idComision, anioCalendario, cupo))
                {
                    MessageBox.Show("Curso modificado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al modificar la comision, intente nuevamente");
                }
                retrieveCursos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
