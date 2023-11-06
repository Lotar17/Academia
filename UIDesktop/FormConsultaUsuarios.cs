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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            lbl_Id.Text = "ID:";
            lbl_IdPersona.Text = "ID de Persona:";
            lbl_NombreUsuario.Text = "Nombre de Usuario:";
            lbl_Habilitado.Text = "Estado:";
            UsuarioADO usuario = controller.usuarioGetOne((int)nud_Id.Value);
            if (usuario.IdPersona == 0)
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
                lbl_NombreUsuario.Text += " " + usuario.NombreUsuario;
                if (usuario.Habilitado)
                {
                    lbl_Habilitado.Text += " " + "Habilitado";
                }
                else
                {
                    lbl_Habilitado.Text += " " + "No habilitado";
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
