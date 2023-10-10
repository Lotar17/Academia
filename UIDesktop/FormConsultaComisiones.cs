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
    public partial class FormConsultaComisiones : Form
    {
        public FormConsultaComisiones()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_descComision.Text = "Descripción de la comision:";
            lbl_anioEspecialidad.Text = "Año Especialidad:";
            lbl_plan.Text = "Plan:";
            if (nud_Id.Value != 0)
            {
                Comisione comision = controller.comisionGetOne((int)nud_Id.Value);
                Plane plan = controller.planGetOne((int)comision.IdPlan);
                if (comision is null)
                {
                    ipb_Usuario.Visible = false;
                    panel1.Visible = false;
                    lbl_Id.Visible = false;
                    lbl_descComision.Visible = false;
                    lbl_anioEspecialidad.Visible = false;
                    lbl_plan.Visible = false;
                    MessageBox.Show("El plan ingresado no existe");
                }
                else
                {
                    lbl_Id.Text += " " + comision.IdComision;
                    lbl_descComision.Text += " " + comision.DescComision;
                    lbl_anioEspecialidad.Text += " " + comision.AnioEspecialidad;
                    lbl_plan.Text += " " + plan.DescPlan;
                    ipb_Usuario.Visible = true;
                    panel1.Visible = true;
                    lbl_Id.Visible = true;
                    lbl_descComision.Visible = true;
                    lbl_anioEspecialidad.Visible = true;
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
