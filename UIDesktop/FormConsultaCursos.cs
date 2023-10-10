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
    public partial class FormConsultaCursos : Form
    {
        public FormConsultaCursos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_materia.Text = "Materia:";
            lbl_comision.Text = "Comision:";
            lbl_anioCalendario.Text = "Año Calendario:";
            lbl_cupo.Text = "Cupo:";
            if (nud_Id.Value != 0)
            {
                Curso curso = controller.cursoGetOne((int)nud_Id.Value);
                Materia materia = controller.materiaGetOne((int)curso.IdMateria);
                Comisione comision = controller.comisionGetOne((int)curso.IdComision);
                if (comision is null)
                {
                    ipb_Usuario.Visible = false;
                    panel1.Visible = false;
                    lbl_Id.Visible = false;
                    lbl_materia.Visible = false;
                    lbl_comision.Visible = false;
                    lbl_anioCalendario.Visible = false;
                    lbl_cupo.Visible = false;
                    MessageBox.Show("El plan ingresado no existe");
                }
                else
                {
                    lbl_Id.Text += " " + curso.IdCurso;
                    lbl_materia.Text += " " + materia.DescMateria;
                    lbl_comision.Text += " " + comision.DescComision;
                    lbl_anioCalendario.Text += " " + curso.AnioCalendario;
                    lbl_cupo.Text += " " + curso.Cupo;
                    ipb_Usuario.Visible = true;
                    panel1.Visible = true;
                    lbl_Id.Visible = true;
                    lbl_materia.Visible = true;
                    lbl_comision.Visible = true;
                    lbl_anioCalendario.Visible = true;
                    lbl_cupo.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
