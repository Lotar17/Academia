﻿namespace UIDesktop
{
    partial class FormBajaComision
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            nud_IdToDelete = new NumericUpDown();
            lbl_IdDelete = new Label();
            dtgv_BajaComision = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_comision = new DataGridViewTextBoxColumn();
            anioEspecialidad = new DataGridViewTextBoxColumn();
            idPlan = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaComision).BeginInit();
            SuspendLayout();
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Anchor = AnchorStyles.None;
            nud_IdToDelete.Location = new Point(592, 467);
            nud_IdToDelete.Margin = new Padding(3, 4, 3, 4);
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(137, 27);
            nud_IdToDelete.TabIndex = 48;
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(311, 469);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(275, 20);
            lbl_IdDelete.TabIndex = 47;
            lbl_IdDelete.Text = "Ingrese el ID de la comision a ELIMINAR";
            // 
            // dtgv_BajaComision
            // 
            dtgv_BajaComision.AllowUserToAddRows = false;
            dtgv_BajaComision.AllowUserToDeleteRows = false;
            dtgv_BajaComision.AllowUserToOrderColumns = true;
            dtgv_BajaComision.AllowUserToResizeColumns = false;
            dtgv_BajaComision.AllowUserToResizeRows = false;
            dtgv_BajaComision.Anchor = AnchorStyles.None;
            dtgv_BajaComision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaComision.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaComision.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaComision.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgv_BajaComision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_BajaComision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaComision.Columns.AddRange(new DataGridViewColumn[] { ID, desc_comision, anioEspecialidad, idPlan });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Transparent;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgv_BajaComision.DefaultCellStyle = dataGridViewCellStyle5;
            dtgv_BajaComision.EnableHeadersVisualStyles = false;
            dtgv_BajaComision.GridColor = Color.Gainsboro;
            dtgv_BajaComision.Location = new Point(287, 157);
            dtgv_BajaComision.Margin = new Padding(3, 4, 3, 4);
            dtgv_BajaComision.MultiSelect = false;
            dtgv_BajaComision.Name = "dtgv_BajaComision";
            dtgv_BajaComision.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Transparent;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgv_BajaComision.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgv_BajaComision.RowHeadersVisible = false;
            dtgv_BajaComision.RowHeadersWidth = 51;
            dtgv_BajaComision.RowTemplate.Height = 25;
            dtgv_BajaComision.ShowCellErrors = false;
            dtgv_BajaComision.ShowCellToolTips = false;
            dtgv_BajaComision.ShowEditingIcon = false;
            dtgv_BajaComision.ShowRowErrors = false;
            dtgv_BajaComision.Size = new Size(547, 273);
            dtgv_BajaComision.TabIndex = 46;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // desc_comision
            // 
            desc_comision.HeaderText = "Descripcion de la comision";
            desc_comision.MinimumWidth = 6;
            desc_comision.Name = "desc_comision";
            desc_comision.ReadOnly = true;
            // 
            // anioEspecialidad
            // 
            anioEspecialidad.HeaderText = "Año Especialidad";
            anioEspecialidad.MinimumWidth = 6;
            anioEspecialidad.Name = "anioEspecialidad";
            anioEspecialidad.ReadOnly = true;
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
            label5.Location = new Point(175, 84);
            label5.Name = "label5";
            label5.Size = new Size(247, 36);
            label5.TabIndex = 45;
            label5.Text = "Baja de Comision";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(610, 520);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 75);
            btnEliminar.TabIndex = 44;
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
            btnCancelar.Location = new Point(330, 520);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormBajaComision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1104, 700);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaComision);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBajaComision";
            Text = "FormaBajaComision";
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaComision).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_IdToDelete;
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaComision;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_comision;
        private DataGridViewTextBoxColumn anioEspecialidad;
        private DataGridViewTextBoxColumn idPlan;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}