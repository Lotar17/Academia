using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

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
            if (txt_Name is not null && txt_lastName is not null && txt_userName is not null && txt_Email is not null && txt_idPersona is not null && txt_pass is not null) 
            {
               Controller controller = new Controller();
               if (controller.verificarUsuario(int.Parse(txt_idPersona.Text)))
               {
                    mensaje
               }
            }
        }
    }
}
