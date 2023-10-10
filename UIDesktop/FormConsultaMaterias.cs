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
    public partial class FormConsultaMaterias : Form
    {
        public FormConsultaMaterias()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_descMateria.Text = "Descripción de la materia:";
            lbl_hsTotales.Text = "Horas totales:";
            lbl_hsSemanales.Text = "Horas semanales:";
            lbl_plan.Text = "Plan:";
            if (nud_Id.Value != 0)
            {
                Materia materia = controller.materiaGetOne((int)nud_Id.Value);
                Plane plan = controller.planGetOne((int)materia.IdPlan);
                if (materia is null)
                {
                    ipb_Usuario.Visible = false;
                    panel1.Visible = false;
                    lbl_Id.Visible = false;
                    lbl_descMateria.Visible = false;
                    lbl_hsTotales.Visible = false;
                    lbl_hsSemanales.Visible = false;
                    lbl_plan.Visible = false;
                    MessageBox.Show("La materia ingresada no existe");
                }
                else
                {
                    lbl_Id.Text += " " + materia.IdMateria;
                    lbl_descMateria.Text += " " + materia.DescMateria;
                    lbl_hsTotales.Text += " " + materia.HsTotales + "hs.";
                    lbl_hsSemanales.Text += " " + materia.HsSemanales + "hs.";
                    lbl_plan.Text += " " + plan.DescPlan;
                    ipb_Usuario.Visible = true;
                    panel1.Visible = true;
                    lbl_Id.Visible = true;
                    lbl_descMateria.Visible = true;
                    lbl_hsTotales.Visible = true;
                    lbl_hsSemanales.Visible = true;
                    lbl_plan.Visible = true;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
