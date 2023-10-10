namespace UIDesktop
{
    partial class FormBajaMateria
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
            lbl_IdDelete = new Label();
            dtgv_BajaMateria = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_materia = new DataGridViewTextBoxColumn();
            hsSemanales = new DataGridViewTextBoxColumn();
            hsTotales = new DataGridViewTextBoxColumn();
            idPlan = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            nud_IdToDelete = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            SuspendLayout();
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(223, 322);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(207, 15);
            lbl_IdDelete.TabIndex = 41;
            lbl_IdDelete.Text = "Ingrese el ID de la materia a ELIMINAR";
            // 
            // dtgv_BajaMateria
            // 
            dtgv_BajaMateria.AllowUserToAddRows = false;
            dtgv_BajaMateria.AllowUserToDeleteRows = false;
            dtgv_BajaMateria.AllowUserToOrderColumns = true;
            dtgv_BajaMateria.AllowUserToResizeColumns = false;
            dtgv_BajaMateria.AllowUserToResizeRows = false;
            dtgv_BajaMateria.Anchor = AnchorStyles.None;
            dtgv_BajaMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaMateria.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaMateria.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaMateria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_BajaMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_BajaMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaMateria.Columns.AddRange(new DataGridViewColumn[] { ID, desc_materia, hsSemanales, hsTotales, idPlan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_BajaMateria.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_BajaMateria.EnableHeadersVisualStyles = false;
            dtgv_BajaMateria.GridColor = Color.Gainsboro;
            dtgv_BajaMateria.Location = new Point(169, 88);
            dtgv_BajaMateria.MultiSelect = false;
            dtgv_BajaMateria.Name = "dtgv_BajaMateria";
            dtgv_BajaMateria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_BajaMateria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_BajaMateria.RowHeadersVisible = false;
            dtgv_BajaMateria.RowHeadersWidth = 51;
            dtgv_BajaMateria.RowTemplate.Height = 25;
            dtgv_BajaMateria.ShowCellErrors = false;
            dtgv_BajaMateria.ShowCellToolTips = false;
            dtgv_BajaMateria.ShowEditingIcon = false;
            dtgv_BajaMateria.ShowRowErrors = false;
            dtgv_BajaMateria.Size = new Size(479, 205);
            dtgv_BajaMateria.TabIndex = 40;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // desc_materia
            // 
            desc_materia.HeaderText = "Descripción de la especialidad";
            desc_materia.MinimumWidth = 6;
            desc_materia.Name = "desc_materia";
            desc_materia.ReadOnly = true;
            // 
            // hsSemanales
            // 
            hsSemanales.HeaderText = "Horas semanales";
            hsSemanales.Name = "hsSemanales";
            hsSemanales.ReadOnly = true;
            // 
            // hsTotales
            // 
            hsTotales.HeaderText = "Horas totales";
            hsTotales.Name = "hsTotales";
            hsTotales.ReadOnly = true;
            // 
            // idPlan
            // 
            idPlan.HeaderText = "ID Plan";
            idPlan.MinimumWidth = 6;
            idPlan.Name = "idPlan";
            idPlan.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(81, 34);
            label5.Name = "label5";
            label5.Size = new Size(181, 29);
            label5.TabIndex = 39;
            label5.Text = "Baja de Materia";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(452, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 56);
            btnEliminar.TabIndex = 38;
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
            btnCancelar.Location = new Point(207, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Location = new Point(436, 320);
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(120, 23);
            nud_IdToDelete.TabIndex = 42;
            // 
            // FormBajaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaMateria);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Name = "FormBajaMateria";
            Text = "FormBajaMateria";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaMateria;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_materia;
        private DataGridViewTextBoxColumn hsSemanales;
        private DataGridViewTextBoxColumn hsTotales;
        private DataGridViewTextBoxColumn idPlan;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private NumericUpDown nud_IdToDelete;
    }
}