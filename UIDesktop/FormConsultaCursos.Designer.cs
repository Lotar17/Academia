namespace UIDesktop
{
    partial class FormConsultaCursos
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
            nud_Id = new NumericUpDown();
            panel1 = new Panel();
            lbl_comision = new Label();
            lbl_cupo = new Label();
            lbl_anioCalendario = new Label();
            ipb_Usuario = new FontAwesome.Sharp.IconPictureBox();
            lbl_materia = new Label();
            lbl_Id = new Label();
            label5 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Id).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).BeginInit();
            SuspendLayout();
            // 
            // nud_Id
            // 
            nud_Id.Anchor = AnchorStyles.None;
            nud_Id.Location = new Point(102, 191);
            nud_Id.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nud_Id.Name = "nud_Id";
            nud_Id.Size = new Size(120, 23);
            nud_Id.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_comision);
            panel1.Controls.Add(lbl_cupo);
            panel1.Controls.Add(lbl_anioCalendario);
            panel1.Controls.Add(ipb_Usuario);
            panel1.Controls.Add(lbl_materia);
            panel1.Controls.Add(lbl_Id);
            panel1.Location = new Point(374, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 256);
            panel1.TabIndex = 51;
            panel1.Visible = false;
            // 
            // lbl_comision
            // 
            lbl_comision.Anchor = AnchorStyles.None;
            lbl_comision.AutoSize = true;
            lbl_comision.ForeColor = Color.Gainsboro;
            lbl_comision.Location = new Point(14, 158);
            lbl_comision.Name = "lbl_comision";
            lbl_comision.Size = new Size(61, 15);
            lbl_comision.TabIndex = 27;
            lbl_comision.Text = "Comision:";
            lbl_comision.Visible = false;
            // 
            // lbl_cupo
            // 
            lbl_cupo.Anchor = AnchorStyles.None;
            lbl_cupo.AutoSize = true;
            lbl_cupo.ForeColor = Color.Gainsboro;
            lbl_cupo.Location = new Point(14, 211);
            lbl_cupo.Name = "lbl_cupo";
            lbl_cupo.Size = new Size(39, 15);
            lbl_cupo.TabIndex = 26;
            lbl_cupo.Text = "Cupo:";
            lbl_cupo.Visible = false;
            // 
            // lbl_anioCalendario
            // 
            lbl_anioCalendario.Anchor = AnchorStyles.None;
            lbl_anioCalendario.AutoSize = true;
            lbl_anioCalendario.ForeColor = Color.Gainsboro;
            lbl_anioCalendario.Location = new Point(14, 184);
            lbl_anioCalendario.Name = "lbl_anioCalendario";
            lbl_anioCalendario.Size = new Size(100, 15);
            lbl_anioCalendario.TabIndex = 25;
            lbl_anioCalendario.Text = "Año Especialidad:";
            lbl_anioCalendario.Visible = false;
            // 
            // ipb_Usuario
            // 
            ipb_Usuario.Anchor = AnchorStyles.None;
            ipb_Usuario.BackColor = Color.FromArgb(32, 30, 45);
            ipb_Usuario.ForeColor = Color.Gainsboro;
            ipb_Usuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ipb_Usuario.IconColor = Color.Gainsboro;
            ipb_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipb_Usuario.IconSize = 100;
            ipb_Usuario.Location = new Point(289, 15);
            ipb_Usuario.Name = "ipb_Usuario";
            ipb_Usuario.Size = new Size(100, 100);
            ipb_Usuario.TabIndex = 23;
            ipb_Usuario.TabStop = false;
            ipb_Usuario.Visible = false;
            // 
            // lbl_materia
            // 
            lbl_materia.Anchor = AnchorStyles.None;
            lbl_materia.AutoSize = true;
            lbl_materia.ForeColor = Color.Gainsboro;
            lbl_materia.Location = new Point(14, 131);
            lbl_materia.Name = "lbl_materia";
            lbl_materia.Size = new Size(50, 15);
            lbl_materia.TabIndex = 3;
            lbl_materia.Text = "Materia:";
            lbl_materia.Visible = false;
            // 
            // lbl_Id
            // 
            lbl_Id.Anchor = AnchorStyles.None;
            lbl_Id.AutoSize = true;
            lbl_Id.ForeColor = Color.Gainsboro;
            lbl_Id.Location = new Point(14, 107);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(21, 15);
            lbl_Id.TabIndex = 0;
            lbl_Id.Text = "ID:";
            lbl_Id.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(45, 56);
            label5.Name = "label5";
            label5.Size = new Size(223, 29);
            label5.TabIndex = 50;
            label5.Text = "Consulta de Cursos";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(60, 162);
            label1.Name = "label1";
            label1.Size = new Size(208, 17);
            label1.TabIndex = 49;
            label1.Text = "Ingrese el ID del curso a buscar";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(399, 356);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 48;
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
            btnCancelar.Location = new Point(154, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormConsultaCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(nud_Id);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormConsultaCursos";
            Text = "FormConsultaCursos";
            ((System.ComponentModel.ISupportInitialize)nud_Id).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_Id;
        private Panel panel1;
        private Label lbl_cupo;
        private Label lbl_anioCalendario;
        private FontAwesome.Sharp.IconPictureBox ipb_Usuario;
        private Label lbl_materia;
        private Label lbl_Id;
        private Label label5;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lbl_comision;
    }
}