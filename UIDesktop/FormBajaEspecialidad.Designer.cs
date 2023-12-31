﻿namespace UIDesktop
{
    partial class FormBajaEspecialidad
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
            dtgv_BajaEspecialidad = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_especialidad = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            nud_IdToDelete = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaEspecialidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            SuspendLayout();
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(362, 515);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(299, 20);
            lbl_IdDelete.TabIndex = 29;
            lbl_IdDelete.Text = "Ingrese el ID de la especialidad a ELIMINAR";
            // 
            // dtgv_BajaEspecialidad
            // 
            dtgv_BajaEspecialidad.AllowUserToAddRows = false;
            dtgv_BajaEspecialidad.AllowUserToDeleteRows = false;
            dtgv_BajaEspecialidad.AllowUserToOrderColumns = true;
            dtgv_BajaEspecialidad.AllowUserToResizeColumns = false;
            dtgv_BajaEspecialidad.AllowUserToResizeRows = false;
            dtgv_BajaEspecialidad.Anchor = AnchorStyles.None;
            dtgv_BajaEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaEspecialidad.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaEspecialidad.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaEspecialidad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_BajaEspecialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_BajaEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaEspecialidad.Columns.AddRange(new DataGridViewColumn[] { ID, desc_especialidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_BajaEspecialidad.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_BajaEspecialidad.EnableHeadersVisualStyles = false;
            dtgv_BajaEspecialidad.GridColor = Color.Gainsboro;
            dtgv_BajaEspecialidad.Location = new Point(319, 203);
            dtgv_BajaEspecialidad.Margin = new Padding(3, 4, 3, 4);
            dtgv_BajaEspecialidad.MultiSelect = false;
            dtgv_BajaEspecialidad.Name = "dtgv_BajaEspecialidad";
            dtgv_BajaEspecialidad.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_BajaEspecialidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_BajaEspecialidad.RowHeadersVisible = false;
            dtgv_BajaEspecialidad.RowHeadersWidth = 51;
            dtgv_BajaEspecialidad.RowTemplate.Height = 25;
            dtgv_BajaEspecialidad.ShowCellErrors = false;
            dtgv_BajaEspecialidad.ShowCellToolTips = false;
            dtgv_BajaEspecialidad.ShowEditingIcon = false;
            dtgv_BajaEspecialidad.ShowRowErrors = false;
            dtgv_BajaEspecialidad.Size = new Size(547, 273);
            dtgv_BajaEspecialidad.TabIndex = 28;
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
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(218, 131);
            label5.Name = "label5";
            label5.Size = new Size(293, 36);
            label5.TabIndex = 27;
            label5.Text = "Baja de Especialidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(642, 565);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 75);
            btnEliminar.TabIndex = 26;
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
            btnCancelar.Location = new Point(362, 565);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Anchor = AnchorStyles.None;
            nud_IdToDelete.Location = new Point(667, 513);
            nud_IdToDelete.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(150, 27);
            nud_IdToDelete.TabIndex = 30;
            // 
            // FormBajaEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 749);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaEspecialidad);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBajaEspecialidad";
            Text = "FormBajaEspecialidad";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaEspecialidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaEspecialidad;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_especialidad;
        private NumericUpDown nud_IdToDelete;
    }
}