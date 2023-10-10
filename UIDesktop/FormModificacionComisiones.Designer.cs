﻿namespace UIDesktop
{
    partial class FormModificacionComisiones
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
            nud_idPlan = new NumericUpDown();
            nud_anioEspecialidad = new NumericUpDown();
            lbl_idPlan = new Label();
            lbl_anioEspecialidad = new Label();
            label5 = new Label();
            txt_descComision = new TextBox();
            lbl_DescEspecialidad = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtgv_modificacionComision = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_comision = new DataGridViewTextBoxColumn();
            anioEspecialidad = new DataGridViewTextBoxColumn();
            idPlan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_anioEspecialidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionComision).BeginInit();
            SuspendLayout();
            // 
            // nud_idPlan
            // 
            nud_idPlan.Anchor = AnchorStyles.None;
            nud_idPlan.Location = new Point(237, 271);
            nud_idPlan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(120, 23);
            nud_idPlan.TabIndex = 65;
            // 
            // nud_anioEspecialidad
            // 
            nud_anioEspecialidad.Anchor = AnchorStyles.None;
            nud_anioEspecialidad.Location = new Point(237, 232);
            nud_anioEspecialidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_anioEspecialidad.Name = "nud_anioEspecialidad";
            nud_anioEspecialidad.Size = new Size(120, 23);
            nud_anioEspecialidad.TabIndex = 63;
            // 
            // lbl_idPlan
            // 
            lbl_idPlan.Anchor = AnchorStyles.None;
            lbl_idPlan.AutoSize = true;
            lbl_idPlan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idPlan.ForeColor = Color.Gainsboro;
            lbl_idPlan.Location = new Point(178, 273);
            lbl_idPlan.Name = "lbl_idPlan";
            lbl_idPlan.Size = new Size(53, 17);
            lbl_idPlan.TabIndex = 62;
            lbl_idPlan.Text = "ID Plan";
            // 
            // lbl_anioEspecialidad
            // 
            lbl_anioEspecialidad.Anchor = AnchorStyles.None;
            lbl_anioEspecialidad.AutoSize = true;
            lbl_anioEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_anioEspecialidad.ForeColor = Color.Gainsboro;
            lbl_anioEspecialidad.Location = new Point(111, 233);
            lbl_anioEspecialidad.Name = "lbl_anioEspecialidad";
            lbl_anioEspecialidad.Size = new Size(117, 17);
            lbl_anioEspecialidad.TabIndex = 59;
            lbl_anioEspecialidad.Text = "Año Especialidad";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(118, 96);
            label5.Name = "label5";
            label5.Size = new Size(317, 29);
            label5.TabIndex = 58;
            label5.Text = "Modificacion de Comisiones";
            // 
            // txt_descComision
            // 
            txt_descComision.Anchor = AnchorStyles.None;
            txt_descComision.Location = new Point(237, 195);
            txt_descComision.Name = "txt_descComision";
            txt_descComision.Size = new Size(279, 23);
            txt_descComision.TabIndex = 57;
            // 
            // lbl_DescEspecialidad
            // 
            lbl_DescEspecialidad.Anchor = AnchorStyles.None;
            lbl_DescEspecialidad.AutoSize = true;
            lbl_DescEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DescEspecialidad.ForeColor = Color.Gainsboro;
            lbl_DescEspecialidad.Location = new Point(55, 197);
            lbl_DescEspecialidad.Name = "lbl_DescEspecialidad";
            lbl_DescEspecialidad.Size = new Size(176, 17);
            lbl_DescEspecialidad.TabIndex = 56;
            lbl_DescEspecialidad.Text = "Descripcion de la comision";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(590, 453);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 55;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(344, 453);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtgv_modificacionComision
            // 
            dtgv_modificacionComision.AllowUserToAddRows = false;
            dtgv_modificacionComision.AllowUserToDeleteRows = false;
            dtgv_modificacionComision.AllowUserToOrderColumns = true;
            dtgv_modificacionComision.AllowUserToResizeColumns = false;
            dtgv_modificacionComision.AllowUserToResizeRows = false;
            dtgv_modificacionComision.Anchor = AnchorStyles.None;
            dtgv_modificacionComision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_modificacionComision.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_modificacionComision.BorderStyle = BorderStyle.Fixed3D;
            dtgv_modificacionComision.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionComision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_modificacionComision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_modificacionComision.Columns.AddRange(new DataGridViewColumn[] { ID, desc_comision, anioEspecialidad, idPlan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_modificacionComision.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_modificacionComision.EnableHeadersVisualStyles = false;
            dtgv_modificacionComision.GridColor = Color.Gainsboro;
            dtgv_modificacionComision.Location = new Point(565, 157);
            dtgv_modificacionComision.MultiSelect = false;
            dtgv_modificacionComision.Name = "dtgv_modificacionComision";
            dtgv_modificacionComision.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionComision.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_modificacionComision.RowHeadersVisible = false;
            dtgv_modificacionComision.RowHeadersWidth = 51;
            dtgv_modificacionComision.RowTemplate.Height = 25;
            dtgv_modificacionComision.ShowCellErrors = false;
            dtgv_modificacionComision.ShowCellToolTips = false;
            dtgv_modificacionComision.ShowEditingIcon = false;
            dtgv_modificacionComision.ShowRowErrors = false;
            dtgv_modificacionComision.Size = new Size(479, 205);
            dtgv_modificacionComision.TabIndex = 66;
            dtgv_modificacionComision.CellContentClick += dtgv_modificacionPlan_CellClick;
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
            // FormModificacionComisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1143, 604);
            Controls.Add(dtgv_modificacionComision);
            Controls.Add(nud_idPlan);
            Controls.Add(nud_anioEspecialidad);
            Controls.Add(lbl_idPlan);
            Controls.Add(lbl_anioEspecialidad);
            Controls.Add(label5);
            Controls.Add(txt_descComision);
            Controls.Add(lbl_DescEspecialidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormModificacionComisiones";
            Text = "FormModificacionComisiones";
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_anioEspecialidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionComision).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_idPlan;
        private NumericUpDown nud_anioEspecialidad;
        private Label lbl_idPlan;
        private Label lbl_anioEspecialidad;
        private Label label5;
        private TextBox txt_descComision;
        private Label lbl_DescEspecialidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridView dtgv_modificacionComision;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_comision;
        private DataGridViewTextBoxColumn anioEspecialidad;
        private DataGridViewTextBoxColumn idPlan;
    }
}