using Dominio;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class FormAltaCurso : Form
    {
        public FormAltaCurso()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (nud_idMateria.Value != 0 && nud_idComision.Value != 0 && nud_anioCalendario.Value != 0 && nud_cupo.Value != 0)
            {
                Controller controller = new Controller();
                Curso curso = new Curso();
                curso.IdMateria = (int)nud_idMateria.Value;
                curso.IdComision = (int)nud_idComision.Value;
                curso.AnioCalendario = (int)nud_anioCalendario.Value;
                curso.Cupo = (int)nud_cupo.Value;
                if (controller.materiaGetOne((int)curso.IdMateria) == null || controller.comisionGetOne((int)nud_idComision.Value) == null)
                {
                    if (controller.comisionGetOne((int)nud_idComision.Value) == null)
                    {
                        mensaje += "         El ID ingresado no corresponde a ninguna comision.\n";
                    }
                    if (controller.materiaGetOne((int)curso.IdMateria) == null)
                    {
                        mensaje += "         El ID ingresado no corresponde a ninguna materia.\n";
                    }
                    mensajeError(mensaje);
                }
                else
                {
                    if (controller.crearCurso(curso))
                    {
                        MessageBox.Show("Curso cargado con éxito");
                        nud_idMateria.Value = 0;
                        nud_idComision.Value = 0;
                        nud_anioCalendario.Value = 0;
                        nud_cupo.Value = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar el nuevo plan");
                    }
                }
            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar un nuevo plan");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = mensaje;
            lblMensajeError.Visible = true;
        }
    }
}


