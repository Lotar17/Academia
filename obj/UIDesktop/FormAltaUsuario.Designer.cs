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
            label2 = new Label();
            label5 = new Label();
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
            btnCancelar.Location = new Point(343, 429);
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
            btnAceptar.Location = new Point(587, 429);
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
            label1.Location = new Point(280, 164);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Usuario";
            label1.Click += label1_Click;
            // 
            // txt_userName
            // 
            txt_userName.Anchor = AnchorStyles.None;
            txt_userName.Location = new Point(417, 164);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(312, 23);
            txt_userName.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(417, 204);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(312, 23);
            txt_pass.TabIndex = 4;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(349, 206);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 7;
            label2.Text = "Clave";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(189, 111);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 10;
            label5.Text = "Alta de Usuario";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(323, 247);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 13;
            label7.Text = "ID Persona";
            // 
            // txt_idPersona
            // 
            txt_idPersona.Anchor = AnchorStyles.None;
            txt_idPersona.Location = new Point(417, 247);
            txt_idPersona.Name = "txt_idPersona";
            txt_idPersona.Size = new Size(312, 23);
            txt_idPersona.TabIndex = 14;
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(343, 347);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(140, 25);
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
            label8.Location = new Point(330, 282);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 16;
            label8.Text = "Habilitado";
            label8.Click += label8_Click;
            // 
            // cbx_Habilitado
            // 
            cbx_Habilitado.Anchor = AnchorStyles.None;
            cbx_Habilitado.FormattingEnabled = true;
            cbx_Habilitado.Items.AddRange(new object[] { "Si", "No" });
            cbx_Habilitado.Location = new Point(417, 280);
            cbx_Habilitado.Name = "cbx_Habilitado";
            cbx_Habilitado.Size = new Size(121, 23);
            cbx_Habilitado.TabIndex = 17;
            // 
            // FormAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 608);
            Controls.Add(cbx_Habilitado);
            Controls.Add(label8);
            Controls.Add(lblMensajeError);
            Controls.Add(txt_idPersona);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
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
        private Label label2;
        private Label label5;
        private Label label7;
        private TextBox txt_idPersona;
        private Label lblMensajeError;
        private Label label8;
        private ComboBox cbx_Habilitado;
    }
}