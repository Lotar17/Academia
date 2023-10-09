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
            if (txt_Id != null)
            {
                Plane plan = controller.planGetOne(int.Parse(txt_Id.Text));
                if (plan.IdEspecialidad == 0)
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
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
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
