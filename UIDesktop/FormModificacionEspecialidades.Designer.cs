namespace UIDesktop
{
    partial class FormModificacionEspecialidades
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
            dtgv_ModificacionEspecialidad = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_especialidad = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txt_DescEspecialidad = new TextBox();
            lbl_DescEspecialidad = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // dtgv_ModificacionEspecialidad
            // 
            dtgv_ModificacionEspecialidad.AllowUserToAddRows = false;
            dtgv_ModificacionEspecialidad.AllowUserToDeleteRows = false;
            dtgv_ModificacionEspecialidad.AllowUserToResizeColumns = false;
            dtgv_ModificacionEspecialidad.AllowUserToResizeRows = false;
            dtgv_ModificacionEspecialidad.Anchor = AnchorStyles.None;
            dtgv_ModificacionEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ModificacionEspecialidad.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_ModificacionEspecialidad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionEspecialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_ModificacionEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ModificacionEspecialidad.Columns.AddRange(new DataGridViewColumn[] { ID, desc_especialidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_ModificacionEspecialidad.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_ModificacionEspecialidad.GridColor = Color.Gainsboro;
            dtgv_ModificacionEspecialidad.Location = new Point(570, 165);
            dtgv_ModificacionEspecialidad.MultiSelect = false;
            dtgv_ModificacionEspecialidad.Name = "dtgv_ModificacionEspecialidad";
            dtgv_ModificacionEspecialidad.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionEspecialidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_ModificacionEspecialidad.RowHeadersVisible = false;
            dtgv_ModificacionEspecialidad.RowTemplate.Height = 25;
            dtgv_ModificacionEspecialidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_ModificacionEspecialidad.Size = new Size(404, 193);
            dtgv_ModificacionEspecialidad.TabIndex = 30;
            dtgv_ModificacionEspecialidad.CellClick += dtgv_ModificacionEspecialidad_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // desc_especialidad
            // 
            desc_especialidad.HeaderText = "Descripcion de la especialidad";
            desc_especialidad.Name = "desc_especialidad";
            desc_especialidad.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(149, 131);
            label5.Name = "label5";
            label5.Size = new Size(355, 29);
            label5.TabIndex = 29;
            label5.Text = "Modificacion de Especialidades";
            // 
            // txt_DescEspecialidad
            // 
            txt_DescEspecialidad.Anchor = AnchorStyles.None;
            txt_DescEspecialidad.Location = new Point(184, 270);
            txt_DescEspecialidad.Name = "txt_DescEspecialidad";
            txt_DescEspecialidad.Size = new Size(279, 23);
            txt_DescEspecialidad.TabIndex = 27;
            // 
            // lbl_DescEspecialidad
            // 
            lbl_DescEspecialidad.Anchor = AnchorStyles.None;
            lbl_DescEspecialidad.AutoSize = true;
            lbl_DescEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DescEspecialidad.ForeColor = Color.Gainsboro;
            lbl_DescEspecialidad.Location = new Point(224, 239);
            lbl_DescEspecialidad.Name = "lbl_DescEspecialidad";
            lbl_DescEspecialidad.Size = new Size(200, 17);
            lbl_DescEspecialidad.TabIndex = 26;
            lbl_DescEspecialidad.Text = "Descripcion de la especialidad";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(607, 422);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 25;
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
            btnCancelar.Location = new Point(362, 422);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormModificacionEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 608);
            Controls.Add(dtgv_ModificacionEspecialidad);
            Controls.Add(label5);
            Controls.Add(txt_DescEspecialidad);
            Controls.Add(lbl_DescEspecialidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormModificacionEspecialidades";
            Text = "FormModificacionEspecialidades";
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionEspecialidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_ModificacionEspecialidad;
        private Label label5;
        private TextBox txt_DescEspecialidad;
        private Label lbl_DescEspecialidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_especialidad;
    }
}