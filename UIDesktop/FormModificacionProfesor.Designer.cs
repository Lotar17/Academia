namespace UIDesktop
{
    partial class FormModificacionProfesor
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
            dtp_fechaNac = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_direccion = new TextBox();
            label2 = new Label();
            txt_apellido = new TextBox();
            label1 = new Label();
            dtgv_ModificacionProfesores = new DataGridView();
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
            nud_legajo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionProfesores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_legajo).BeginInit();
            SuspendLayout();
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Anchor = AnchorStyles.None;
            dtp_fechaNac.Location = new Point(214, 477);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(250, 27);
            dtp_fechaNac.TabIndex = 61;
            dtp_fechaNac.Value = new DateTime(2023, 10, 5, 19, 16, 51, 0);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(149, 525);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 59;
            label7.Text = "Legajo";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(46, 477);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 58;
            label6.Text = "Fecha de Nacimiento";
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.None;
            txt_telefono.Location = new Point(214, 425);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(318, 27);
            txt_telefono.TabIndex = 57;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(134, 428);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 56;
            label4.Text = "Teléfono";
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Location = new Point(214, 376);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(318, 27);
            txt_email.TabIndex = 55;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(159, 379);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 54;
            label3.Text = "Email";
            // 
            // txt_direccion
            // 
            txt_direccion.Anchor = AnchorStyles.None;
            txt_direccion.Location = new Point(214, 323);
            txt_direccion.Margin = new Padding(3, 4, 3, 4);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(318, 27);
            txt_direccion.TabIndex = 53;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(130, 325);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 52;
            label2.Text = "Dirección";
            // 
            // txt_apellido
            // 
            txt_apellido.Anchor = AnchorStyles.None;
            txt_apellido.Location = new Point(214, 272);
            txt_apellido.Margin = new Padding(3, 4, 3, 4);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(318, 27);
            txt_apellido.TabIndex = 51;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(141, 275);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 50;
            label1.Text = "Apellido";
            // 
            // dtgv_ModificacionProfesores
            // 
            dtgv_ModificacionProfesores.AllowUserToAddRows = false;
            dtgv_ModificacionProfesores.AllowUserToDeleteRows = false;
            dtgv_ModificacionProfesores.AllowUserToResizeColumns = false;
            dtgv_ModificacionProfesores.AllowUserToResizeRows = false;
            dtgv_ModificacionProfesores.Anchor = AnchorStyles.None;
            dtgv_ModificacionProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ModificacionProfesores.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_ModificacionProfesores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionProfesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_ModificacionProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ModificacionProfesores.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, direccion, email, telefono, fecha_nac, legajo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_ModificacionProfesores.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_ModificacionProfesores.GridColor = Color.Gainsboro;
            dtgv_ModificacionProfesores.Location = new Point(569, 141);
            dtgv_ModificacionProfesores.Margin = new Padding(3, 4, 3, 4);
            dtgv_ModificacionProfesores.MultiSelect = false;
            dtgv_ModificacionProfesores.Name = "dtgv_ModificacionProfesores";
            dtgv_ModificacionProfesores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionProfesores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_ModificacionProfesores.RowHeadersVisible = false;
            dtgv_ModificacionProfesores.RowHeadersWidth = 51;
            dtgv_ModificacionProfesores.RowTemplate.Height = 25;
            dtgv_ModificacionProfesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_ModificacionProfesores.Size = new Size(600, 257);
            dtgv_ModificacionProfesores.TabIndex = 49;
            dtgv_ModificacionProfesores.CellClick += dtgv_ModificacionProfesores_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // fecha_nac
            // 
            fecha_nac.HeaderText = "Fecha de Nacimiento";
            fecha_nac.MinimumWidth = 6;
            fecha_nac.Name = "fecha_nac";
            fecha_nac.ReadOnly = true;
            // 
            // legajo
            // 
            legajo.HeaderText = "Legajo";
            legajo.MinimumWidth = 6;
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(93, 115);
            label5.Name = "label5";
            label5.Size = new Size(345, 36);
            label5.TabIndex = 48;
            label5.Text = "Modificacion de Profesor";
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.Location = new Point(214, 223);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(318, 27);
            txt_nombre.TabIndex = 47;
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.Anchor = AnchorStyles.None;
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreUsuario.ForeColor = Color.Gainsboro;
            lbl_NombreUsuario.Location = new Point(141, 225);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(68, 20);
            lbl_NombreUsuario.TabIndex = 46;
            lbl_NombreUsuario.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(683, 623);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
            btnAceptar.TabIndex = 45;
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
            btnCancelar.Location = new Point(403, 623);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nud_legajo
            // 
            nud_legajo.Anchor = AnchorStyles.None;
            nud_legajo.Location = new Point(214, 523);
            nud_legajo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_legajo.Name = "nud_legajo";
            nud_legajo.Size = new Size(150, 27);
            nud_legajo.TabIndex = 62;
            // 
            // FormModificacionProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 811);
            Controls.Add(nud_legajo);
            Controls.Add(dtp_fechaNac);
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
            Controls.Add(dtgv_ModificacionProfesores);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_NombreUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificacionProfesor";
            Text = "FormModificacionProfesor";
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionProfesores).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_legajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_fechaNac;
        private Label label7;
        private Label label6;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_direccion;
        private Label label2;
        private TextBox txt_apellido;
        private Label label1;
        private DataGridView dtgv_ModificacionProfesores;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fecha_nac;
        private DataGridViewTextBoxColumn legajo;
        private Label label5;
        private TextBox txt_nombre;
        private Label lbl_NombreUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown nud_legajo;
    }
}