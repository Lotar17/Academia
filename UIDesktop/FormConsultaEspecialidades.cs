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
    public partial class FormConsultaEspecialidades : Form
    {
        public FormConsultaEspecialidades()
        {
            InitializeComponent();
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como borrar o retroceso).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignora la tecla presionada.
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_DescEspecialidad.Text = "Descripción de la especialidad";
            if (txt_Id != null)
            {
                Especialidade especialidad = controller.especialidadGetOne(int.Parse(txt_Id.Text));
                if (especialidad.IdEspecialidad == 0)
                {
                    ipb_Usuario.Visible = false;
                    panel1.Visible = false;
                    lbl_Id.Visible = false;
                    lbl_DescEspecialidad.Visible = false;
                    MessageBox.Show("La especialidad ingresada no existe");
                }
                else
                {
                    lbl_Id.Text += " " + especialidad.IdEspecialidad;
                    lbl_DescEspecialidad.Text = especialidad.DescEspecialidad;
                    ipb_Usuario.Visible = true;
                    panel1.Visible = true;
                    lbl_Id.Visible = true;
                    lbl_DescEspecialidad.Visible = true;
                }

            }
        }

        private void lbl_DescEspecialidad_Click(object sender, EventArgs e)
        {

        }
    }
}
