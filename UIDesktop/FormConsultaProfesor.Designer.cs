namespace UIDesktop
{
    partial class FormConsultaProfesor
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
            lbl_legajo = new Label();
            lbl_fechaNac = new Label();
            lbl_email = new Label();
            lbl_telefono = new Label();
            lbl_direccion = new Label();
            lbl_nombreapellido = new Label();
            ipb_Usuario = new FontAwesome.Sharp.IconPictureBox();
            lbl_Id = new Label();
            label5 = new Label();
            txt_Id = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_legajo);
            panel1.Controls.Add(lbl_fechaNac);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(lbl_telefono);
            panel1.Controls.Add(lbl_direccion);
            panel1.Controls.Add(lbl_nombreapellido);
            panel1.Controls.Add(ipb_Usuario);
            panel1.Controls.Add(lbl_Id);
            panel1.Location = new Point(513, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 255);
            panel1.TabIndex = 40;
            panel1.Visible = false;
            // 
            // lbl_legajo
            // 
            lbl_legajo.Anchor = AnchorStyles.None;
            lbl_legajo.AutoSize = true;
            lbl_legajo.ForeColor = Color.Gainsboro;
            lbl_legajo.Location = new Point(20, 205);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(45, 15);
            lbl_legajo.TabIndex = 30;
            lbl_legajo.Text = "Legajo:";
            lbl_legajo.Visible = false;
            // 
            // lbl_fechaNac
            // 
            lbl_fechaNac.Anchor = AnchorStyles.None;
            lbl_fechaNac.AutoSize = true;
            lbl_fechaNac.ForeColor = Color.Gainsboro;
            lbl_fechaNac.Location = new Point(20, 178);
            lbl_fechaNac.Name = "lbl_fechaNac";
            lbl_fechaNac.Size = new Size(122, 15);
            lbl_fechaNac.TabIndex = 29;
            lbl_fechaNac.Text = "Fecha de Nacimiento:";
            lbl_fechaNac.Visible = false;
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.None;
            lbl_email.AutoSize = true;
            lbl_email.ForeColor = Color.Gainsboro;
            lbl_email.Location = new Point(20, 126);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(39, 15);
            lbl_email.TabIndex = 28;
            lbl_email.Text = "Email:";
            lbl_email.Visible = false;
            // 
            // lbl_telefono
            // 
            lbl_telefono.Anchor = AnchorStyles.None;
            lbl_telefono.AutoSize = true;
            lbl_telefono.ForeColor = Color.Gainsboro;
            lbl_telefono.Location = new Point(20, 151);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(55, 15);
            lbl_telefono.TabIndex = 27;
            lbl_telefono.Text = "Telefono:";
            lbl_telefono.Visible = false;
            // 
            // lbl_direccion
            // 
            lbl_direccion.Anchor = AnchorStyles.None;
            lbl_direccion.AutoSize = true;
            lbl_direccion.ForeColor = Color.Gainsboro;
            lbl_direccion.Location = new Point(20, 100);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(60, 15);
            lbl_direccion.TabIndex = 26;
            lbl_direccion.Text = "Direccion:";
            lbl_direccion.Visible = false;
            // 
            // lbl_nombreapellido
            // 
            lbl_nombreapellido.Anchor = AnchorStyles.None;
            lbl_nombreapellido.AutoSize = true;
            lbl_nombreapellido.ForeColor = Color.Gainsboro;
            lbl_nombreapellido.Location = new Point(20, 76);
            lbl_nombreapellido.Name = "lbl_nombreapellido";
            lbl_nombreapellido.Size = new Size(110, 15);
            lbl_nombreapellido.TabIndex = 25;
            lbl_nombreapellido.Text = "Nombre y Apellido:";
            lbl_nombreapellido.Visible = false;
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
            ipb_Usuario.Location = new Point(302, 27);
            ipb_Usuario.Name = "ipb_Usuario";
            ipb_Usuario.Size = new Size(100, 100);
            ipb_Usuario.TabIndex = 23;
            ipb_Usuario.TabStop = false;
            ipb_Usuario.Visible = false;
            // 
            // lbl_Id
            // 
            lbl_Id.Anchor = AnchorStyles.None;
            lbl_Id.AutoSize = true;
            lbl_Id.ForeColor = Color.Gainsboro;
            lbl_Id.Location = new Point(20, 52);
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
            label5.Location = new Point(132, 91);
            label5.Name = "label5";
            label5.Size = new Size(265, 29);
            label5.TabIndex = 39;
            label5.Text = "Consulta de Profesores";
            // 
            // txt_Id
            // 
            txt_Id.Anchor = AnchorStyles.None;
            txt_Id.Location = new Point(160, 241);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(220, 23);
            txt_Id.TabIndex = 38;
            txt_Id.KeyPress += txt_Id_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(160, 205);
            label1.Name = "label1";
            label1.Size = new Size(230, 17);
            label1.TabIndex = 37;
            label1.Text = "Ingrese el ID del profesor a buscar:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(561, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 36;
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
            btnCancelar.Location = new Point(316, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormConsultaProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 562);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txt_Id);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormConsultaProfesor";
            Text = "FormConsultaProfesor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_legajo;
        private Label lbl_fechaNac;
        private Label lbl_email;
        private Label lbl_telefono;
        private Label lbl_direccion;
        private Label lbl_nombreapellido;
        private FontAwesome.Sharp.IconPictureBox ipb_Usuario;
        private Label lbl_Id;
        private Label label5;
        private TextBox txt_Id;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}