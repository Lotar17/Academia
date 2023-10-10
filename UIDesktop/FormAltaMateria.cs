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
    public partial class FormAltaMateria : Form
    {
        public FormAltaMateria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_descMateria.Text != "" && nud_hsSemanales.Value != 0 && nud_horasTotales.Value != 0)
            {
                Controller controller = new Controller();
                Materia materia = new Materia();
                materia.DescMateria = txt_descMateria.Text;
                materia.HsTotales = (int)nud_horasTotales.Value;
                materia.HsSemanales = (int)nud_hsSemanales.Value;
                materia.IdPlan = (int)nud_idPlan.Value;
                if (controller.planGetOne((int)materia.IdPlan) != null)
                {
                    if (controller.crearMateria(materia))
                    {
                        MessageBox.Show("Materia cargada con éxito");
                        txt_descMateria.Text = null;
                        nud_horasTotales.Value = 0;
                        nud_hsSemanales.Value = 0;
                        nud_idPlan.Value = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar la nueva materia");
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no corresponde a ningun plan");
                }
            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar una nueva materia");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
