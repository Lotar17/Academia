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
    public partial class FormAltaPlan : Form
    {
        public FormAltaPlan()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_descPlan.Text != "")
            {
                Controller controller = new Controller();
                Plane plan = new Plane();
                plan.DescPlan = txt_descPlan.Text;
                plan.IdEspecialidad = (int)nud_idEspecialidad.Value;
                if (controller.especialidadGetOne((int)plan.IdEspecialidad) != null)
                {
                    if (controller.crearPlan(plan))
                    {
                        MessageBox.Show("Plan cargado con éxito");
                        txt_descPlan.Text = null;
                        nud_idEspecialidad.Value = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar el nuevo plan");
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no corresponde a ninguna especialidad");
                }

            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar un nuevo plan");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
