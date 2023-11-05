namespace UIDesktop
{
    partial class FormReporteCursos
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            btnImprimir = new Button();
            dgv_Cursos = new DataGridView();
            lbl_Reporte = new Label();
            lbl_DescEspecialidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Cursos).BeginInit();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.None;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Gainsboro;
            btnImprimir.Location = new Point(436, 380);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(142, 56);
            btnImprimir.TabIndex = 12;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dgv_Cursos
            // 
            dgv_Cursos.AllowUserToAddRows = false;
            dgv_Cursos.AllowUserToDeleteRows = false;
            dgv_Cursos.AllowUserToOrderColumns = true;
            dgv_Cursos.AllowUserToResizeColumns = false;
            dgv_Cursos.AllowUserToResizeRows = false;
            dgv_Cursos.Anchor = AnchorStyles.None;
            dgv_Cursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Cursos.BackgroundColor = Color.FromArgb(32, 30, 45);
            dgv_Cursos.BorderStyle = BorderStyle.Fixed3D;
            dgv_Cursos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Transparent;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Cursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Transparent;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_Cursos.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_Cursos.EnableHeadersVisualStyles = false;
            dgv_Cursos.GridColor = Color.Gainsboro;
            dgv_Cursos.Location = new Point(273, 137);
            dgv_Cursos.MultiSelect = false;
            dgv_Cursos.Name = "dgv_Cursos";
            dgv_Cursos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Transparent;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_Cursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_Cursos.RowHeadersVisible = false;
            dgv_Cursos.RowHeadersWidth = 51;
            dgv_Cursos.RowTemplate.Height = 25;
            dgv_Cursos.ShowCellErrors = false;
            dgv_Cursos.ShowCellToolTips = false;
            dgv_Cursos.ShowEditingIcon = false;
            dgv_Cursos.ShowRowErrors = false;
            dgv_Cursos.Size = new Size(479, 205);
            dgv_Cursos.TabIndex = 23;
            // 
            // lbl_Reporte
            // 
            lbl_Reporte.Anchor = AnchorStyles.None;
            lbl_Reporte.AutoSize = true;
            lbl_Reporte.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Reporte.ForeColor = Color.Gainsboro;
            lbl_Reporte.Location = new Point(109, 46);
            lbl_Reporte.Name = "lbl_Reporte";
            lbl_Reporte.Size = new Size(228, 29);
            lbl_Reporte.TabIndex = 45;
            lbl_Reporte.Text = "Reportes de Cursos";
            // 
            // lbl_DescEspecialidad
            // 
            lbl_DescEspecialidad.Anchor = AnchorStyles.None;
            lbl_DescEspecialidad.AutoSize = true;
            lbl_DescEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DescEspecialidad.ForeColor = Color.Gainsboro;
            lbl_DescEspecialidad.Location = new Point(109, 93);
            lbl_DescEspecialidad.Name = "lbl_DescEspecialidad";
            lbl_DescEspecialidad.Size = new Size(392, 17);
            lbl_DescEspecialidad.TabIndex = 46;
            lbl_DescEspecialidad.Text = "Se generara un reporte en PDF con la siguiente informacion:";
            // 
            // FormReporteCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 608);
            Controls.Add(lbl_DescEspecialidad);
            Controls.Add(lbl_Reporte);
            Controls.Add(dgv_Cursos);
            Controls.Add(btnImprimir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormReporteCursos";
            Text = "Reporte de Cursos";
            ((System.ComponentModel.ISupportInitialize)dgv_Cursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private DataGridView dgv_Cursos;
        private Label lbl_Reporte;
        private Label lbl_DescEspecialidad;
    }
}