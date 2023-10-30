namespace UIDesktop
{
    partial class FormInscripcionCursos
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
            lbl_Inscripcion = new Label();
            btn_Inscripcion = new Button();
            dgv_Cursos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            materia = new DataGridViewTextBoxColumn();
            comision = new DataGridViewTextBoxColumn();
            anioCalendario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Cursos).BeginInit();
            SuspendLayout();
            // 
            // lbl_Inscripcion
            // 
            lbl_Inscripcion.Anchor = AnchorStyles.None;
            lbl_Inscripcion.AutoSize = true;
            lbl_Inscripcion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Inscripcion.ForeColor = Color.Gainsboro;
            lbl_Inscripcion.Location = new Point(156, 71);
            lbl_Inscripcion.Name = "lbl_Inscripcion";
            lbl_Inscripcion.Size = new Size(230, 29);
            lbl_Inscripcion.TabIndex = 52;
            lbl_Inscripcion.Text = "Inscripcion a Cursos";
            // 
            // btn_Inscripcion
            // 
            btn_Inscripcion.Anchor = AnchorStyles.None;
            btn_Inscripcion.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_Inscripcion.FlatStyle = FlatStyle.Flat;
            btn_Inscripcion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Inscripcion.ForeColor = Color.Gainsboro;
            btn_Inscripcion.Location = new Point(479, 433);
            btn_Inscripcion.Name = "btn_Inscripcion";
            btn_Inscripcion.Size = new Size(142, 56);
            btn_Inscripcion.TabIndex = 53;
            btn_Inscripcion.Text = "Inscribirse";
            btn_Inscripcion.UseVisualStyleBackColor = false;
            btn_Inscripcion.Click += btn_Inscripcion_Click;
            // 
            // dgv_Cursos
            // 
            dgv_Cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cursos.Columns.AddRange(new DataGridViewColumn[] { ID, materia, comision, anioCalendario });
            dgv_Cursos.Location = new Point(256, 153);
            dgv_Cursos.Name = "dgv_Cursos";
            dgv_Cursos.RowTemplate.Height = 25;
            dgv_Cursos.Size = new Size(554, 231);
            dgv_Cursos.TabIndex = 55;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // materia
            // 
            materia.HeaderText = "Materia";
            materia.Name = "materia";
            // 
            // comision
            // 
            comision.HeaderText = "Comision";
            comision.Name = "comision";
            // 
            // anioCalendario
            // 
            anioCalendario.HeaderText = "Año Calendario";
            anioCalendario.Name = "anioCalendario";
            // 
            // FormInscripcionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1140, 603);
            Controls.Add(dgv_Cursos);
            Controls.Add(btn_Inscripcion);
            Controls.Add(lbl_Inscripcion);
            Name = "FormInscripcionCursos";
            Text = "FormInscripcionCursos";
            ((System.ComponentModel.ISupportInitialize)dgv_Cursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Inscripcion;
        private Button btn_Inscripcion;
        private DataGridView dgv_Cursos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn materia;
        private DataGridViewTextBoxColumn comision;
        private DataGridViewTextBoxColumn anioCalendario;
    }
}