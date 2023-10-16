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
            label2.Location = new Point(274, 275);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
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
            lblMensajeError.Location = new Point(498, 411);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(107, 18);
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
            label5.Location = new Point(150, 51);
            label5.Name = "label5";
            label5.Size = new Size(214, 36);
            label5.TabIndex = 28;
            label5.Text = "Alta de Materia";
            // 
            // txt_descMateria
            // 
            txt_descMateria.Anchor = AnchorStyles.None;
            txt_descMateria.Location = new Point(387, 168);
            txt_descMateria.Margin = new Padding(3, 4, 3, 4);
            txt_descMateria.Name = "txt_descMateria";
            txt_descMateria.Size = new Size(356, 27);
            txt_descMateria.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(189, 171);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
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
            btnAceptar.Location = new Point(605, 475);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
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
            btnCancelar.Location = new Point(326, 475);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
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
            label3.Location = new Point(245, 223);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 32;
            label3.Text = "Horas semanales";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(319, 333);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 34;
            label4.Text = "ID Plan";
            // 
            // nud_hsSemanales
            // 
            nud_hsSemanales.Anchor = AnchorStyles.None;
            nud_hsSemanales.Location = new Point(386, 221);
            nud_hsSemanales.Margin = new Padding(3, 4, 3, 4);
            nud_hsSemanales.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_hsSemanales.Name = "nud_hsSemanales";
            nud_hsSemanales.Size = new Size(137, 27);
            nud_hsSemanales.TabIndex = 36;
            // 
            // nud_horasTotales
            // 
            nud_horasTotales.Anchor = AnchorStyles.None;
            nud_horasTotales.Location = new Point(386, 273);
            nud_horasTotales.Margin = new Padding(3, 4, 3, 4);
            nud_horasTotales.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_horasTotales.Name = "nud_horasTotales";
            nud_horasTotales.Size = new Size(137, 27);
            nud_horasTotales.TabIndex = 37;
            // 
            // nud_idPlan
            // 
            nud_idPlan.Anchor = AnchorStyles.None;
            nud_idPlan.Location = new Point(387, 332);
            nud_idPlan.Margin = new Padding(3, 4, 3, 4);
            nud_idPlan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(137, 27);
            nud_idPlan.TabIndex = 38;
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1061, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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