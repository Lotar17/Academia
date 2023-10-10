namespace UIDesktop
{
    partial class FormAltaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaMateria));
            label2 = new Label();
            lblMensajeError = new Label();
            label5 = new Label();
            txt_descMateria = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            label4 = new Label();
            nud_hsSemanales = new NumericUpDown();
            nud_horasTotales = new NumericUpDown();
            nud_idPlan = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_hsSemanales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_horasTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(240, 206);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 30;
            label2.Text = "Horas totales";
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(436, 308);
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
            label5.Location = new Point(131, 38);
            label5.Name = "label5";
            label5.Size = new Size(173, 29);
            label5.TabIndex = 28;
            label5.Text = "Alta de Materia";
            // 
            // txt_descMateria
            // 
            txt_descMateria.Anchor = AnchorStyles.None;
            txt_descMateria.Location = new Point(339, 126);
            txt_descMateria.Name = "txt_descMateria";
            txt_descMateria.Size = new Size(312, 23);
            txt_descMateria.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(165, 128);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 26;
            label1.Text = "Descripcion de la materia";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(529, 356);
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
            btnCancelar.Location = new Point(285, 356);
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
            label3.Location = new Point(214, 167);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 32;
            label3.Text = "Horas semanales";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(279, 250);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 34;
            label4.Text = "ID Plan";
            // 
            // nud_hsSemanales
            // 
            nud_hsSemanales.Location = new Point(338, 166);
            nud_hsSemanales.Name = "nud_hsSemanales";
            nud_hsSemanales.Size = new Size(120, 23);
            nud_hsSemanales.TabIndex = 36;
            // 
            // nud_horasTotales
            // 
            nud_horasTotales.Location = new Point(338, 205);
            nud_horasTotales.Name = "nud_horasTotales";
            nud_horasTotales.Size = new Size(120, 23);
            nud_horasTotales.TabIndex = 37;
            // 
            // nud_idPlan
            // 
            nud_idPlan.Location = new Point(339, 249);
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(120, 23);
            nud_idPlan.TabIndex = 38;
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(928, 450);
            Controls.Add(nud_idPlan);
            Controls.Add(nud_horasTotales);
            Controls.Add(nud_hsSemanales);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMensajeError);
            Controls.Add(label5);
            Controls.Add(txt_descMateria);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAltaMateria";
            Text = "FormAltaMateria";
            ((System.ComponentModel.ISupportInitialize)nud_hsSemanales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_horasTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblMensajeError;
        private Label label5;
        private TextBox txt_descMateria;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label3;
        private Label label4;
        private NumericUpDown nud_hsSemanales;
        private NumericUpDown nud_horasTotales;
        private NumericUpDown nud_idPlan;
    }
}