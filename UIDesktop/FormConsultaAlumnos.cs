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
    public partial class FormConsultaAlumnos : Form
    {
        public FormConsultaAlumnos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Persona alumno = controller.alumnoGetOne((int)nud_IdToDelete.Value);
            lbl_Id.Text = "ID:";
            lbl_nombreapellido.Text = "Nombre y Apellido:";
            lbl_direccion.Text = "Direccion:";
            lbl_email.Text = "Email:";
            lbl_telefono.Text = "Telefono:";
            lbl_fechaNac.Text = "Fecha de Nacimiento:";
            lbl_legajo.Text = "Legajo:";
            lbl_plan.Text = "Plan:";
            if (alumno is null)
            {
                ipb_Usuario.Visible = false;
                panel1.Visible = false;
                lbl_Id.Visible = false;
                lbl_nombreapellido.Visible = false;
                lbl_direccion.Visible = false;
                lbl_email.Visible = false;
                lbl_fechaNac.Visible = false;
                lbl_legajo.Visible = false;
                lbl_telefono.Visible = false;
                lbl_plan.Visible = false;
                MessageBox.Show("El alumno ingresado no existe");
            }
            else
            {
                Plane plan = controller.planGetOne((int)alumno.IdPlan);
                lbl_Id.Text += " " + alumno.IdPersona;
                lbl_nombreapellido.Text += " " + alumno.Nombre + " " + alumno.Apellido;
                lbl_direccion.Text += " " + alumno.Direccion;
                lbl_email.Text += " " + alumno.Email;
                lbl_telefono.Text += " " + alumno.Telefono;
                lbl_fechaNac.Text += " " + alumno.FechaNac;
                lbl_legajo.Text += " " + alumno.Legajo;
                lbl_plan.Text += " " + plan.DescPlan;
                ipb_Usuario.Visible = true;
                panel1.Visible = true;
                lbl_Id.Visible = true;
                lbl_nombreapellido.Visible = true;
                lbl_direccion.Visible = true;
                lbl_email.Visible = true;
                lbl_telefono.Visible = true;
                lbl_fechaNac.Visible = true;
                lbl_legajo.Visible = true;
                lbl_plan.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
