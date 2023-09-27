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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnImprimir = new Button();
            dtgvCursos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvCursos).BeginInit();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.None;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Gainsboro;
            btnImprimir.Location = new Point(422, 401);
            btnImprimir.Margin = new Padding(3, 4, 3, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(162, 75);
            btnImprimir.TabIndex = 12;
            btnImprimir.Text = "Cancelar";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dtgvCursos
            // 
            dtgvCursos.AllowUserToAddRows = false;
            dtgvCursos.AllowUserToDeleteRows = false;
            dtgvCursos.AllowUserToOrderColumns = true;
            dtgvCursos.AllowUserToResizeColumns = false;
            dtgvCursos.AllowUserToResizeRows = false;
            dtgvCursos.Anchor = AnchorStyles.None;
            dtgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCursos.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgvCursos.BorderStyle = BorderStyle.Fixed3D;
            dtgvCursos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCursos.Columns.AddRange(new DataGridViewColumn[] { ID, nombre_usuario, Habilitado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvCursos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvCursos.EnableHeadersVisualStyles = false;
            dtgvCursos.GridColor = Color.Gainsboro;
            dtgvCursos.Location = new Point(236, 77);
            dtgvCursos.Margin = new Padding(3, 4, 3, 4);
            dtgvCursos.MultiSelect = false;
            dtgvCursos.Name = "dtgvCursos";
            dtgvCursos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvCursos.RowHeadersVisible = false;
            dtgvCursos.RowHeadersWidth = 51;
            dtgvCursos.RowTemplate.Height = 25;
            dtgvCursos.ShowCellErrors = false;
            dtgvCursos.ShowCellToolTips = false;
            dtgvCursos.ShowEditingIcon = false;
            dtgvCursos.ShowRowErrors = false;
            dtgvCursos.Size = new Size(547, 273);
            dtgvCursos.TabIndex = 23;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "Nombre de Usuario";
            nombre_usuario.MinimumWidth = 6;
            nombre_usuario.Name = "nombre_usuario";
            nombre_usuario.ReadOnly = true;
            // 
            // Habilitado
            // 
            Habilitado.HeaderText = "Habilitado";
            Habilitado.MinimumWidth = 6;
            Habilitado.Name = "Habilitado";
            Habilitado.ReadOnly = true;
            // 
            // FormReporteCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1061, 600);
            Controls.Add(dtgvCursos);
            Controls.Add(btnImprimir);
            Name = "FormReporteCursos";
            Text = "Reporte de Cursos";
            ((System.ComponentModel.ISupportInitialize)dtgvCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private DataGridView dtgvCursos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn Habilitado;
    }
}