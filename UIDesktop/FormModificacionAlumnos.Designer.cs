namespace UIDesktop
{
    partial class FormModificacionAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgv_ModificacionAlumnos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            fecha_nac = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txt_nombre = new TextBox();
            lbl_NombreUsuario = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txt_apellido = new TextBox();
            label1 = new Label();
            txt_direccion = new TextBox();
            label2 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txt_legajo = new TextBox();
            label7 = new Label();
            dtp_fechaNac = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dtgv_ModificacionAlumnos
            // 
            dtgv_ModificacionAlumnos.AllowUserToAddRows = false;
            dtgv_ModificacionAlumnos.AllowUserToDeleteRows = false;
            dtgv_ModificacionAlumnos.AllowUserToResizeColumns = false;
            dtgv_ModificacionAlumnos.AllowUserToResizeRows = false;
            dtgv_ModificacionAlumnos.Anchor = AnchorStyles.None;
            dtgv_ModificacionAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ModificacionAlumnos.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_ModificacionAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_ModificacionAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ModificacionAlumnos.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, direccion, email, telefono, fecha_nac, legajo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_ModificacionAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_ModificacionAlumnos.GridColor = Color.Gainsboro;
            dtgv_ModificacionAlumnos.Location = new Point(507, 61);
            dtgv_ModificacionAlumnos.MultiSelect = false;
            dtgv_ModificacionAlumnos.Name = "dtgv_ModificacionAlumnos";
            dtgv_ModificacionAlumnos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_ModificacionAlumnos.RowHeadersVisible = false;
            dtgv_ModificacionAlumnos.RowTemplate.Height = 25;
            dtgv_ModificacionAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_ModificacionAlumnos.Size = new Size(525, 193);
            dtgv_ModificacionAlumnos.TabIndex = 30;
            dtgv_ModificacionAlumnos.CellClick += dtgv_ModificacionAlumnnos_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // fecha_nac
            // 
            fecha_nac.HeaderText = "Fecha de Nacimiento";
            fecha_nac.Name = "fecha_nac";
            fecha_nac.ReadOnly = true;
            // 
            // legajo
            // 
            legajo.HeaderText = "Legajo";
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(90, 41);
            label5.Name = "label5";
            label5.Size = new Size(270, 29);
            label5.TabIndex = 29;
            label5.Text = "Modificacion de Alumno";
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.Location = new Point(196, 122);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(279, 23);
            txt_nombre.TabIndex = 27;
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.Anchor = AnchorStyles.None;
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreUsuario.ForeColor = Color.Gainsboro;
            lbl_NombreUsuario.Location = new Point(132, 124);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(58, 17);
            lbl_NombreUsuario.TabIndex = 26;
            lbl_NombreUsuario.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(607, 422);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 25;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(362, 422);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txt_apellido
            // 
            txt_apellido.Anchor = AnchorStyles.None;
            txt_apellido.Location = new Point(196, 159);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(279, 23);
            txt_apellido.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(132, 161);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 31;
            label1.Text = "Apellido";
            // 
            // txt_direccion
            // 
            txt_direccion.Anchor = AnchorStyles.None;
            txt_direccion.Location = new Point(196, 197);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(279, 23);
            txt_direccion.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(123, 199);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 33;
            label2.Text = "Dirección";
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Location = new Point(196, 237);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(279, 23);
            txt_email.TabIndex = 36;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(148, 239);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 35;
            label3.Text = "Email";
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.None;
            txt_telefono.Location = new Point(196, 274);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(279, 23);
            txt_telefono.TabIndex = 38;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(126, 276);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 37;
            label4.Text = "Teléfono";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(49, 313);
            label6.Name = "label6";
            label6.Size = new Size(141, 17);
            label6.TabIndex = 39;
            label6.Text = "Fecha de Nacimiento";
            // 
            // txt_legajo
            // 
            txt_legajo.Anchor = AnchorStyles.None;
            txt_legajo.Location = new Point(196, 347);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(279, 23);
            txt_legajo.TabIndex = 42;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(139, 349);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 41;
            label7.Text = "Legajo";
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Anchor = AnchorStyles.None;
            dtp_fechaNac.Location = new Point(196, 313);
            dtp_fechaNac.Margin = new Padding(3, 2, 3, 2);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(219, 23);
            dtp_fechaNac.TabIndex = 43;
            dtp_fechaNac.Value = new DateTime(2023, 10, 5, 19, 16, 51, 0);
            // 
            // FormModificacionAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 608);
            Controls.Add(dtp_fechaNac);
            Controls.Add(txt_legajo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(txt_direccion);
            Controls.Add(label2);
            Controls.Add(txt_apellido);
            Controls.Add(label1);
            Controls.Add(dtgv_ModificacionAlumnos);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_NombreUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormModificacionAlumnos";
            Text = "FormModificacionAlumnos";
            Load += FormModificacionAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_ModificacionAlumnos;
        private Label label5;
        private TextBox txt_nombre;
        private Label lbl_NombreUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txt_apellido;
        private Label label1;
        private TextBox txt_direccion;
        private Label label2;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_telefono;
        private Label label4;
        private Label label6;
        private TextBox txt_legajo;
        private Label label7;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fecha_nac;
        private DataGridViewTextBoxColumn legajo;
        private DateTimePicker dtp_fechaNac;
    }
}