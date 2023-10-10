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
    public partial class FormAltaComision : Form
    {
        public FormAltaComision()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_descComision.Text != "" && nud_anioEspecialidad.Value != 0 && nud_idPlan.Value != 0)
            {
                Controller controller = new Controller();
                Comisione comision = new Comisione();
                comision.DescComision = txt_descComision.Text;
                comision.AnioEspecialidad = (int)nud_anioEspecialidad.Value;
                comision.IdPlan = (int)nud_idPlan.Value;
                if (controller.planGetOne((int)comision.IdPlan) != null)
                {
                    if (controller.crearComision(comision))
                    {
                        MessageBox.Show("Comision cargada con éxito");
                        txt_descComision.Text = null;
                        nud_anioEspecialidad.Value = 0;
                        nud_idPlan.Value = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar la nueva comision");
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no corresponde a ningun plan");
                }
            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar una nueva comision");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
