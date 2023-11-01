namespace UIDesktop
{
    partial class FormDocentesCursos
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
            dgv_Cursos = new DataGridView();
            btn_Inscripcion = new Button();
            lbl_Inscripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Cursos).BeginInit();
            SuspendLayout();
            // 
            // dgv_Cursos
            // 
            dgv_Cursos.AllowUserToAddRows = false;
            dgv_Cursos.AllowUserToDeleteRows = false;
            dgv_Cursos.AllowUserToResizeRows = false;
            dgv_Cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cursos.Location = new Point(120, 120);
            dgv_Cursos.Name = "dgv_Cursos";
            dgv_Cursos.RowTemplate.Height = 25;
            dgv_Cursos.Size = new Size(683, 231);
            dgv_Cursos.TabIndex = 58;
            // 
            // btn_Inscripcion
            // 
            btn_Inscripcion.Anchor = AnchorStyles.None;
            btn_Inscripcion.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_Inscripcion.FlatStyle = FlatStyle.Flat;
            btn_Inscripcion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Inscripcion.ForeColor = Color.Gainsboro;
            btn_Inscripcion.Location = new Point(381, 408);
            btn_Inscripcion.Name = "btn_Inscripcion";
            btn_Inscripcion.Size = new Size(142, 56);
            btn_Inscripcion.TabIndex = 57;
            btn_Inscripcion.Text = "Inscribirse";
            btn_Inscripcion.UseVisualStyleBackColor = false;
            btn_Inscripcion.Click += btn_Inscripcion_Click;
            // 
            // lbl_Inscripcion
            // 
            lbl_Inscripcion.Anchor = AnchorStyles.None;
            lbl_Inscripcion.AutoSize = true;
            lbl_Inscripcion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Inscripcion.ForeColor = Color.Gainsboro;
            lbl_Inscripcion.Location = new Point(98, 46);
            lbl_Inscripcion.Name = "lbl_Inscripcion";
            lbl_Inscripcion.Size = new Size(230, 29);
            lbl_Inscripcion.TabIndex = 56;
            lbl_Inscripcion.Text = "Inscripcion a Cursos";
            // 
            // FormDocentesCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(900, 540);
            Controls.Add(dgv_Cursos);
            Controls.Add(btn_Inscripcion);
            Controls.Add(lbl_Inscripcion);
            Name = "FormDocentesCursos";
            Text = "FormDocentesCursos";
            ((System.ComponentModel.ISupportInitialize)dgv_Cursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Cursos;
        private Button btn_Inscripcion;
        private Label lbl_Inscripcion;
    }
}