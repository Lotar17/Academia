namespace UIDesktop
{
    partial class FormModificacionPlanes
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
            label5 = new Label();
            txt_descPlan = new TextBox();
            lbl_DescEspecialidad = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txt_idPlan = new TextBox();
            lbl_idPlan = new Label();
            dtgv_modificacionPlan = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_plan = new DataGridViewTextBoxColumn();
            idPlan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionPlan).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(131, 143);
            label5.Name = "label5";
            label5.Size = new Size(323, 36);
            label5.TabIndex = 35;
            label5.Text = "Modificacion de Planes";
            // 
            // txt_descPlan
            // 
            txt_descPlan.Anchor = AnchorStyles.None;
            txt_descPlan.Location = new Point(271, 307);
            txt_descPlan.Margin = new Padding(3, 4, 3, 4);
            txt_descPlan.Name = "txt_descPlan";
            txt_descPlan.Size = new Size(318, 27);
            txt_descPlan.TabIndex = 34;
            // 
            // lbl_DescEspecialidad
            // 
            lbl_DescEspecialidad.Anchor = AnchorStyles.None;
            lbl_DescEspecialidad.AutoSize = true;
            lbl_DescEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DescEspecialidad.ForeColor = Color.Gainsboro;
            lbl_DescEspecialidad.Location = new Point(99, 310);
            lbl_DescEspecialidad.Name = "lbl_DescEspecialidad";
            lbl_DescEspecialidad.Size = new Size(162, 20);
            lbl_DescEspecialidad.TabIndex = 33;
            lbl_DescEspecialidad.Text = "Descripcion del plan";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(660, 562);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
            btnAceptar.TabIndex = 32;
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
            btnCancelar.Location = new Point(380, 562);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txt_idPlan
            // 
            txt_idPlan.Anchor = AnchorStyles.None;
            txt_idPlan.Location = new Point(271, 355);
            txt_idPlan.Margin = new Padding(3, 4, 3, 4);
            txt_idPlan.Name = "txt_idPlan";
            txt_idPlan.Size = new Size(125, 27);
            txt_idPlan.TabIndex = 38;
            // 
            // lbl_idPlan
            // 
            lbl_idPlan.Anchor = AnchorStyles.None;
            lbl_idPlan.AutoSize = true;
            lbl_idPlan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idPlan.ForeColor = Color.Gainsboro;
            lbl_idPlan.Location = new Point(197, 358);
            lbl_idPlan.Name = "lbl_idPlan";
            lbl_idPlan.Size = new Size(64, 20);
            lbl_idPlan.TabIndex = 37;
            lbl_idPlan.Text = "ID Plan";
            // 
            // dtgv_modificacionPlan
            // 
            dtgv_modificacionPlan.AllowUserToAddRows = false;
            dtgv_modificacionPlan.AllowUserToDeleteRows = false;
            dtgv_modificacionPlan.AllowUserToResizeColumns = false;
            dtgv_modificacionPlan.AllowUserToResizeRows = false;
            dtgv_modificacionPlan.Anchor = AnchorStyles.None;
            dtgv_modificacionPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_modificacionPlan.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_modificacionPlan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_modificacionPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_modificacionPlan.Columns.AddRange(new DataGridViewColumn[] { ID, desc_plan, idPlan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_modificacionPlan.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_modificacionPlan.GridColor = Color.Gainsboro;
            dtgv_modificacionPlan.Location = new Point(633, 195);
            dtgv_modificacionPlan.Margin = new Padding(3, 4, 3, 4);
            dtgv_modificacionPlan.MultiSelect = false;
            dtgv_modificacionPlan.Name = "dtgv_modificacionPlan";
            dtgv_modificacionPlan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_modificacionPlan.RowHeadersVisible = false;
            dtgv_modificacionPlan.RowHeadersWidth = 51;
            dtgv_modificacionPlan.RowTemplate.Height = 25;
            dtgv_modificacionPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_modificacionPlan.Size = new Size(536, 257);
            dtgv_modificacionPlan.TabIndex = 88;
            dtgv_modificacionPlan.CellClick += dtgv_modificacionPlan_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // desc_plan
            // 
            desc_plan.HeaderText = "Descripcion del Plan";
            desc_plan.MinimumWidth = 6;
            desc_plan.Name = "desc_plan";
            desc_plan.ReadOnly = true;
            // 
            // idPlan
            // 
            idPlan.HeaderText = "ID Plan";
            idPlan.MinimumWidth = 6;
            idPlan.Name = "idPlan";
            idPlan.ReadOnly = true;
            // 
            // FormModificacionPlanes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 811);
            Controls.Add(dtgv_modificacionPlan);
            Controls.Add(txt_idPlan);
            Controls.Add(lbl_idPlan);
            Controls.Add(label5);
            Controls.Add(txt_descPlan);
            Controls.Add(lbl_DescEspecialidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormModificacionPlanes";
            Text = "FormModificacionPlanes";
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txt_descPlan;
        private Label lbl_DescEspecialidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txt_idPlan;
        private Label lbl_idPlan;
        private DataGridView dtgv_modificacionPlan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_plan;
        private DataGridViewTextBoxColumn idPlan;
    }
}