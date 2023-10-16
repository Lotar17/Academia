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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_DescEspecialidad.Text = "Descripción de la especialidad:";
            Especialidade especialidad = controller.especialidadGetOne((int)nud_Id.Value);
            if (especialidad is null)
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
                lbl_DescEspecialidad.Text += " " + especialidad.DescEspecialidad;
                ipb_Usuario.Visible = true;
                panel1.Visible = true;
                lbl_Id.Visible = true;
                lbl_DescEspecialidad.Visible = true;
            }
        }
    }
}
