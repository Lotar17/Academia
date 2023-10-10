namespace UIDesktop
{
    partial class FormModificacionMaterias
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
            dtgv_modificacionMateria = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_materia = new DataGridViewTextBoxColumn();
            hsSemanales = new DataGridViewTextBoxColumn();
            hsTotales = new DataGridViewTextBoxColumn();
            id_plan = new DataGridViewTextBoxColumn();
            lbl_idPlan = new Label();
            label5 = new Label();
            txt_descMateria = new TextBox();
            lbl_DescEspecialidad = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            nud_hsSemanales = new NumericUpDown();
            nud_hsTotales = new NumericUpDown();
            nud_idPlan = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_hsSemanales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_hsTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).BeginInit();
            SuspendLayout();
            // 
            // dtgv_modificacionMateria
            // 
            dtgv_modificacionMateria.AllowUserToAddRows = false;
            dtgv_modificacionMateria.AllowUserToDeleteRows = false;
            dtgv_modificacionMateria.AllowUserToOrderColumns = true;
            dtgv_modificacionMateria.AllowUserToResizeColumns = false;
            dtgv_modificacionMateria.AllowUserToResizeRows = false;
            dtgv_modificacionMateria.Anchor = AnchorStyles.None;
            dtgv_modificacionMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_modificacionMateria.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_modificacionMateria.BorderStyle = BorderStyle.Fixed3D;
            dtgv_modificacionMateria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_modificacionMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_modificacionMateria.Columns.AddRange(new DataGridViewColumn[] { ID, desc_materia, hsSemanales, hsTotales, id_plan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_modificacionMateria.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_modificacionMateria.EnableHeadersVisualStyles = false;
            dtgv_modificacionMateria.GridColor = Color.Gainsboro;
            dtgv_modificacionMateria.Location = new Point(522, 172);
            dtgv_modificacionMateria.MultiSelect = false;
            dtgv_modificacionMateria.Name = "dtgv_modificacionMateria";
            dtgv_modificacionMateria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionMateria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_modificacionMateria.RowHeadersVisible = false;
            dtgv_modificacionMateria.RowHeadersWidth = 51;
            dtgv_modificacionMateria.RowTemplate.Height = 25;
            dtgv_modificacionMateria.ShowCellErrors = false;
            dtgv_modificacionMateria.ShowCellToolTips = false;
            dtgv_modificacionMateria.ShowEditingIcon = false;
            dtgv_modificacionMateria.ShowRowErrors = false;
            dtgv_modificacionMateria.Size = new Size(529, 205);
            dtgv_modificacionMateria.TabIndex = 47;
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
            desc_materia.HeaderText = "Descripción de la materia";
            desc_materia.MinimumWidth = 6;
            desc_materia.Name = "desc_materia";
            desc_materia.ReadOnly = true;
            // 
            // hsSemanales
            // 
            hsSemanales.HeaderText = "Horas semanales";
            hsSemanales.MinimumWidth = 6;
            hsSemanales.Name = "hsSemanales";
            hsSemanales.ReadOnly = true;
            // 
            // hsTotales
            // 
            hsTotales.HeaderText = "Horas totales";
            hsTotales.Name = "hsTotales";
            hsTotales.ReadOnly = true;
            // 
            // id_plan
            // 
            id_plan.HeaderText = "ID Plan";
            id_plan.Name = "id_plan";
            id_plan.ReadOnly = true;
            // 
            // lbl_idPlan
            // 
            lbl_idPlan.Anchor = AnchorStyles.None;
            lbl_idPlan.AutoSize = true;
            lbl_idPlan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idPlan.ForeColor = Color.Gainsboro;
            lbl_idPlan.Location = new Point(83, 256);
            lbl_idPlan.Name = "lbl_idPlan";
            lbl_idPlan.Size = new Size(120, 17);
            lbl_idPlan.TabIndex = 45;
            lbl_idPlan.Text = "Horas Semanales";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(90, 119);
            label5.Name = "label5";
            label5.Size = new Size(281, 29);
            label5.TabIndex = 44;
            label5.Text = "Modificacion de Materias";
            // 
            // txt_descMateria
            // 
            txt_descMateria.Anchor = AnchorStyles.None;
            txt_descMateria.Location = new Point(209, 218);
            txt_descMateria.Name = "txt_descMateria";
            txt_descMateria.Size = new Size(279, 23);
            txt_descMateria.TabIndex = 43;
            // 
            // lbl_DescEspecialidad
            // 
            lbl_DescEspecialidad.Anchor = AnchorStyles.None;
            lbl_DescEspecialidad.AutoSize = true;
            lbl_DescEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DescEspecialidad.ForeColor = Color.Gainsboro;
            lbl_DescEspecialidad.Location = new Point(35, 220);
            lbl_DescEspecialidad.Name = "lbl_DescEspecialidad";
            lbl_DescEspecialidad.Size = new Size(168, 17);
            lbl_DescEspecialidad.TabIndex = 42;
            lbl_DescEspecialidad.Text = "Descripcion de la materia";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(562, 476);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 41;
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
            btnCancelar.Location = new Point(316, 476);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(111, 295);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 48;
            label1.Text = "Horas totales";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(150, 332);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 50;
            label2.Text = "ID Plan";
            // 
            // nud_hsSemanales
            // 
            nud_hsSemanales.Anchor = AnchorStyles.None;
            nud_hsSemanales.Location = new Point(209, 255);
            nud_hsSemanales.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_hsSemanales.Name = "nud_hsSemanales";
            nud_hsSemanales.Size = new Size(120, 23);
            nud_hsSemanales.TabIndex = 51;
            // 
            // nud_hsTotales
            // 
            nud_hsTotales.Anchor = AnchorStyles.None;
            nud_hsTotales.Location = new Point(209, 294);
            nud_hsTotales.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_hsTotales.Name = "nud_hsTotales";
            nud_hsTotales.Size = new Size(120, 23);
            nud_hsTotales.TabIndex = 52;
            // 
            // nud_idPlan
            // 
            nud_idPlan.Anchor = AnchorStyles.None;
            nud_idPlan.Location = new Point(209, 330);
            nud_idPlan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(120, 23);
            nud_idPlan.TabIndex = 53;
            // 
            // FormModificacionMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 608);
            Controls.Add(nud_idPlan);
            Controls.Add(nud_hsTotales);
            Controls.Add(nud_hsSemanales);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgv_modificacionMateria);
            Controls.Add(lbl_idPlan);
            Controls.Add(label5);
            Controls.Add(txt_descMateria);
            Controls.Add(lbl_DescEspecialidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormModificacionMaterias";
            Text = "FormModificacionMaterias";
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_hsSemanales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_hsTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_modificacionMateria;
        private Label lbl_idPlan;
        private Label label5;
        private TextBox txt_descMateria;
        private Label lbl_DescEspecialidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private NumericUpDown nud_hsSemanales;
        private NumericUpDown nud_hsTotales;
        private NumericUpDown nud_idPlan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_materia;
        private DataGridViewTextBoxColumn hsSemanales;
        private DataGridViewTextBoxColumn hsTotales;
        private DataGridViewTextBoxColumn id_plan;
    }
}