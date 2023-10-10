namespace Academia
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelSideMenu = new Panel();
            btnReporteCursos = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnMenuCursos = new FontAwesome.Sharp.IconButton();
            btnMenuComisiones = new FontAwesome.Sharp.IconButton();
            btnMenuPlanesYMaterias = new FontAwesome.Sharp.IconButton();
            btnMenuProfesores = new FontAwesome.Sharp.IconButton();
            btnMenuEspecialidades = new FontAwesome.Sharp.IconButton();
            btnMenuAlumnos = new FontAwesome.Sharp.IconButton();
            btnMenuUsuarios = new FontAwesome.Sharp.IconButton();
            Logo = new PictureBox();
            panelChildForm = new Panel();
            logoCentral = new PictureBox();
            DropdownUsuarios = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            menuItemAltaUsuarios = new ToolStripMenuItem();
            menuItemBajaUsuarios = new ToolStripMenuItem();
            menuItemModificacionUsuarios = new ToolStripMenuItem();
            menuItemConsultaUsuarios = new ToolStripMenuItem();
            DropdownAlumnos = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            menuItemAltaAlumnos = new ToolStripMenuItem();
            menuItemBajaAlumnos = new ToolStripMenuItem();
            menuItemModificacionAlumnos = new ToolStripMenuItem();
            menuItemConsultaAlumnos = new ToolStripMenuItem();
            DropdownEspecialidades = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            menuItemAltaEspecialidades = new ToolStripMenuItem();
            menuItemBajaEspecialidades = new ToolStripMenuItem();
            menuItemModificacionEspecialidades = new ToolStripMenuItem();
            menuItemConsultaEspecialidades = new ToolStripMenuItem();
            DropdownProfesores = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            menuItemAltaProfesores = new ToolStripMenuItem();
            menuItemBajaProfesores = new ToolStripMenuItem();
            menuItemModificacionProfesores = new ToolStripMenuItem();
            menuItemConsultaProfesores = new ToolStripMenuItem();
            DropdownPlanesYMaterias = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            planesToolStripMenuItem = new ToolStripMenuItem();
            menuItemAltaPlanes = new ToolStripMenuItem();
            menuItemBajaPlanes = new ToolStripMenuItem();
            menuItemModificacionPlanes = new ToolStripMenuItem();
            menuItemConsultaPlanes = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            menuItemAltaMaterias = new ToolStripMenuItem();
            menuItemBajaMaterias = new ToolStripMenuItem();
            menuItemModificacionMaterias = new ToolStripMenuItem();
            menuItemConsultaMaterias = new ToolStripMenuItem();
            DropdownComisiones = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            menuItemAltaComisiones = new ToolStripMenuItem();
            menuItemBajaComisiones = new ToolStripMenuItem();
            menuItemModificacionComisiones = new ToolStripMenuItem();
            menuItemConsultaComisiones = new ToolStripMenuItem();
            DropdownCursos = new AcademiaDesktop.Controles.RJDropdownMenu(components);
            menuItemAltaCursos = new ToolStripMenuItem();
            menuItemBajaCursos = new ToolStripMenuItem();
            menuItemModificacionCursos = new ToolStripMenuItem();
            menuItemConsultaCursos = new ToolStripMenuItem();
            panel1 = new Panel();
            lblTipoUsuario = new Label();
            lblEmail = new Label();
            lblNombreApellido = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoCentral).BeginInit();
            DropdownUsuarios.SuspendLayout();
            DropdownAlumnos.SuspendLayout();
            DropdownEspecialidades.SuspendLayout();
            DropdownProfesores.SuspendLayout();
            DropdownPlanesYMaterias.SuspendLayout();
            DropdownComisiones.SuspendLayout();
            DropdownCursos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(30, 11, 99);
            panelSideMenu.Controls.Add(btnReporteCursos);
            panelSideMenu.Controls.Add(iconButton1);
            panelSideMenu.Controls.Add(btnMenuCursos);
            panelSideMenu.Controls.Add(btnMenuComisiones);
            panelSideMenu.Controls.Add(btnMenuPlanesYMaterias);
            panelSideMenu.Controls.Add(btnMenuProfesores);
            panelSideMenu.Controls.Add(btnMenuEspecialidades);
            panelSideMenu.Controls.Add(btnMenuAlumnos);
            panelSideMenu.Controls.Add(btnMenuUsuarios);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 100);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 647);
            panelSideMenu.TabIndex = 0;
            // 
            // btnReporteCursos
            // 
            btnReporteCursos.Dock = DockStyle.Top;
            btnReporteCursos.FlatAppearance.BorderSize = 0;
            btnReporteCursos.FlatStyle = FlatStyle.Flat;
            btnReporteCursos.ForeColor = Color.Gainsboro;
            btnReporteCursos.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            btnReporteCursos.IconColor = Color.Gainsboro;
            btnReporteCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporteCursos.IconSize = 40;
            btnReporteCursos.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteCursos.Location = new Point(0, 420);
            btnReporteCursos.Name = "btnReporteCursos";
            btnReporteCursos.Padding = new Padding(10, 0, 30, 0);
            btnReporteCursos.Size = new Size(250, 60);
            btnReporteCursos.TabIndex = 13;
            btnReporteCursos.Text = "Reporte de Cursos";
            btnReporteCursos.TextAlign = ContentAlignment.MiddleLeft;
            btnReporteCursos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporteCursos.UseVisualStyleBackColor = true;
            btnReporteCursos.Click += btnReporteCursos_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Bottom;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 587);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 30, 0);
            iconButton1.Size = new Size(250, 60);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Log Out";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += btnLogout_Click;
            // 
            // btnMenuCursos
            // 
            btnMenuCursos.Dock = DockStyle.Top;
            btnMenuCursos.FlatAppearance.BorderSize = 0;
            btnMenuCursos.FlatStyle = FlatStyle.Flat;
            btnMenuCursos.ForeColor = Color.Gainsboro;
            btnMenuCursos.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            btnMenuCursos.IconColor = Color.Gainsboro;
            btnMenuCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuCursos.IconSize = 40;
            btnMenuCursos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuCursos.Location = new Point(0, 360);
            btnMenuCursos.Name = "btnMenuCursos";
            btnMenuCursos.Padding = new Padding(10, 0, 30, 0);
            btnMenuCursos.Size = new Size(250, 60);
            btnMenuCursos.TabIndex = 11;
            btnMenuCursos.Text = "Cursos";
            btnMenuCursos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCursos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuCursos.UseVisualStyleBackColor = true;
            btnMenuCursos.Click += btnMenuCursos_Click;
            // 
            // btnMenuComisiones
            // 
            btnMenuComisiones.Dock = DockStyle.Top;
            btnMenuComisiones.FlatAppearance.BorderSize = 0;
            btnMenuComisiones.FlatStyle = FlatStyle.Flat;
            btnMenuComisiones.ForeColor = Color.Gainsboro;
            btnMenuComisiones.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            btnMenuComisiones.IconColor = Color.Gainsboro;
            btnMenuComisiones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuComisiones.IconSize = 40;
            btnMenuComisiones.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuComisiones.Location = new Point(0, 300);
            btnMenuComisiones.Name = "btnMenuComisiones";
            btnMenuComisiones.Padding = new Padding(10, 0, 30, 0);
            btnMenuComisiones.Size = new Size(250, 60);
            btnMenuComisiones.TabIndex = 10;
            btnMenuComisiones.Text = "Comisiones";
            btnMenuComisiones.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuComisiones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuComisiones.UseVisualStyleBackColor = true;
            btnMenuComisiones.Click += btnMenuComisiones_Click;
            // 
            // btnMenuPlanesYMaterias
            // 
            btnMenuPlanesYMaterias.Dock = DockStyle.Top;
            btnMenuPlanesYMaterias.FlatAppearance.BorderSize = 0;
            btnMenuPlanesYMaterias.FlatStyle = FlatStyle.Flat;
            btnMenuPlanesYMaterias.ForeColor = Color.Gainsboro;
            btnMenuPlanesYMaterias.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btnMenuPlanesYMaterias.IconColor = Color.Gainsboro;
            btnMenuPlanesYMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuPlanesYMaterias.IconSize = 40;
            btnMenuPlanesYMaterias.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuPlanesYMaterias.Location = new Point(0, 240);
            btnMenuPlanesYMaterias.Name = "btnMenuPlanesYMaterias";
            btnMenuPlanesYMaterias.Padding = new Padding(10, 0, 30, 0);
            btnMenuPlanesYMaterias.Size = new Size(250, 60);
            btnMenuPlanesYMaterias.TabIndex = 9;
            btnMenuPlanesYMaterias.Text = "Planes y Materias";
            btnMenuPlanesYMaterias.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPlanesYMaterias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuPlanesYMaterias.UseVisualStyleBackColor = true;
            btnMenuPlanesYMaterias.Click += btnMenuPlanesYMaterias_Click;
            // 
            // btnMenuProfesores
            // 
            btnMenuProfesores.Dock = DockStyle.Top;
            btnMenuProfesores.FlatAppearance.BorderSize = 0;
            btnMenuProfesores.FlatStyle = FlatStyle.Flat;
            btnMenuProfesores.ForeColor = Color.Gainsboro;
            btnMenuProfesores.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            btnMenuProfesores.IconColor = Color.Gainsboro;
            btnMenuProfesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuProfesores.IconSize = 40;
            btnMenuProfesores.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuProfesores.Location = new Point(0, 180);
            btnMenuProfesores.Name = "btnMenuProfesores";
            btnMenuProfesores.Padding = new Padding(10, 0, 30, 0);
            btnMenuProfesores.Size = new Size(250, 60);
            btnMenuProfesores.TabIndex = 8;
            btnMenuProfesores.Text = "Profesores";
            btnMenuProfesores.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProfesores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuProfesores.UseVisualStyleBackColor = true;
            btnMenuProfesores.Click += btnMenuProfesores_Click;
            // 
            // btnMenuEspecialidades
            // 
            btnMenuEspecialidades.Dock = DockStyle.Top;
            btnMenuEspecialidades.FlatAppearance.BorderSize = 0;
            btnMenuEspecialidades.FlatStyle = FlatStyle.Flat;
            btnMenuEspecialidades.ForeColor = Color.Gainsboro;
            btnMenuEspecialidades.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnMenuEspecialidades.IconColor = Color.Gainsboro;
            btnMenuEspecialidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuEspecialidades.IconSize = 40;
            btnMenuEspecialidades.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuEspecialidades.Location = new Point(0, 120);
            btnMenuEspecialidades.Name = "btnMenuEspecialidades";
            btnMenuEspecialidades.Padding = new Padding(10, 0, 30, 0);
            btnMenuEspecialidades.Size = new Size(250, 60);
            btnMenuEspecialidades.TabIndex = 7;
            btnMenuEspecialidades.Text = "Especialidades";
            btnMenuEspecialidades.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuEspecialidades.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuEspecialidades.UseVisualStyleBackColor = true;
            btnMenuEspecialidades.Click += btnMenuEspecialidades_Click;
            // 
            // btnMenuAlumnos
            // 
            btnMenuAlumnos.Dock = DockStyle.Top;
            btnMenuAlumnos.FlatAppearance.BorderSize = 0;
            btnMenuAlumnos.FlatStyle = FlatStyle.Flat;
            btnMenuAlumnos.ForeColor = Color.Gainsboro;
            btnMenuAlumnos.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            btnMenuAlumnos.IconColor = Color.Gainsboro;
            btnMenuAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuAlumnos.IconSize = 40;
            btnMenuAlumnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuAlumnos.Location = new Point(0, 60);
            btnMenuAlumnos.Name = "btnMenuAlumnos";
            btnMenuAlumnos.Padding = new Padding(10, 0, 30, 0);
            btnMenuAlumnos.Size = new Size(250, 60);
            btnMenuAlumnos.TabIndex = 6;
            btnMenuAlumnos.Text = "Alumnos";
            btnMenuAlumnos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAlumnos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuAlumnos.UseVisualStyleBackColor = true;
            btnMenuAlumnos.Click += btnMenuAlumnos_Click;
            // 
            // btnMenuUsuarios
            // 
            btnMenuUsuarios.Dock = DockStyle.Top;
            btnMenuUsuarios.FlatAppearance.BorderSize = 0;
            btnMenuUsuarios.FlatStyle = FlatStyle.Flat;
            btnMenuUsuarios.ForeColor = Color.Gainsboro;
            btnMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            btnMenuUsuarios.IconColor = Color.Gainsboro;
            btnMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuUsuarios.IconSize = 40;
            btnMenuUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuUsuarios.Location = new Point(0, 0);
            btnMenuUsuarios.Name = "btnMenuUsuarios";
            btnMenuUsuarios.Padding = new Padding(10, 0, 30, 0);
            btnMenuUsuarios.Size = new Size(250, 60);
            btnMenuUsuarios.TabIndex = 1;
            btnMenuUsuarios.Text = "Usuarios";
            btnMenuUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuUsuarios.UseVisualStyleBackColor = true;
            btnMenuUsuarios.Click += btnMenuUsuarios_Click;
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Left;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(250, 100);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(15, 6, 15);
            panelChildForm.Controls.Add(logoCentral);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 100);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1079, 647);
            panelChildForm.TabIndex = 1;
            // 
            // logoCentral
            // 
            logoCentral.Anchor = AnchorStyles.None;
            logoCentral.Image = (Image)resources.GetObject("logoCentral.Image");
            logoCentral.Location = new Point(294, 164);
            logoCentral.Name = "logoCentral";
            logoCentral.Size = new Size(467, 266);
            logoCentral.SizeMode = PictureBoxSizeMode.Zoom;
            logoCentral.TabIndex = 0;
            logoCentral.TabStop = false;
            // 
            // DropdownUsuarios
            // 
            DropdownUsuarios.ImageScalingSize = new Size(20, 20);
            DropdownUsuarios.IsMainMenu = false;
            DropdownUsuarios.Items.AddRange(new ToolStripItem[] { menuItemAltaUsuarios, menuItemBajaUsuarios, menuItemModificacionUsuarios, menuItemConsultaUsuarios });
            DropdownUsuarios.MenuItemHeight = 25;
            DropdownUsuarios.MenuItemTextColor = Color.Empty;
            DropdownUsuarios.Name = "rjDropdownUsuarios";
            DropdownUsuarios.PrimaryColor = Color.Empty;
            DropdownUsuarios.Size = new Size(145, 92);
            // 
            // menuItemAltaUsuarios
            // 
            menuItemAltaUsuarios.Name = "menuItemAltaUsuarios";
            menuItemAltaUsuarios.Size = new Size(144, 22);
            menuItemAltaUsuarios.Text = "Alta";
            menuItemAltaUsuarios.Click += menuItemAltaUsuarios_Click;
            // 
            // menuItemBajaUsuarios
            // 
            menuItemBajaUsuarios.Name = "menuItemBajaUsuarios";
            menuItemBajaUsuarios.Size = new Size(144, 22);
            menuItemBajaUsuarios.Text = "Baja";
            menuItemBajaUsuarios.Click += menuItemBajaUsuarios_Click;
            // 
            // menuItemModificacionUsuarios
            // 
            menuItemModificacionUsuarios.Name = "menuItemModificacionUsuarios";
            menuItemModificacionUsuarios.Size = new Size(144, 22);
            menuItemModificacionUsuarios.Text = "Modificacion";
            menuItemModificacionUsuarios.Click += menuItemModificacionUsuarios_Click;
            // 
            // menuItemConsultaUsuarios
            // 
            menuItemConsultaUsuarios.Name = "menuItemConsultaUsuarios";
            menuItemConsultaUsuarios.Size = new Size(144, 22);
            menuItemConsultaUsuarios.Text = "Consulta";
            menuItemConsultaUsuarios.Click += menuItemConsultaUsuarios_Click;
            // 
            // DropdownAlumnos
            // 
            DropdownAlumnos.ImageScalingSize = new Size(20, 20);
            DropdownAlumnos.IsMainMenu = false;
            DropdownAlumnos.Items.AddRange(new ToolStripItem[] { menuItemAltaAlumnos, menuItemBajaAlumnos, menuItemModificacionAlumnos, menuItemConsultaAlumnos });
            DropdownAlumnos.MenuItemHeight = 25;
            DropdownAlumnos.MenuItemTextColor = Color.Empty;
            DropdownAlumnos.Name = "rjDropdownAlumnos";
            DropdownAlumnos.PrimaryColor = Color.Empty;
            DropdownAlumnos.Size = new Size(145, 92);
            // 
            // menuItemAltaAlumnos
            // 
            menuItemAltaAlumnos.Name = "menuItemAltaAlumnos";
            menuItemAltaAlumnos.Size = new Size(144, 22);
            menuItemAltaAlumnos.Text = "Alta";
            menuItemAltaAlumnos.Click += menuItemAltaAlumnos_Click;
            // 
            // menuItemBajaAlumnos
            // 
            menuItemBajaAlumnos.Name = "menuItemBajaAlumnos";
            menuItemBajaAlumnos.Size = new Size(144, 22);
            menuItemBajaAlumnos.Text = "Baja";
            menuItemBajaAlumnos.Click += menuItemBajaAlumnos_Click;
            // 
            // menuItemModificacionAlumnos
            // 
            menuItemModificacionAlumnos.Name = "menuItemModificacionAlumnos";
            menuItemModificacionAlumnos.Size = new Size(144, 22);
            menuItemModificacionAlumnos.Text = "Modificacion";
            menuItemModificacionAlumnos.Click += menuItemModificacionAlumnos_Click;
            // 
            // menuItemConsultaAlumnos
            // 
            menuItemConsultaAlumnos.Name = "menuItemConsultaAlumnos";
            menuItemConsultaAlumnos.Size = new Size(144, 22);
            menuItemConsultaAlumnos.Text = "Consulta";
            menuItemConsultaAlumnos.Click += menuItemConsultaAlumnos_Click;
            // 
            // DropdownEspecialidades
            // 
            DropdownEspecialidades.ImageScalingSize = new Size(20, 20);
            DropdownEspecialidades.IsMainMenu = false;
            DropdownEspecialidades.Items.AddRange(new ToolStripItem[] { menuItemAltaEspecialidades, menuItemBajaEspecialidades, menuItemModificacionEspecialidades, menuItemConsultaEspecialidades });
            DropdownEspecialidades.MenuItemHeight = 25;
            DropdownEspecialidades.MenuItemTextColor = Color.Empty;
            DropdownEspecialidades.Name = "rjDropdownEspecialidades";
            DropdownEspecialidades.PrimaryColor = Color.Empty;
            DropdownEspecialidades.Size = new Size(145, 92);
            // 
            // menuItemAltaEspecialidades
            // 
            menuItemAltaEspecialidades.Name = "menuItemAltaEspecialidades";
            menuItemAltaEspecialidades.Size = new Size(144, 22);
            menuItemAltaEspecialidades.Text = "Alta";
            menuItemAltaEspecialidades.Click += menuItemAltaEspecialidades_Click;
            // 
            // menuItemBajaEspecialidades
            // 
            menuItemBajaEspecialidades.Name = "menuItemBajaEspecialidades";
            menuItemBajaEspecialidades.Size = new Size(144, 22);
            menuItemBajaEspecialidades.Text = "Baja";
            menuItemBajaEspecialidades.Click += menuItemBajaEspecialidades_Click;
            // 
            // menuItemModificacionEspecialidades
            // 
            menuItemModificacionEspecialidades.Name = "menuItemModificacionEspecialidades";
            menuItemModificacionEspecialidades.Size = new Size(144, 22);
            menuItemModificacionEspecialidades.Text = "Modificacion";
            menuItemModificacionEspecialidades.Click += menuItemModificacionEspecialidades_Click;
            // 
            // menuItemConsultaEspecialidades
            // 
            menuItemConsultaEspecialidades.Name = "menuItemConsultaEspecialidades";
            menuItemConsultaEspecialidades.Size = new Size(144, 22);
            menuItemConsultaEspecialidades.Text = "Consulta";
            menuItemConsultaEspecialidades.Click += menuItemConsultaEspecialidades_Click;
            // 
            // DropdownProfesores
            // 
            DropdownProfesores.ImageScalingSize = new Size(20, 20);
            DropdownProfesores.IsMainMenu = false;
            DropdownProfesores.Items.AddRange(new ToolStripItem[] { menuItemAltaProfesores, menuItemBajaProfesores, menuItemModificacionProfesores, menuItemConsultaProfesores });
            DropdownProfesores.MenuItemHeight = 25;
            DropdownProfesores.MenuItemTextColor = Color.Empty;
            DropdownProfesores.Name = "rjDropdownProfesores";
            DropdownProfesores.PrimaryColor = Color.Empty;
            DropdownProfesores.Size = new Size(145, 92);
            // 
            // menuItemAltaProfesores
            // 
            menuItemAltaProfesores.Name = "menuItemAltaProfesores";
            menuItemAltaProfesores.Size = new Size(144, 22);
            menuItemAltaProfesores.Text = "Alta";
            menuItemAltaProfesores.Click += menuItemAltaProfesores_Click;
            // 
            // menuItemBajaProfesores
            // 
            menuItemBajaProfesores.Name = "menuItemBajaProfesores";
            menuItemBajaProfesores.Size = new Size(144, 22);
            menuItemBajaProfesores.Text = "Baja";
            menuItemBajaProfesores.Click += menuItemBajaProfesores_Click;
            // 
            // menuItemModificacionProfesores
            // 
            menuItemModificacionProfesores.Name = "menuItemModificacionProfesores";
            menuItemModificacionProfesores.Size = new Size(144, 22);
            menuItemModificacionProfesores.Text = "Modificacion";
            menuItemModificacionProfesores.Click += menuItemModificacionProfesores_Click;
            // 
            // menuItemConsultaProfesores
            // 
            menuItemConsultaProfesores.Name = "menuItemConsultaProfesores";
            menuItemConsultaProfesores.Size = new Size(144, 22);
            menuItemConsultaProfesores.Text = "Consulta";
            menuItemConsultaProfesores.Click += menuItemConsultaProfesores_Click;
            // 
            // DropdownPlanesYMaterias
            // 
            DropdownPlanesYMaterias.ImageScalingSize = new Size(20, 20);
            DropdownPlanesYMaterias.IsMainMenu = false;
            DropdownPlanesYMaterias.Items.AddRange(new ToolStripItem[] { planesToolStripMenuItem, materiasToolStripMenuItem });
            DropdownPlanesYMaterias.MenuItemHeight = 25;
            DropdownPlanesYMaterias.MenuItemTextColor = Color.Empty;
            DropdownPlanesYMaterias.Name = "rjDropdownPlanesYMaterias";
            DropdownPlanesYMaterias.PrimaryColor = Color.Empty;
            DropdownPlanesYMaterias.Size = new Size(120, 48);
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemAltaPlanes, menuItemBajaPlanes, menuItemModificacionPlanes, menuItemConsultaPlanes });
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(119, 22);
            planesToolStripMenuItem.Text = "Planes";
            // 
            // menuItemAltaPlanes
            // 
            menuItemAltaPlanes.Name = "menuItemAltaPlanes";
            menuItemAltaPlanes.Size = new Size(180, 22);
            menuItemAltaPlanes.Text = "Alta";
            menuItemAltaPlanes.Click += menuItemAltaPlanes_Click;
            // 
            // menuItemBajaPlanes
            // 
            menuItemBajaPlanes.Name = "menuItemBajaPlanes";
            menuItemBajaPlanes.Size = new Size(180, 22);
            menuItemBajaPlanes.Text = "Baja";
            menuItemBajaPlanes.Click += menuItemBajaPlanes_Click;
            // 
            // menuItemModificacionPlanes
            // 
            menuItemModificacionPlanes.Name = "menuItemModificacionPlanes";
            menuItemModificacionPlanes.Size = new Size(180, 22);
            menuItemModificacionPlanes.Text = "Modificacion";
            menuItemModificacionPlanes.Click += menuItemModificacionPlanes_Click;
            // 
            // menuItemConsultaPlanes
            // 
            menuItemConsultaPlanes.Name = "menuItemConsultaPlanes";
            menuItemConsultaPlanes.Size = new Size(180, 22);
            menuItemConsultaPlanes.Text = "Consulta";
            menuItemConsultaPlanes.Click += menuItemConsultaPlanes_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemAltaMaterias, menuItemBajaMaterias, menuItemModificacionMaterias, menuItemConsultaMaterias });
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(119, 22);
            materiasToolStripMenuItem.Text = "Materias";
            // 
            // menuItemAltaMaterias
            // 
            menuItemAltaMaterias.Name = "menuItemAltaMaterias";
            menuItemAltaMaterias.Size = new Size(180, 22);
            menuItemAltaMaterias.Text = "Alta";
            menuItemAltaMaterias.Click += menuItemAltaMaterias_Click;
            // 
            // menuItemBajaMaterias
            // 
            menuItemBajaMaterias.Name = "menuItemBajaMaterias";
            menuItemBajaMaterias.Size = new Size(180, 22);
            menuItemBajaMaterias.Text = "Baja";
            menuItemBajaMaterias.Click += menuItemBajaMaterias_Click;
            // 
            // menuItemModificacionMaterias
            // 
            menuItemModificacionMaterias.Name = "menuItemModificacionMaterias";
            menuItemModificacionMaterias.Size = new Size(180, 22);
            menuItemModificacionMaterias.Text = "Modificacion";
            menuItemModificacionMaterias.Click += menuItemModificacionMaterias_Click;
            // 
            // menuItemConsultaMaterias
            // 
            menuItemConsultaMaterias.Name = "menuItemConsultaMaterias";
            menuItemConsultaMaterias.Size = new Size(180, 22);
            menuItemConsultaMaterias.Text = "Consulta";
            menuItemConsultaMaterias.Click += menuItemConsultaMaterias_Click;
            // 
            // DropdownComisiones
            // 
            DropdownComisiones.ImageScalingSize = new Size(20, 20);
            DropdownComisiones.IsMainMenu = false;
            DropdownComisiones.Items.AddRange(new ToolStripItem[] { menuItemAltaComisiones, menuItemBajaComisiones, menuItemModificacionComisiones, menuItemConsultaComisiones });
            DropdownComisiones.MenuItemHeight = 25;
            DropdownComisiones.MenuItemTextColor = Color.Empty;
            DropdownComisiones.Name = "rjDropdownComisiones";
            DropdownComisiones.PrimaryColor = Color.Empty;
            DropdownComisiones.Size = new Size(145, 92);
            // 
            // menuItemAltaComisiones
            // 
            menuItemAltaComisiones.Name = "menuItemAltaComisiones";
            menuItemAltaComisiones.Size = new Size(144, 22);
            menuItemAltaComisiones.Text = "Alta";
            // 
            // menuItemBajaComisiones
            // 
            menuItemBajaComisiones.Name = "menuItemBajaComisiones";
            menuItemBajaComisiones.Size = new Size(144, 22);
            menuItemBajaComisiones.Text = "Baja";
            // 
            // menuItemModificacionComisiones
            // 
            menuItemModificacionComisiones.Name = "menuItemModificacionComisiones";
            menuItemModificacionComisiones.Size = new Size(144, 22);
            menuItemModificacionComisiones.Text = "Modificacion";
            // 
            // menuItemConsultaComisiones
            // 
            menuItemConsultaComisiones.Name = "menuItemConsultaComisiones";
            menuItemConsultaComisiones.Size = new Size(144, 22);
            menuItemConsultaComisiones.Text = "Consulta";
            // 
            // DropdownCursos
            // 
            DropdownCursos.ImageScalingSize = new Size(20, 20);
            DropdownCursos.IsMainMenu = false;
            DropdownCursos.Items.AddRange(new ToolStripItem[] { menuItemAltaCursos, menuItemBajaCursos, menuItemModificacionCursos, menuItemConsultaCursos });
            DropdownCursos.MenuItemHeight = 25;
            DropdownCursos.MenuItemTextColor = Color.Empty;
            DropdownCursos.Name = "rjDropdownCursos";
            DropdownCursos.PrimaryColor = Color.Empty;
            DropdownCursos.Size = new Size(145, 92);
            // 
            // menuItemAltaCursos
            // 
            menuItemAltaCursos.Name = "menuItemAltaCursos";
            menuItemAltaCursos.Size = new Size(144, 22);
            menuItemAltaCursos.Text = "Alta";
            // 
            // menuItemBajaCursos
            // 
            menuItemBajaCursos.Name = "menuItemBajaCursos";
            menuItemBajaCursos.Size = new Size(144, 22);
            menuItemBajaCursos.Text = "Baja";
            // 
            // menuItemModificacionCursos
            // 
            menuItemModificacionCursos.Name = "menuItemModificacionCursos";
            menuItemModificacionCursos.Size = new Size(144, 22);
            menuItemModificacionCursos.Text = "Modificacion";
            // 
            // menuItemConsultaCursos
            // 
            menuItemConsultaCursos.Name = "menuItemConsultaCursos";
            menuItemConsultaCursos.Size = new Size(144, 22);
            menuItemConsultaCursos.Text = "Consulta";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 10, 125);
            panel1.Controls.Add(lblTipoUsuario);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNombreApellido);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(Logo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 100);
            panel1.TabIndex = 13;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.ForeColor = Color.Gainsboro;
            lblTipoUsuario.Location = new Point(335, 60);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(89, 17);
            lblTipoUsuario.TabIndex = 4;
            lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Gainsboro;
            lblEmail.Location = new Point(335, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.ForeColor = Color.Gainsboro;
            lblNombreApellido.Location = new Point(335, 20);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(123, 17);
            lblNombreApellido.TabIndex = 2;
            lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(35, 10, 125);
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 49;
            iconPictureBox1.Location = new Point(266, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(52, 49);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 747);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(1345, 736);
            Name = "FormMenu";
            Text = "Academia";
            WindowState = FormWindowState.Maximized;
            Load += Academia_Load;
            panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoCentral).EndInit();
            DropdownUsuarios.ResumeLayout(false);
            DropdownAlumnos.ResumeLayout(false);
            DropdownEspecialidades.ResumeLayout(false);
            DropdownProfesores.ResumeLayout(false);
            DropdownPlanesYMaterias.ResumeLayout(false);
            DropdownComisiones.ResumeLayout(false);
            DropdownCursos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelChildForm;
        private PictureBox logoCentral;
        private FontAwesome.Sharp.IconButton btnMenuAlumnos;
        private FontAwesome.Sharp.IconButton btnMenuUsuarios;
        private PictureBox Logo;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownUsuarios;
        private ToolStripMenuItem menuItemAltaUsuarios;
        private ToolStripMenuItem menuItemBajaUsuarios;
        private ToolStripMenuItem menuItemModificacionUsuarios;
        private ToolStripMenuItem menuItemConsultaUsuarios;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownAlumnos;
        private ToolStripMenuItem menuItemAltaAlumnos;
        private ToolStripMenuItem menuItemBajaAlumnos;
        private ToolStripMenuItem menuItemModificacionAlumnos;
        private ToolStripMenuItem menuItemConsultaAlumnos;
        private FontAwesome.Sharp.IconButton btnMenuPlanesYMaterias;
        private FontAwesome.Sharp.IconButton btnMenuProfesores;
        private FontAwesome.Sharp.IconButton btnMenuEspecialidades;
        private FontAwesome.Sharp.IconButton btnMenuCursos;
        private FontAwesome.Sharp.IconButton btnMenuComisiones;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownEspecialidades;
        private ToolStripMenuItem menuItemAltaEspecialidades;
        private ToolStripMenuItem menuItemBajaEspecialidades;
        private ToolStripMenuItem menuItemModificacionEspecialidades;
        private ToolStripMenuItem menuItemConsultaEspecialidades;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownProfesores;
        private ToolStripMenuItem menuItemAltaProfesores;
        private ToolStripMenuItem menuItemBajaProfesores;
        private ToolStripMenuItem menuItemModificacionProfesores;
        private ToolStripMenuItem menuItemConsultaProfesores;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownPlanesYMaterias;
        private ToolStripMenuItem planesToolStripMenuItem;
        private ToolStripMenuItem menuItemAltaPlanes;
        private ToolStripMenuItem menuItemBajaPlanes;
        private ToolStripMenuItem menuItemModificacionPlanes;
        private ToolStripMenuItem menuItemConsultaPlanes;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem menuItemAltaMaterias;
        private ToolStripMenuItem menuItemBajaMaterias;
        private ToolStripMenuItem menuItemModificacionMaterias;
        private ToolStripMenuItem menuItemConsultaMaterias;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownComisiones;
        private ToolStripMenuItem menuItemAltaComisiones;
        private ToolStripMenuItem menuItemBajaComisiones;
        private ToolStripMenuItem menuItemModificacionComisiones;
        private ToolStripMenuItem menuItemConsultaComisiones;
        private AcademiaDesktop.Controles.RJDropdownMenu DropdownCursos;
        private ToolStripMenuItem menuItemAltaCursos;
        private ToolStripMenuItem menuItemBajaCursos;
        private ToolStripMenuItem menuItemModificacionCursos;
        private ToolStripMenuItem menuItemConsultaCursos;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblTipoUsuario;
        private Label lblEmail;
        private Label lblNombreApellido;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnReporteCursos;
    }
}