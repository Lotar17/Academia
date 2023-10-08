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
    public partial class FormAltaAlumno : Form
    {
        public FormAltaAlumno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "" && txt_apellido.Text != "" && txt_direccion.Text != "" && txt_email.Text != "" && txt_telefono.Text != "" && txt_legajo.Text != "" && txt_idPlan.Text != "")
            {
                Controller altaAlumno = new Controller();
                Persona alumno = new Persona();
                alumno.Nombre = txt_nombre.Text;
                alumno.Apellido = txt_apellido.Text;
                alumno.Direccion = txt_direccion.Text;
                alumno.Email = txt_email.Text;
                alumno.Telefono = txt_telefono.Text;
                alumno.FechaNac = dtp_fechaNac.Value;
                alumno.Legajo = int.Parse(txt_legajo.Text);
                alumno.IdPlan = int.Parse(txt_idPlan.Text);
                alumno.TipoPersona = "Alumno";
                if (altaAlumno.crearAlumno(alumno))
                {
                    MessageBox.Show("Alumno cargado con éxito");
                    txt_nombre.Text = null;
                    txt_apellido.Text = null;
                    txt_direccion.Text = null;
                    txt_email.Text = null;
                    txt_telefono.Text = null;
                    dtp_fechaNac.Value = default;
                    txt_legajo.Text = null;
                    txt_idPlan.Text = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el nuevo alumno");
                }

            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar un nuevo alumno");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
