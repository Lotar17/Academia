namespace UIDesktop
{
    partial class FormBajaCurso
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
            nud_IdToDelete = new NumericUpDown();
            lbl_IdDelete = new Label();
            dtgv_BajaCurso = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            idMateria = new DataGridViewTextBoxColumn();
            idComision = new DataGridViewTextBoxColumn();
            anioCalendario = new DataGridViewTextBoxColumn();
            cupo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaCurso).BeginInit();
            SuspendLayout();
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Anchor = AnchorStyles.None;
            nud_IdToDelete.Location = new Point(496, 350);
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(120, 23);
            nud_IdToDelete.TabIndex = 54;
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(303, 352);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(187, 15);
            lbl_IdDelete.TabIndex = 53;
            lbl_IdDelete.Text = "Ingrese el ID del curso a ELIMINAR";
            // 
            // dtgv_BajaCurso
            // 
            dtgv_BajaCurso.AllowUserToAddRows = false;
            dtgv_BajaCurso.AllowUserToDeleteRows = false;
            dtgv_BajaCurso.AllowUserToOrderColumns = true;
            dtgv_BajaCurso.AllowUserToResizeColumns = false;
            dtgv_BajaCurso.AllowUserToResizeRows = false;
            dtgv_BajaCurso.Anchor = AnchorStyles.None;
            dtgv_BajaCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaCurso.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaCurso.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaCurso.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_BajaCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_BajaCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaCurso.Columns.AddRange(new DataGridViewColumn[] { ID, idMateria, idComision, anioCalendario, cupo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_BajaCurso.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_BajaCurso.EnableHeadersVisualStyles = false;
            dtgv_BajaCurso.GridColor = Color.Gainsboro;
            dtgv_BajaCurso.Location = new Point(243, 118);
            dtgv_BajaCurso.MultiSelect = false;
            dtgv_BajaCurso.Name = "dtgv_BajaCurso";
            dtgv_BajaCurso.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_BajaCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_BajaCurso.RowHeadersVisible = false;
            dtgv_BajaCurso.RowHeadersWidth = 51;
            dtgv_BajaCurso.RowTemplate.Height = 25;
            dtgv_BajaCurso.ShowCellErrors = false;
            dtgv_BajaCurso.ShowCellToolTips = false;
            dtgv_BajaCurso.ShowEditingIcon = false;
            dtgv_BajaCurso.ShowRowErrors = false;
            dtgv_BajaCurso.Size = new Size(479, 205);
            dtgv_BajaCurso.TabIndex = 52;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // idMateria
            // 
            idMateria.HeaderText = "ID Materia";
            idMateria.Name = "idMateria";
            idMateria.ReadOnly = true;
            // 
            // idComision
            // 
            idComision.HeaderText = "ID Comision";
            idComision.MinimumWidth = 6;
            idComision.Name = "idComision";
            idComision.ReadOnly = true;
            // 
            // anioCalendario
            // 
            anioCalendario.HeaderText = "Año Calendario";
            anioCalendario.Name = "anioCalendario";
            anioCalendario.ReadOnly = true;
            // 
            // cupo
            // 
            cupo.HeaderText = "Cupo";
            cupo.MinimumWidth = 6;
            cupo.Name = "cupo";
            cupo.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(145, 63);
            label5.Name = "label5";
            label5.Size = new Size(165, 29);
            label5.TabIndex = 51;
            label5.Text = "Baja de Curso";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(526, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 56);
            btnEliminar.TabIndex = 50;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(281, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormBajaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(941, 498);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaCurso);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Name = "FormBajaCurso";
            Text = "FormBajaCurso";
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_IdToDelete;
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaCurso;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn idMateria;
        private DataGridViewTextBoxColumn idComision;
        private DataGridViewTextBoxColumn anioCalendario;
        private DataGridViewTextBoxColumn cupo;
    }
}