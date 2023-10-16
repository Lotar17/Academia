namespace UIDesktop
{
    partial class FormBajaPlan
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
            dtgv_BajaPlan = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_especialidad = new DataGridViewTextBoxColumn();
            idEspecialidad = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            nud_IdToDelete = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            SuspendLayout();
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(411, 491);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(232, 20);
            lbl_IdDelete.TabIndex = 35;
            lbl_IdDelete.Text = "Ingrese el ID del plan a ELIMINAR";
            // 
            // dtgv_BajaPlan
            // 
            dtgv_BajaPlan.AllowUserToAddRows = false;
            dtgv_BajaPlan.AllowUserToDeleteRows = false;
            dtgv_BajaPlan.AllowUserToOrderColumns = true;
            dtgv_BajaPlan.AllowUserToResizeColumns = false;
            dtgv_BajaPlan.AllowUserToResizeRows = false;
            dtgv_BajaPlan.Anchor = AnchorStyles.None;
            dtgv_BajaPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaPlan.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaPlan.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaPlan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_BajaPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_BajaPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaPlan.Columns.AddRange(new DataGridViewColumn[] { ID, desc_especialidad, idEspecialidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_BajaPlan.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_BajaPlan.EnableHeadersVisualStyles = false;
            dtgv_BajaPlan.GridColor = Color.Gainsboro;
            dtgv_BajaPlan.Location = new Point(350, 179);
            dtgv_BajaPlan.Margin = new Padding(3, 4, 3, 4);
            dtgv_BajaPlan.MultiSelect = false;
            dtgv_BajaPlan.Name = "dtgv_BajaPlan";
            dtgv_BajaPlan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_BajaPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_BajaPlan.RowHeadersVisible = false;
            dtgv_BajaPlan.RowHeadersWidth = 51;
            dtgv_BajaPlan.RowTemplate.Height = 25;
            dtgv_BajaPlan.ShowCellErrors = false;
            dtgv_BajaPlan.ShowCellToolTips = false;
            dtgv_BajaPlan.ShowEditingIcon = false;
            dtgv_BajaPlan.ShowRowErrors = false;
            dtgv_BajaPlan.Size = new Size(547, 273);
            dtgv_BajaPlan.TabIndex = 34;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // desc_especialidad
            // 
            desc_especialidad.HeaderText = "Descripción de la especialidad";
            desc_especialidad.MinimumWidth = 6;
            desc_especialidad.Name = "desc_especialidad";
            desc_especialidad.ReadOnly = true;
            // 
            // idEspecialidad
            // 
            idEspecialidad.HeaderText = "ID Especialidad";
            idEspecialidad.MinimumWidth = 6;
            idEspecialidad.Name = "idEspecialidad";
            idEspecialidad.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(249, 107);
            label5.Name = "label5";
            label5.Size = new Size(183, 36);
            label5.TabIndex = 33;
            label5.Text = "Baja de Plan";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(673, 541);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 75);
            btnEliminar.TabIndex = 32;
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
            btnCancelar.Location = new Point(393, 541);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Anchor = AnchorStyles.None;
            nud_IdToDelete.Location = new Point(649, 489);
            nud_IdToDelete.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(150, 27);
            nud_IdToDelete.TabIndex = 36;
            // 
            // FormBajaPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 749);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaPlan);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Name = "FormBajaPlan";
            Text = "FormBajaPlan";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaPlan;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_especialidad;
        private DataGridViewTextBoxColumn idEspecialidad;
        private NumericUpDown nud_IdToDelete;
    }
}