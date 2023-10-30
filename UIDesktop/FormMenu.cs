using Entities;
using FontAwesome.Sharp;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using UIDesktop;

namespace Academia
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public FormMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);
        }

        private void Academia_Load(object sender, EventArgs e)          //carga los dropdown
        {
            loadUserData();
            DropdownUsuarios.IsMainMenu = true;
            DropdownAlumnos.IsMainMenu = true;
            DropdownEspecialidades.IsMainMenu = true;
            DropdownProfesores.IsMainMenu = true;
            DropdownPlanesYMaterias.IsMainMenu = true;
            DropdownComisiones.IsMainMenu = true;
            DropdownCursos.IsMainMenu = true;
        }

        private void ActivateButton(object senderBtn, Color color)      //efecto al presionar un boton del side menu
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()                                    //desabilita el efecto de algun boton que se haya tocado antes
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 11, 99);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownUsuarios.Show(btnMenuUsuarios, btnMenuUsuarios.Width, 0);
        }

        private void menuItemAltaUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaUsuario());
        }

        private void menuItemBajaUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaUsuario());
        }

        private void menuItemModificacionUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionUsuarios());
        }

        private void menuItemConsultaUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ConsultaUsuario());
        }

        private void btnMenuAlumnos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownAlumnos.Show(btnMenuAlumnos, btnMenuAlumnos.Width, 0);
        }

        private void menuItemAltaAlumnos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaAlumno());
        }

        private void menuItemBajaAlumnos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaAlumno());
        }

        private void menuItemModificacionAlumnos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionAlumnos());
        }

        private void menuItemConsultaAlumnos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaAlumnos());
        }

        private void btnMenuEspecialidades_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownEspecialidades.Show(btnMenuEspecialidades, btnMenuEspecialidades.Width, 0);
        }

        private void menuItemAltaEspecialidades_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaEspecialidad());
        }

        private void menuItemBajaEspecialidades_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaEspecialidad());
        }

        private void menuItemModificacionEspecialidades_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionEspecialidades());
        }

        private void menuItemConsultaEspecialidades_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaEspecialidades());
        }

        private void btnMenuProfesores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownProfesores.Show(btnMenuProfesores, btnMenuProfesores.Width, 0);
        }

        private void menuItemAltaProfesores_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaProfesor());
        }

        private void menuItemBajaProfesores_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaProfesor());
        }

        private void menuItemModificacionProfesores_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionProfesor());
        }

        private void menuItemConsultaProfesores_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaProfesor());
        }

        private void btnMenuPlanesYMaterias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownPlanesYMaterias.Show(btnMenuPlanesYMaterias, btnMenuPlanesYMaterias.Width, 0);
        }

        private void menuItemAltaPlanes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaPlan());
        }

        private void menuItemBajaPlanes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaPlan());
        }

        private void menuItemModificacionPlanes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionPlanes());
        }

        private void menuItemConsultaPlanes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaPlanes());
        }

        private void menuItemAltaMaterias_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaMateria());
        }

        private void menuItemBajaMaterias_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaMateria());
        }

        private void menuItemModificacionMaterias_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionMaterias());
        }

        private void menuItemConsultaMaterias_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaMaterias());
        }

        private void btnMenuComisiones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownComisiones.Show(btnMenuComisiones, btnMenuComisiones.Width, 0);
        }

        private void menuItemAltaComisiones_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaComision());
        }

        private void menuItemBajaComisiones_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaComision());
        }

        private void menuItemModificacionComisiones_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionComisiones());
        }

        private void menuItemConsultaComisiones_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaComisiones());
        }

        private void btnMenuCursos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            DropdownCursos.Show(btnMenuCursos, btnMenuCursos.Width, 0);
        }

        private void btnReporteCursos_Click(Object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
            openChildForm(new FormReporteCursos());
        }

        private void menuItemAltaCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaCurso());
        }

        private void menuItemBajaCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBajaCurso());
        }

        private void menuItemModificacionCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModificacionCursos());
        }

        private void menuItemConsultaCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormConsultaCursos());
        }

        private void btnLogout_Click(object Sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de que quieres cerrar sesion?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private Form activeForm;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void loadUserData()
        {
            lblNombreApellido.Text = UsuarioLoginCache._Apellido + ", " + UsuarioLoginCache._Nombre;
            lblEmail.Text = UsuarioLoginCache._Email;
            lblTipoUsuario.Text = "Tipo de usuario: " + UsuarioLoginCache._TipoUsuario;
            if (UsuarioLoginCache._TipoUsuario == "Alumno" || UsuarioLoginCache._TipoUsuario == "Profesor")
            {
                btnMenuUsuarios.Visible = false;
                btnMenuAlumnos.Visible = false;
                btnMenuEspecialidades.Visible = false;
                btnMenuProfesores.Visible = false;
                btnMenuPlanesYMaterias.Visible = false;
                btnMenuComisiones.Visible = false;
                btnMenuCursos.Visible = false;
            }
        }

        private void btnInscripcionACursos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInscripcionCursos());
        }
    }
}