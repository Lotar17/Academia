namespace UIDesktop
{
    partial class FormAltaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaAlumno));
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
            txt_apellido = new TextBox();
            label3 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            dtp_fechaNac = new DateTimePicker();
            label9 = new Label();
            nud_idPlan = new NumericUpDown();
            nud_legajo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_legajo).BeginInit();
            SuspendLayout();
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(494, 425);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(107, 18);
            lblMensajeError.TabIndex = 27;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Location = new Point(409, 229);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(356, 27);
            txt_email.TabIndex = 26;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(239, 229);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 25;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(149, 53);
            label5.Name = "label5";
            label5.Size = new Size(218, 36);
            label5.TabIndex = 24;
            label5.Text = "Alta de Alumno";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(239, 195);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 23;
            label2.Text = "Direccion";
            // 
            // txt_direccion
            // 
            txt_direccion.Anchor = AnchorStyles.None;
            txt_direccion.Location = new Point(409, 195);
            txt_direccion.Margin = new Padding(3, 4, 3, 4);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(356, 27);
            txt_direccion.TabIndex = 22;
            txt_direccion.UseSystemPasswordChar = true;
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.Location = new Point(409, 124);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(356, 27);
            txt_nombre.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(239, 124);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(603, 477);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
            btnAceptar.TabIndex = 19;
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
            btnCancelar.Location = new Point(325, 477);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txt_apellido
            // 
            txt_apellido.Anchor = AnchorStyles.None;
            txt_apellido.Location = new Point(409, 159);
            txt_apellido.Margin = new Padding(3, 4, 3, 4);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(356, 27);
            txt_apellido.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(239, 159);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 30;
            label3.Text = "Apellido";
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.None;
            txt_telefono.Location = new Point(409, 264);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(356, 27);
            txt_telefono.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(239, 267);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 32;
            label4.Text = "Telefono";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(239, 299);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 34;
            label6.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(239, 333);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 36;
            label8.Text = "Legajo";
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Anchor = AnchorStyles.None;
            dtp_fechaNac.Location = new Point(409, 300);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(250, 27);
            dtp_fechaNac.TabIndex = 40;
            dtp_fechaNac.Value = new DateTime(2023, 10, 5, 19, 16, 51, 0);
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(239, 369);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 38;
            label9.Text = "ID Plan";
            // 
            // nud_idPlan
            // 
            nud_idPlan.Anchor = AnchorStyles.None;
            nud_idPlan.Location = new Point(408, 365);
            nud_idPlan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(150, 27);
            nud_idPlan.TabIndex = 41;
            // 
            // nud_legajo
            // 
            nud_legajo.Anchor = AnchorStyles.None;
            nud_legajo.Location = new Point(408, 333);
            nud_legajo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_legajo.Name = "nud_legajo";
            nud_legajo.Size = new Size(150, 27);
            nud_legajo.TabIndex = 42;
            // 
            // FormAltaAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1061, 600);
            Controls.Add(nud_legajo);
            Controls.Add(nud_idPlan);
            Controls.Add(dtp_fechaNac);
            Controls.Add(label9);
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
            Name = "FormAltaAlumno";
            Text = "FormAltaAlumno";
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_legajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox txt_apellido;
        private Label label3;
        private TextBox txt_telefono;
        private Label label4;
        private Label label6;
        private Label label8;
        private DateTimePicker dtp_fechaNac;
        private Label label9;
        private NumericUpDown nud_idPlan;
        private NumericUpDown nud_legajo;
    }
}