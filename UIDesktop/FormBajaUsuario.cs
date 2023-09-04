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

namespace Academia
{
    public partial class FormBajaUsuario : Form
    {
        public FormBajaUsuario()
        {
            InitializeComponent();
            Controller ctrlBaja = new Controller();
            dtgv_BajaUsuario.DataSource = ctrlBaja.GetUsuarios;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
