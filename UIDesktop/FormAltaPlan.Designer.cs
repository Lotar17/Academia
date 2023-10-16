namespace UIDesktop
{
    partial class FormAltaPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaPlan));
            lblMensajeError = new Label();
            label5 = new Label();
            txt_descPlan = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            nud_idEspecialidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_idEspecialidad).BeginInit();
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
            lblMensajeError.Location = new Point(501, 342);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(107, 18);
            lblMensajeError.TabIndex = 21;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(152, 49);
            label5.Name = "label5";
            label5.Size = new Size(176, 36);
            label5.TabIndex = 20;
            label5.Text = "Alta de Plan";
            // 
            // txt_descPlan
            // 
            txt_descPlan.Anchor = AnchorStyles.None;
            txt_descPlan.Location = new Point(414, 207);
            txt_descPlan.Margin = new Padding(3, 4, 3, 4);
            txt_descPlan.Name = "txt_descPlan";
            txt_descPlan.Size = new Size(356, 27);
            txt_descPlan.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(236, 210);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 18;
            label1.Text = "Descripcion del plan";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(607, 473);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(328, 473);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(236, 262);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 22;
            label2.Text = "ID Especialidad";
            // 
            // nud_idEspecialidad
            // 
            nud_idEspecialidad.Anchor = AnchorStyles.None;
            nud_idEspecialidad.Location = new Point(414, 260);
            nud_idEspecialidad.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nud_idEspecialidad.Name = "nud_idEspecialidad";
            nud_idEspecialidad.Size = new Size(150, 27);
            nud_idEspecialidad.TabIndex = 23;
            // 
            // FormAltaPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1061, 600);
            Controls.Add(nud_idEspecialidad);
            Controls.Add(label2);
            Controls.Add(lblMensajeError);
            Controls.Add(label5);
            Controls.Add(txt_descPlan);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAltaPlan";
            Text = "FormAltaPlanes";
            ((System.ComponentModel.ISupportInitialize)nud_idEspecialidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensajeError;
        private Label label5;
        private TextBox txt_descPlan;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private NumericUpDown nud_idEspecialidad;
    }
}