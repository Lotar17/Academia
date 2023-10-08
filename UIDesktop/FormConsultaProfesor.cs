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
    public partial class FormConsultaProfesor : Form
    {
        public FormConsultaProfesor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            if (txt_Id != null)
            {
                Persona profesor = controller.profesorGetOne(int.Parse(txt_Id.Text));
                if (profesor is null)
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
                    MessageBox.Show("El profesor ingresado no existe");
                }
                else
                {
                    lbl_Id.Text += " " + profesor.IdPersona;
                    lbl_nombreapellido.Text += " " + profesor.Nombre + " " + profesor.Apellido;
                    lbl_direccion.Text += " " + profesor.Direccion;
                    lbl_email.Text += " " + profesor.Email;
                    lbl_telefono.Text += " " + profesor.Telefono;
                    lbl_fechaNac.Text += " " + profesor.FechaNac;
                    lbl_legajo.Text += " " + profesor.Legajo;
                    ipb_Usuario.Visible = true;
                    panel1.Visible = true;
                    lbl_Id.Visible = true;
                    lbl_nombreapellido.Visible = true;
                    lbl_direccion.Visible = true;
                    lbl_email.Visible = true;
                    lbl_telefono.Visible = true;
                    lbl_fechaNac.Visible = true;
                    lbl_legajo.Visible = true;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
