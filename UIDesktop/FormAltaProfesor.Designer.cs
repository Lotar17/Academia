namespace UIDesktop
{
    partial class FormAltaProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaProfesor));
            dtp_fechaNac = new DateTimePicker();
            txt_legajo = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_apellido = new TextBox();
            label3 = new Label();
            lblMensajeError = new Label();
            txt_email = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Anchor = AnchorStyles.None;
            dtp_fechaNac.Location = new Point(347, 239);
            dtp_fechaNac.Margin = new Padding(3, 2, 3, 2);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(219, 23);
            dtp_fechaNac.TabIndex = 60;
            dtp_fechaNac.Value = new DateTime(2023, 10, 5, 19, 16, 51, 0);
            // 
            // txt_legajo
            // 
            txt_legajo.Anchor = AnchorStyles.None;
            txt_legajo.Location = new Point(347, 264);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(312, 23);
            txt_legajo.TabIndex = 57;
            txt_legajo.KeyPress += txt_legajo_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(198, 264);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 56;
            label8.Text = "Legajo";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(198, 238);
            label6.Name = "label6";
            label6.Size = new Size(139, 17);
            label6.TabIndex = 55;
            label6.Text = "Fecha de nacimiento";
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.None;
            txt_telefono.Location = new Point(347, 212);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(312, 23);
            txt_telefono.TabIndex = 54;
            txt_telefono.KeyPress += txt_telefono_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(198, 214);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 53;
            label4.Text = "Telefono";
            // 
            // txt_apellido
            // 
            txt_apellido.Anchor = AnchorStyles.None;
            txt_apellido.Location = new Point(347, 133);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(312, 23);
            txt_apellido.TabIndex = 52;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(198, 133);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 51;
            label3.Text = "Apellido";
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(422, 314);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(88, 15);
            lblMensajeError.TabIndex = 50;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Location = new Point(347, 186);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(312, 23);
            txt_email.TabIndex = 49;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(198, 186);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 48;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(119, 54);
            label5.Name = "label5";
            label5.Size = new Size(185, 29);
            label5.TabIndex = 47;
            label5.Text = "Alta de Profesor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(198, 160);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 46;
            label2.Text = "Direccion";
            // 
            // txt_direccion
            // 
            txt_direccion.Anchor = AnchorStyles.None;
            txt_direccion.Location = new Point(347, 160);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(312, 23);
            txt_direccion.TabIndex = 45;
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.Location = new Point(347, 107);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(312, 23);
            txt_nombre.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(198, 107);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 43;
            label1.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(517, 372);
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
            btnCancelar.Location = new Point(273, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAltaProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(928, 450);
            Controls.Add(dtp_fechaNac);
            Controls.Add(txt_legajo);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_apellido);
            Controls.Add(label3);
            Controls.Add(lblMensajeError);
            Controls.Add(txt_email);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txt_direccion);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAltaProfesor";
            Text = "FormAltaProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_fechaNac;
        private TextBox txt_legajo;
        private Label label8;
        private Label label6;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_apellido;
        private Label label3;
        private Label lblMensajeError;
        private TextBox txt_email;
        private Label label7;
        private Label label5;
        private Label label2;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}