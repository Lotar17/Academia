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
    public partial class FormConsultaPlanes : Form
    {
        public FormConsultaPlanes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_descPlan.Text = "Descripción del plan:";
            lbl_especialidad.Text = "Especialidad:";
            Plane plan = controller.planGetOne((int)nud_Id.Value);
            if (plan is null)
            {
                ipb_Usuario.Visible = false;
                panel1.Visible = false;
                lbl_Id.Visible = false;
                lbl_descPlan.Visible = false;
                lbl_especialidad.Visible = false;
                MessageBox.Show("El plan ingresado no existe");
            }
            else
            {
                lbl_Id.Text += " " + plan.IdEspecialidad;
                lbl_descPlan.Text += " " + plan.DescPlan;
                lbl_especialidad.Text += " " + plan.IdEspecialidad;
                ipb_Usuario.Visible = true;
                panel1.Visible = true;
                lbl_Id.Visible = true;
                lbl_descPlan.Visible = true;
                lbl_especialidad.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
