namespace UIDesktop
{
    partial class FormConsultaPlanes
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
            label5 = new Label();
            txt_Id = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            lbl_especialidad = new Label();
            ipb_Usuario = new FontAwesome.Sharp.IconPictureBox();
            lbl_descPlan = new Label();
            lbl_Id = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(240, 133);
            label5.Name = "label5";
            label5.Size = new Size(273, 36);
            label5.TabIndex = 32;
            label5.Text = "Consulta de Planes";
            // 
            // txt_Id
            // 
            txt_Id.Anchor = AnchorStyles.None;
            txt_Id.Location = new Point(253, 332);
            txt_Id.Margin = new Padding(3, 4, 3, 4);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(251, 27);
            txt_Id.TabIndex = 31;
            txt_Id.KeyPress += txt_Id_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(253, 289);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 30;
            label1.Text = "Ingrese el ID del plan a buscar";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(677, 556);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(397, 556);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_especialidad);
            panel1.Controls.Add(ipb_Usuario);
            panel1.Controls.Add(lbl_descPlan);
            panel1.Controls.Add(lbl_Id);
            panel1.Location = new Point(648, 133);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 340);
            panel1.TabIndex = 33;
            panel1.Visible = false;
            // 
            // lbl_especialidad
            // 
            lbl_especialidad.Anchor = AnchorStyles.None;
            lbl_especialidad.AutoSize = true;
            lbl_especialidad.ForeColor = Color.Gainsboro;
            lbl_especialidad.Location = new Point(27, 279);
            lbl_especialidad.Name = "lbl_especialidad";
            lbl_especialidad.Size = new Size(96, 20);
            lbl_especialidad.TabIndex = 24;
            lbl_especialidad.Text = "Especialidad:";
            lbl_especialidad.Visible = false;
            // 
            // ipb_Usuario
            // 
            ipb_Usuario.Anchor = AnchorStyles.None;
            ipb_Usuario.BackColor = Color.FromArgb(32, 30, 45);
            ipb_Usuario.ForeColor = Color.Gainsboro;
            ipb_Usuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ipb_Usuario.IconColor = Color.Gainsboro;
            ipb_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipb_Usuario.IconSize = 114;
            ipb_Usuario.Location = new Point(313, 26);
            ipb_Usuario.Margin = new Padding(3, 4, 3, 4);
            ipb_Usuario.Name = "ipb_Usuario";
            ipb_Usuario.Size = new Size(114, 133);
            ipb_Usuario.TabIndex = 23;
            ipb_Usuario.TabStop = false;
            ipb_Usuario.Visible = false;
            // 
            // lbl_descPlan
            // 
            lbl_descPlan.Anchor = AnchorStyles.None;
            lbl_descPlan.AutoSize = true;
            lbl_descPlan.ForeColor = Color.Gainsboro;
            lbl_descPlan.Location = new Point(27, 239);
            lbl_descPlan.Name = "lbl_descPlan";
            lbl_descPlan.Size = new Size(148, 20);
            lbl_descPlan.TabIndex = 3;
            lbl_descPlan.Text = "Descripcion del plan:";
            lbl_descPlan.Visible = false;
            // 
            // lbl_Id
            // 
            lbl_Id.Anchor = AnchorStyles.None;
            lbl_Id.AutoSize = true;
            lbl_Id.ForeColor = Color.Gainsboro;
            lbl_Id.Location = new Point(27, 197);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(27, 20);
            lbl_Id.TabIndex = 0;
            lbl_Id.Text = "ID:";
            lbl_Id.Visible = false;
            // 
            // FormConsultaPlanes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 749);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txt_Id);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormConsultaPlanes";
            Text = "FormConsultaPlanes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txt_Id;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Panel panel1;
        private Label lbl_especialidad;
        private FontAwesome.Sharp.IconPictureBox ipb_Usuario;
        private Label lbl_descPlan;
        private Label lbl_Id;
    }
}