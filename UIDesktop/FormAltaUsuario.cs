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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var nuevo = false;
            if (txt_userName.Text != "" && txt_idPersona.Text != "" && txt_pass.Text != "" && cbx_Habilitado.Text != "")
            {
                Controller controller = new Controller();
                if (controller.verificarUsuarioPersona(int.Parse(txt_idPersona.Text)))
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
                        UsuarioADO usuario = new UsuarioADO(txt_pass.Text, true, txt_userName.Text);
                        nuevo = controller.crearUsuario(usuario, int.Parse(txt_idPersona.Text));
                    }
                    else
                    {
                        UsuarioADO usuario = new UsuarioADO(txt_pass.Text, false, txt_userName.Text);
                        nuevo = controller.crearUsuario(usuario, int.Parse(txt_idPersona.Text));
                    }
                    if (nuevo)
                    {
                        MessageBox.Show("Usuario cargado con exito");
                        txt_pass.Text = txt_userName.Text = cbx_Habilitado.Text = txt_idPersona.Text = null;
                        this.Close();
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

    }
}
