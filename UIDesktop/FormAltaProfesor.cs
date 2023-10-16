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
            if (txt_nombre.Text != "" && txt_apellido.Text != "" && txt_direccion.Text != "" && txt_email.Text != "" && txt_telefono.Text != "")
            {
                Controller altaProfesor = new Controller();
                Persona profesor = new Persona();
                profesor.Nombre = txt_nombre.Text;
                profesor.Apellido = txt_apellido.Text;
                profesor.Direccion = txt_direccion.Text;
                profesor.Email = txt_email.Text;
                profesor.Telefono = txt_telefono.Text;
                profesor.FechaNac = dtp_fechaNac.Value;
                profesor.Legajo = (int)nud_Id.Value;
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
                    nud_Id.Value = 0;
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
    }
}
