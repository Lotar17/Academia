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
            txt_IdDelete = new TextBox();
            lbl_IdDelete = new Label();
            dtgv_BajaPlan = new DataGridView();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ID = new DataGridViewTextBoxColumn();
            desc_especialidad = new DataGridViewTextBoxColumn();
            idEspecialidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaPlan).BeginInit();
            SuspendLayout();
            // 
            // txt_IdDelete
            // 
            txt_IdDelete.Anchor = AnchorStyles.None;
            txt_IdDelete.Location = new Point(568, 366);
            txt_IdDelete.Name = "txt_IdDelete";
            txt_IdDelete.Size = new Size(103, 23);
            txt_IdDelete.TabIndex = 36;
            txt_IdDelete.KeyPress += txt_IdDelete_KeyPress;
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(360, 368);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(181, 15);
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
            dtgv_BajaPlan.Location = new Point(306, 134);
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
            dtgv_BajaPlan.Size = new Size(479, 205);
            dtgv_BajaPlan.TabIndex = 34;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(218, 80);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
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
            btnEliminar.Location = new Point(589, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 56);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(344, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
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
            // FormBajaPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 562);
            Controls.Add(txt_IdDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaPlan);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBajaPlan";
            Text = "FormBajaPlan";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_IdDelete;
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaPlan;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_especialidad;
        private DataGridViewTextBoxColumn idEspecialidad;
    }
}