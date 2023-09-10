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
    public partial class frm_ConsultaUsuario : Form
    {
        public frm_ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como borrar o retroceso).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignora la tecla presionada.
                e.Handled = true;
            }
        }

        private void lbl_NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void frm_ConsultaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_IdPersona.Text = "ID de Persona:";
            lbl_NombreUsuario.Text = string.Empty;
            lbl_Habilitado.Text = string.Empty;
            if (txt_Id != null)
            {
                Usuario usuario = controller.usuarioGetOne(int.Parse(txt_Id.Text));
                if (usuario.Id == 0)
                {
                    ipb_Usuario.Visible = false;
                    panel1.Visible = false;
                    lbl_Id.Visible = false;
                    lbl_NombreUsuario.Visible = false;
                    lbl_Habilitado.Visible = false;
                    lbl_IdPersona.Visible = false;
                    MessageBox.Show("El usuario ingresado no existe");
                }
                else
                {
                    lbl_Id.Text += " " + usuario.Id;
                    lbl_NombreUsuario.Text = usuario.NombreUsuario;
                    if (usuario.Habilitado)
                    {
                        lbl_Habilitado.Text = "Habilitado";
                    }
                    else
                    {
                        lbl_Habilitado.Text = "No habilitado";
                    }
                    lbl_IdPersona.Text += " " + usuario.IdPersona;
                    ipb_Usuario.Visible = true;
                    panel1.Visible = true;
                    lbl_Id.Visible = true;
                    lbl_NombreUsuario.Visible = true;
                    lbl_Habilitado.Visible = true;
                    lbl_IdPersona.Visible = true;
                }
                
            }
        }
    }
}
