namespace UIDesktop
{
    partial class FormAltaComision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaComision));
            nud_idPlan = new NumericUpDown();
            nud_anioEspecialidad = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            lblMensajeError = new Label();
            label5 = new Label();
            txt_descComision = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_anioEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // nud_idPlan
            // 
            nud_idPlan.Anchor = AnchorStyles.None;
            nud_idPlan.Location = new Point(402, 239);
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(120, 23);
            nud_idPlan.TabIndex = 50;
            // 
            // nud_anioEspecialidad
            // 
            nud_anioEspecialidad.Anchor = AnchorStyles.None;
            nud_anioEspecialidad.Location = new Point(402, 201);
            nud_anioEspecialidad.Name = "nud_anioEspecialidad";
            nud_anioEspecialidad.Size = new Size(120, 23);
            nud_anioEspecialidad.TabIndex = 48;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(336, 240);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 47;
            label4.Text = "ID Plan";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(277, 202);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 46;
            label3.Text = "Año Especialidad";
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(428, 345);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(88, 15);
            lblMensajeError.TabIndex = 44;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(194, 73);
            label5.Name = "label5";
            label5.Size = new Size(195, 29);
            label5.TabIndex = 43;
            label5.Text = "Alta de Comision";
            // 
            // txt_descComision
            // 
            txt_descComision.Anchor = AnchorStyles.None;
            txt_descComision.Location = new Point(402, 161);
            txt_descComision.Name = "txt_descComision";
            txt_descComision.Size = new Size(312, 23);
            txt_descComision.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(219, 163);
            label1.Name = "label1";
            label1.Size = new Size(176, 17);
            label1.TabIndex = 41;
            label1.Text = "Descripcion de la comision";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(521, 393);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 40;
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
            btnCancelar.Location = new Point(277, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAltaComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1027, 532);
            Controls.Add(nud_idPlan);
            Controls.Add(nud_anioEspecialidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMensajeError);
            Controls.Add(label5);
            Controls.Add(txt_descComision);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAltaComision";
            Text = "FormAltaComision";
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_anioEspecialidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_idPlan;
        private NumericUpDown nud_anioEspecialidad;
        private Label label4;
        private Label label3;
        private Label lblMensajeError;
        private Label label5;
        private TextBox txt_descComision;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}