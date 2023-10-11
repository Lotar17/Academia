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
            if (txt_nombre.Text != "" && txt_apellido.Text != "" && txt_direccion.Text != "" && txt_email.Text != "" && txt_telefono.Text != "" && nud_legajo.Text != "" && nud_idPlan.Text != "")
            {
                string mensaje = "";
                Controller controller = new Controller();
                Persona alumno = new Persona();
                alumno.Nombre = txt_nombre.Text;
                alumno.Apellido = txt_apellido.Text;
                alumno.Direccion = txt_direccion.Text;
                alumno.Email = txt_email.Text;
                alumno.Telefono = txt_telefono.Text;
                alumno.FechaNac = dtp_fechaNac.Value;
                alumno.Legajo = (int)nud_legajo.Value;
                alumno.IdPlan = (int)nud_idPlan.Value;
                alumno.TipoPersona = "Alumno";
                if (controller.planGetOne((int)alumno.IdPlan) == null || controller.alumnoGetOne((int)nud_legajo.Value) != null) //ver legajo
                {
                    if (controller.planGetOne((int)alumno.IdPlan) == null)
                    {
                        mensaje += "         El ID ingresado no corresponde a ningun plan.\n";
                    }
                    if (controller.alumnoGetOne((int)nud_legajo.Value) != null)
                    {
                        mensaje += "         El legajo ingresado ya existe para otro alumno.\n";
                    }
                    mensajeError(mensaje);
                }
                else
                {
                    if (controller.crearAlumno(alumno))
                    {
                        MessageBox.Show("Alumno cargado con éxito");
                        txt_nombre.Text = null;
                        txt_apellido.Text = null;
                        txt_direccion.Text = null;
                        txt_email.Text = null;
                        txt_telefono.Text = null;
                        dtp_fechaNac.Value = default;
                        nud_legajo.Text = null;
                        nud_idPlan.Text = null;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar el nuevo alumno");
                    }
                }
            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar un nuevo alumno");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
