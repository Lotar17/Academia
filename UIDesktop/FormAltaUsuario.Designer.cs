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
            label1.Location = new Point(137, 87);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Usuario";
            label1.Click += label1_Click;
            // 
            // txt_userName
            // 
            txt_userName.Anchor = AnchorStyles.None;
            txt_userName.Location = new Point(274, 85);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(312, 23);
            txt_userName.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(274, 124);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(312, 23);
            txt_pass.TabIndex = 4;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_Name
            // 
            txt_Name.Anchor = AnchorStyles.None;
            txt_Name.Location = new Point(274, 164);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(312, 23);
            txt_Name.TabIndex = 5;
            // 
            // txt_lastName
            // 
            txt_lastName.Anchor = AnchorStyles.None;
            txt_lastName.Location = new Point(274, 202);
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
            label2.Location = new Point(191, 124);
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
            label3.Location = new Point(191, 164);
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
            label4.Location = new Point(191, 204);
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
            txt_Email.Location = new Point(274, 240);
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
            label6.Location = new Point(191, 242);
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
            label7.Location = new Point(171, 279);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 13;
            label7.Text = "ID Persona";
            // 
            // txt_idPersona
            // 
            txt_idPersona.Anchor = AnchorStyles.None;
            txt_idPersona.Location = new Point(274, 277);
            txt_idPersona.Name = "txt_idPersona";
            txt_idPersona.Size = new Size(312, 23);
            txt_idPersona.TabIndex = 14;
            // 
            // FormAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(777, 418);
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
    }
}