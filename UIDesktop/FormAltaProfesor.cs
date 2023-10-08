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
    public partial class FormAltaProfesor : Form
    {
        public FormAltaProfesor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "" && txt_apellido.Text != "" && txt_direccion.Text != "" && txt_email.Text != "" && txt_telefono.Text != "" && txt_legajo.Text != "")
            {
                Controller altaProfesor = new Controller();
                Persona profesor = new Persona();
                profesor.Nombre = txt_nombre.Text;
                profesor.Apellido = txt_apellido.Text;
                profesor.Direccion = txt_direccion.Text;
                profesor.Email = txt_email.Text;
                profesor.Telefono = txt_telefono.Text;
                profesor.FechaNac = dtp_fechaNac.Value;
                profesor.Legajo = int.Parse(txt_legajo.Text);
                profesor.TipoPersona = "Docente";
                if (altaProfesor.crearProfesor(profesor))
                {
                    MessageBox.Show("Profesor cargado con éxito");
                    txt_nombre.Text = null;
                    txt_apellido.Text = null;
                    txt_direccion.Text = null;
                    txt_email.Text = null;
                    txt_telefono.Text = null;
                    dtp_fechaNac.Value = default;
                    txt_legajo.Text = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el nuevo profesor");
                }

            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar un nuevo profesor");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como borrar o retroceder).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número ni una tecla de control, se ignora.
                e.Handled = true;
            }
        }

        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
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
