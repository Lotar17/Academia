namespace Academia
{
    partial class FormAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaUsuario));
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            txt_userName = new TextBox();
            txt_pass = new TextBox();
            txt_Name = new TextBox();
            txt_lastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Email = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txt_idPersona = new TextBox();
            lblMensajeError = new Label();
            label8 = new Label();
            cbx_Habilitado = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(200, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(444, 334);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(137, 69);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Usuario";
            label1.Click += label1_Click;
            // 
            // txt_userName
            // 
            txt_userName.Anchor = AnchorStyles.None;
            txt_userName.Location = new Point(274, 69);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(312, 23);
            txt_userName.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(274, 109);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(312, 23);
            txt_pass.TabIndex = 4;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_Name
            // 
            txt_Name.Anchor = AnchorStyles.None;
            txt_Name.Location = new Point(274, 149);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(312, 23);
            txt_Name.TabIndex = 5;
            // 
            // txt_lastName
            // 
            txt_lastName.Anchor = AnchorStyles.None;
            txt_lastName.Location = new Point(274, 188);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(312, 23);
            txt_lastName.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(206, 111);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 7;
            label2.Text = "Clave";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(200, 151);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(200, 190);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 9;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(46, 16);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 10;
            label5.Text = "Alta de Usuario";
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.None;
            txt_Email.Location = new Point(274, 229);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(312, 23);
            txt_Email.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(207, 229);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(180, 265);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 13;
            label7.Text = "ID Persona";
            // 
            // txt_idPersona
            // 
            txt_idPersona.Anchor = AnchorStyles.None;
            txt_idPersona.Location = new Point(274, 265);
            txt_idPersona.Name = "txt_idPersona";
            txt_idPersona.Size = new Size(312, 23);
            txt_idPersona.TabIndex = 14;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(498, 306);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(88, 15);
            lblMensajeError.TabIndex = 15;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(187, 300);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 16;
            label8.Text = "Habilitado";
            label8.Click += label8_Click;
            // 
            // cbx_Habilitado
            // 
            cbx_Habilitado.FormattingEnabled = true;
            cbx_Habilitado.Items.AddRange(new object[] { "Si", "No" });
            cbx_Habilitado.Location = new Point(274, 298);
            cbx_Habilitado.Name = "cbx_Habilitado";
            cbx_Habilitado.Size = new Size(121, 23);
            cbx_Habilitado.TabIndex = 17;
            // 
            // FormAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(777, 418);
            Controls.Add(cbx_Habilitado);
            Controls.Add(label8);
            Controls.Add(lblMensajeError);
            Controls.Add(txt_idPersona);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_Email);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_lastName);
            Controls.Add(txt_Name);
            Controls.Add(txt_pass);
            Controls.Add(txt_userName);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAltaUsuario";
            Text = "Alta de Usuario";
            Load += FormAltaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label label1;
        private TextBox txt_userName;
        private TextBox txt_pass;
        private TextBox txt_Name;
        private TextBox txt_lastName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Email;
        private Label label6;
        private Label label7;
        private TextBox txt_idPersona;
        private Label lblMensajeError;
        private Label label8;
        private ComboBox cbx_Habilitado;
    }
}