namespace UIDesktop
{
    partial class FormAltaCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaCurso));
            label2 = new Label();
            lblMensajeError = new Label();
            label5 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            label4 = new Label();
            nud_idMateria = new NumericUpDown();
            nud_idComision = new NumericUpDown();
            nud_cupo = new NumericUpDown();
            nud_anioCalendario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_idMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_idComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cupo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_anioCalendario).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(349, 189);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 30;
            label2.Text = "ID Comision";
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(421, 323);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(88, 15);
            lblMensajeError.TabIndex = 29;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(163, 79);
            label5.Name = "label5";
            label5.Size = new Size(157, 29);
            label5.TabIndex = 28;
            label5.Text = "Alta de Curso";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(349, 151);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 26;
            label1.Text = "ID Materia";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(523, 395);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 25;
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
            btnCancelar.Location = new Point(279, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(349, 229);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 32;
            label3.Text = "Año Calendario";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(349, 265);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 34;
            label4.Text = "Cupo";
            // 
            // nud_idMateria
            // 
            nud_idMateria.Anchor = AnchorStyles.None;
            nud_idMateria.Location = new Point(472, 150);
            nud_idMateria.Name = "nud_idMateria";
            nud_idMateria.Size = new Size(120, 23);
            nud_idMateria.TabIndex = 35;
            // 
            // nud_idComision
            // 
            nud_idComision.Anchor = AnchorStyles.None;
            nud_idComision.Location = new Point(472, 188);
            nud_idComision.Name = "nud_idComision";
            nud_idComision.Size = new Size(120, 23);
            nud_idComision.TabIndex = 36;
            // 
            // nud_cupo
            // 
            nud_cupo.Anchor = AnchorStyles.None;
            nud_cupo.Location = new Point(472, 264);
            nud_cupo.Name = "nud_cupo";
            nud_cupo.Size = new Size(120, 23);
            nud_cupo.TabIndex = 37;
            // 
            // nud_anioCalendario
            // 
            nud_anioCalendario.Anchor = AnchorStyles.None;
            nud_anioCalendario.Location = new Point(472, 228);
            nud_anioCalendario.Name = "nud_anioCalendario";
            nud_anioCalendario.Size = new Size(120, 23);
            nud_anioCalendario.TabIndex = 38;
            // 
            // FormAltaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(970, 538);
            Controls.Add(nud_anioCalendario);
            Controls.Add(nud_cupo);
            Controls.Add(nud_idComision);
            Controls.Add(nud_idMateria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMensajeError);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAltaCurso";
            Text = "FormAltaCurso";
            ((System.ComponentModel.ISupportInitialize)nud_idMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_idComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cupo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_anioCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblMensajeError;
        private Label label5;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label3;
        private Label label4;
        private NumericUpDown nud_idMateria;
        private NumericUpDown nud_idComision;
        private NumericUpDown nud_cupo;
        private NumericUpDown nud_anioCalendario;
    }
}