using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entities;

namespace Academia
{
    public partial class FormAltaEspecialidad : Form
    {
        public FormAltaEspecialidad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_descEspecialidad.Text != "")
            {
                Controller controller = new Controller();
                Especialidade especialidad = new Especialidade();
                especialidad.DescEspecialidad = txt_descEspecialidad.Text;
                if (controller.crearEspecialidad(especialidad))
                {
                    MessageBox.Show("Especialidad cargada con éxito");
                    txt_descEspecialidad.Text = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la nueva especialidad");
                }

            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar una nueva especialidad");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
