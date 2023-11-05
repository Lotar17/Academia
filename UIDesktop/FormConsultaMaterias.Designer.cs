namespace UIDesktop
{
    partial class FormConsultaMaterias
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
            panel1 = new Panel();
            lbl_plan = new Label();
            lbl_hsSemanales = new Label();
            lbl_hsTotales = new Label();
            ipb_Usuario = new FontAwesome.Sharp.IconPictureBox();
            lbl_descMateria = new Label();
            lbl_Id = new Label();
            label5 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            nud_Id = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Id).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_plan);
            panel1.Controls.Add(lbl_hsSemanales);
            panel1.Controls.Add(lbl_hsTotales);
            panel1.Controls.Add(ipb_Usuario);
            panel1.Controls.Add(lbl_descMateria);
            panel1.Controls.Add(lbl_Id);
            panel1.Location = new Point(531, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 256);
            panel1.TabIndex = 39;
            panel1.Visible = false;
            // 
            // lbl_plan
            // 
            lbl_plan.Anchor = AnchorStyles.None;
            lbl_plan.AutoSize = true;
            lbl_plan.ForeColor = Color.Gainsboro;
            lbl_plan.Location = new Point(24, 216);
            lbl_plan.Name = "lbl_plan";
            lbl_plan.Size = new Size(33, 15);
            lbl_plan.TabIndex = 26;
            lbl_plan.Text = "Plan:";
            lbl_plan.Visible = false;
            // 
            // lbl_hsSemanales
            // 
            lbl_hsSemanales.Anchor = AnchorStyles.None;
            lbl_hsSemanales.AutoSize = true;
            lbl_hsSemanales.ForeColor = Color.Gainsboro;
            lbl_hsSemanales.Location = new Point(23, 158);
            lbl_hsSemanales.Name = "lbl_hsSemanales";
            lbl_hsSemanales.Size = new Size(99, 15);
            lbl_hsSemanales.TabIndex = 25;
            lbl_hsSemanales.Text = "Horas semanales:";
            lbl_hsSemanales.Visible = false;
            // 
            // lbl_hsTotales
            // 
            lbl_hsTotales.Anchor = AnchorStyles.None;
            lbl_hsTotales.AutoSize = true;
            lbl_hsTotales.ForeColor = Color.Gainsboro;
            lbl_hsTotales.Location = new Point(24, 188);
            lbl_hsTotales.Name = "lbl_hsTotales";
            lbl_hsTotales.Size = new Size(79, 15);
            lbl_hsTotales.TabIndex = 24;
            lbl_hsTotales.Text = "Horas totales:";
            lbl_hsTotales.Visible = false;
            // 
            // ipb_Usuario
            // 
            ipb_Usuario.Anchor = AnchorStyles.None;
            ipb_Usuario.BackColor = Color.FromArgb(32, 30, 45);
            ipb_Usuario.ForeColor = Color.Gainsboro;
            ipb_Usuario.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            ipb_Usuario.IconColor = Color.Gainsboro;
            ipb_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipb_Usuario.IconSize = 100;
            ipb_Usuario.Location = new Point(284, 18);
            ipb_Usuario.Name = "ipb_Usuario";
            ipb_Usuario.Size = new Size(100, 100);
            ipb_Usuario.TabIndex = 23;
            ipb_Usuario.TabStop = false;
            ipb_Usuario.Visible = false;
            // 
            // lbl_descMateria
            // 
            lbl_descMateria.Anchor = AnchorStyles.None;
            lbl_descMateria.AutoSize = true;
            lbl_descMateria.ForeColor = Color.Gainsboro;
            lbl_descMateria.Location = new Point(23, 129);
            lbl_descMateria.Name = "lbl_descMateria";
            lbl_descMateria.Size = new Size(143, 15);
            lbl_descMateria.TabIndex = 3;
            lbl_descMateria.Text = "Descripcion de la materia:";
            lbl_descMateria.Visible = false;
            // 
            // lbl_Id
            // 
            lbl_Id.Anchor = AnchorStyles.None;
            lbl_Id.AutoSize = true;
            lbl_Id.ForeColor = Color.Gainsboro;
            lbl_Id.Location = new Point(24, 96);
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
            label5.Location = new Point(174, 95);
            label5.Name = "label5";
            label5.Size = new Size(239, 29);
            label5.TabIndex = 38;
            label5.Text = "Consulta de Materias";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(185, 212);
            label1.Name = "label1";
            label1.Size = new Size(232, 17);
            label1.TabIndex = 36;
            label1.Text = "Ingrese el ID de la materia a buscar";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(556, 412);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 35;
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
            btnCancelar.Location = new Point(311, 412);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nud_Id
            // 
            nud_Id.Anchor = AnchorStyles.None;
            nud_Id.Location = new Point(237, 247);
            nud_Id.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nud_Id.Name = "nud_Id";
            nud_Id.Size = new Size(120, 23);
            nud_Id.TabIndex = 40;
            // 
            // FormConsultaMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 562);
            Controls.Add(nud_Id);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormConsultaMaterias";
            Text = "FormConsultaMaterias";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_hsTotales;
        private FontAwesome.Sharp.IconPictureBox ipb_Usuario;
        private Label lbl_descMateria;
        private Label lbl_Id;
        private Label label5;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown nud_Id;
        private Label lbl_plan;
        private Label lbl_hsSemanales;
    }
}