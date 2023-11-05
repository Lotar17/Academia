namespace UIDesktop
{
    partial class FormConsultaComisiones
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
            lbl_plan = new Label();
            lbl_anioEspecialidad = new Label();
            ipb_Usuario = new FontAwesome.Sharp.IconPictureBox();
            lbl_descComision = new Label();
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
            nud_Id.Location = new Point(203, 248);
            nud_Id.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nud_Id.Name = "nud_Id";
            nud_Id.Size = new Size(120, 23);
            nud_Id.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_plan);
            panel1.Controls.Add(lbl_anioEspecialidad);
            panel1.Controls.Add(ipb_Usuario);
            panel1.Controls.Add(lbl_descComision);
            panel1.Controls.Add(lbl_Id);
            panel1.Location = new Point(497, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 256);
            panel1.TabIndex = 45;
            panel1.Visible = false;
            // 
            // lbl_plan
            // 
            lbl_plan.Anchor = AnchorStyles.None;
            lbl_plan.AutoSize = true;
            lbl_plan.ForeColor = Color.Gainsboro;
            lbl_plan.Location = new Point(23, 189);
            lbl_plan.Name = "lbl_plan";
            lbl_plan.Size = new Size(33, 15);
            lbl_plan.TabIndex = 26;
            lbl_plan.Text = "Plan:";
            lbl_plan.Visible = false;
            // 
            // lbl_anioEspecialidad
            // 
            lbl_anioEspecialidad.Anchor = AnchorStyles.None;
            lbl_anioEspecialidad.AutoSize = true;
            lbl_anioEspecialidad.ForeColor = Color.Gainsboro;
            lbl_anioEspecialidad.Location = new Point(23, 162);
            lbl_anioEspecialidad.Name = "lbl_anioEspecialidad";
            lbl_anioEspecialidad.Size = new Size(100, 15);
            lbl_anioEspecialidad.TabIndex = 25;
            lbl_anioEspecialidad.Text = "Año Especialidad:";
            lbl_anioEspecialidad.Visible = false;
            // 
            // ipb_Usuario
            // 
            ipb_Usuario.Anchor = AnchorStyles.None;
            ipb_Usuario.BackColor = Color.FromArgb(32, 30, 45);
            ipb_Usuario.ForeColor = Color.Gainsboro;
            ipb_Usuario.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            ipb_Usuario.IconColor = Color.Gainsboro;
            ipb_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipb_Usuario.IconSize = 100;
            ipb_Usuario.Location = new Point(296, 15);
            ipb_Usuario.Name = "ipb_Usuario";
            ipb_Usuario.Size = new Size(100, 100);
            ipb_Usuario.TabIndex = 23;
            ipb_Usuario.TabStop = false;
            ipb_Usuario.Visible = false;
            // 
            // lbl_descComision
            // 
            lbl_descComision.Anchor = AnchorStyles.None;
            lbl_descComision.AutoSize = true;
            lbl_descComision.ForeColor = Color.Gainsboro;
            lbl_descComision.Location = new Point(23, 133);
            lbl_descComision.Name = "lbl_descComision";
            lbl_descComision.Size = new Size(152, 15);
            lbl_descComision.TabIndex = 3;
            lbl_descComision.Text = "Descripcion de la comision:";
            lbl_descComision.Visible = false;
            // 
            // lbl_Id
            // 
            lbl_Id.Anchor = AnchorStyles.None;
            lbl_Id.AutoSize = true;
            lbl_Id.ForeColor = Color.Gainsboro;
            lbl_Id.Location = new Point(24, 100);
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
            label5.Location = new Point(132, 96);
            label5.Name = "label5";
            label5.Size = new Size(275, 29);
            label5.TabIndex = 44;
            label5.Text = "Consulta de Comisiones";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(151, 213);
            label1.Name = "label1";
            label1.Size = new Size(240, 17);
            label1.TabIndex = 43;
            label1.Text = "Ingrese el ID de la comision a buscar";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(522, 413);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 42;
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
            btnCancelar.Location = new Point(277, 413);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormConsultaComisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1054, 565);
            Controls.Add(nud_Id);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormConsultaComisiones";
            Text = "FormConsultaComisiones";
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
        private Label lbl_plan;
        private Label lbl_anioEspecialidad;
        private FontAwesome.Sharp.IconPictureBox ipb_Usuario;
        private Label lbl_descComision;
        private Label lbl_Id;
        private Label label5;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}