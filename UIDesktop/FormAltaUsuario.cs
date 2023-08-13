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
    public partial class FormAltaUsuario : Form
    {
        public FormAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var nuevo = false;
            if (txt_Name.Text is not null && txt_lastName.Text is not null && txt_userName.Text is not null && txt_Email.Text is not null && txt_idPersona.Text is not null && txt_pass.Text is not null && cbx_Habilitado.Text is not null)
            {
                Controller controller = new Controller();
                if (controller.verificarUsuario(int.Parse(txt_idPersona.Text)))
                {
                    mensajeError("Ya hay un usuario que tiene esa persona asignada");
                }
                else if (controller.verificarPersona(int.Parse(txt_idPersona.Text)) is false)
                {
                    mensajeError("El id de persona ingresado no corresponde a ninguna persona");
                }
                else
                {
                    if (cbx_Habilitado.Text == "Si")
                    {
                        Usuario usuario = new Usuario(txt_lastName.Text, txt_pass.Text, txt_Email.Text, true, txt_Name.Text, txt_userName.Text);
                        nuevo = controller.newUser(usuario, int.Parse(txt_idPersona.Text));
                    }
                    else
                    {
                        Usuario usuario = new Usuario(txt_lastName.Text, txt_pass.Text, txt_Email.Text, false, txt_Name.Text, txt_userName.Text);
                        nuevo = controller.newUser(usuario, int.Parse(txt_idPersona.Text));
                    }
                    if (nuevo)
                    {
                        MessageBox.Show("Usuario cargado con exito");
                        txt_Name.Text = txt_pass.Text = txt_userName.Text = txt_lastName.Text = txt_Email.Text = cbx_Habilitado.Text = txt_idPersona.Text = null;
                    }
                }
            }
            else
            {
                mensajeError("Debe llenar todos los campos para ingresar un nuevo usuario");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
