using Academia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Dominio;

namespace AcademiaDesktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario")
            {
                if (txtPass.Text != "Contraseña")
                {
                    UsuarioModelo usuario = new UsuarioModelo();
                    var loginValido = usuario.LoginUsuario(txtUser.Text, txtPass.Text);
                    if (loginValido)
                    {
                        FormMenu menu = new FormMenu();
                        menu.Show();
                        menu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        mensajeError("Nombre de usuario o contraseña incorrecta \n      Por favor intente de nuevo");
                        txtPass.Text = "Contraseña";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                }
                else
                {
                    mensajeError("Por favor ingrese una contraseña");
                }
            }
            else
            {
                mensajeError("Por favor ingrese un usuario");
            }
        }

        private void mensajeError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;
            lblMensajeError.Visible = true;
        }

        private void Logout(object Sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Contraseña";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "Usuario";
            lblMensajeError.Visible = false;
            this.Show();
            txtUser.Focus();
        }
    }
}
