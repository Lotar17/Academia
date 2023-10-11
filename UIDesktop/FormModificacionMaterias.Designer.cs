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
            dtgv_modificacionMateria = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            desc_materia = new DataGridViewTextBoxColumn();
            hsSemanales = new DataGridViewTextBoxColumn();
            hsTotales = new DataGridViewTextBoxColumn();
            idPlan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nud_hsSemanales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_hsTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionMateria).BeginInit();
            SuspendLayout();
            // 
            // lbl_idPlan
            // 
            lbl_idPlan.Anchor = AnchorStyles.None;
            lbl_idPlan.AutoSize = true;
            lbl_idPlan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idPlan.ForeColor = Color.Gainsboro;
            lbl_idPlan.Location = new Point(95, 341);
            lbl_idPlan.Name = "lbl_idPlan";
            lbl_idPlan.Size = new Size(143, 20);
            lbl_idPlan.TabIndex = 45;
            lbl_idPlan.Text = "Horas Semanales";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(103, 159);
            label5.Name = "label5";
            label5.Size = new Size(345, 36);
            label5.TabIndex = 44;
            label5.Text = "Modificacion de Materias";
            // 
            // txt_descMateria
            // 
            txt_descMateria.Anchor = AnchorStyles.None;
            txt_descMateria.Location = new Point(239, 291);
            txt_descMateria.Margin = new Padding(3, 4, 3, 4);
            txt_descMateria.Name = "txt_descMateria";
            txt_descMateria.Size = new Size(318, 27);
            txt_descMateria.TabIndex = 43;
            // 
            // lbl_DescEspecialidad
            // 
            lbl_DescEspecialidad.Anchor = AnchorStyles.None;
            lbl_DescEspecialidad.AutoSize = true;
            lbl_DescEspecialidad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DescEspecialidad.ForeColor = Color.Gainsboro;
            lbl_DescEspecialidad.Location = new Point(40, 293);
            lbl_DescEspecialidad.Name = "lbl_DescEspecialidad";
            lbl_DescEspecialidad.Size = new Size(201, 20);
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
            btnAceptar.Location = new Point(642, 635);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
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
            btnCancelar.Location = new Point(361, 635);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
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
            label1.Location = new Point(127, 393);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 48;
            label1.Text = "Horas totales";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(171, 443);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 50;
            label2.Text = "ID Plan";
            // 
            // nud_hsSemanales
            // 
            nud_hsSemanales.Anchor = AnchorStyles.None;
            nud_hsSemanales.Location = new Point(239, 340);
            nud_hsSemanales.Margin = new Padding(3, 4, 3, 4);
            nud_hsSemanales.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_hsSemanales.Name = "nud_hsSemanales";
            nud_hsSemanales.Size = new Size(137, 27);
            nud_hsSemanales.TabIndex = 51;
            // 
            // nud_hsTotales
            // 
            nud_hsTotales.Anchor = AnchorStyles.None;
            nud_hsTotales.Location = new Point(239, 392);
            nud_hsTotales.Margin = new Padding(3, 4, 3, 4);
            nud_hsTotales.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_hsTotales.Name = "nud_hsTotales";
            nud_hsTotales.Size = new Size(137, 27);
            nud_hsTotales.TabIndex = 52;
            // 
            // nud_idPlan
            // 
            nud_idPlan.Anchor = AnchorStyles.None;
            nud_idPlan.Location = new Point(239, 440);
            nud_idPlan.Margin = new Padding(3, 4, 3, 4);
            nud_idPlan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idPlan.Name = "nud_idPlan";
            nud_idPlan.Size = new Size(137, 27);
            nud_idPlan.TabIndex = 53;
            // 
            // dtgv_modificacionMateria
            // 
            dtgv_modificacionMateria.AllowUserToAddRows = false;
            dtgv_modificacionMateria.AllowUserToDeleteRows = false;
            dtgv_modificacionMateria.AllowUserToResizeColumns = false;
            dtgv_modificacionMateria.AllowUserToResizeRows = false;
            dtgv_modificacionMateria.Anchor = AnchorStyles.None;
            dtgv_modificacionMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_modificacionMateria.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_modificacionMateria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_modificacionMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_modificacionMateria.Columns.AddRange(new DataGridViewColumn[] { ID, desc_materia, hsSemanales, hsTotales, idPlan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_modificacionMateria.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_modificacionMateria.GridColor = Color.Gainsboro;
            dtgv_modificacionMateria.Location = new Point(582, 206);
            dtgv_modificacionMateria.Margin = new Padding(3, 4, 3, 4);
            dtgv_modificacionMateria.MultiSelect = false;
            dtgv_modificacionMateria.Name = "dtgv_modificacionMateria";
            dtgv_modificacionMateria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionMateria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_modificacionMateria.RowHeadersVisible = false;
            dtgv_modificacionMateria.RowHeadersWidth = 51;
            dtgv_modificacionMateria.RowTemplate.Height = 25;
            dtgv_modificacionMateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_modificacionMateria.Size = new Size(600, 257);
            dtgv_modificacionMateria.TabIndex = 88;
            dtgv_modificacionMateria.CellClick += dtgv_modificacionMateria_CellClick;
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
            desc_materia.HeaderText = "Descripcion de la materia";
            desc_materia.MinimumWidth = 6;
            desc_materia.Name = "desc_materia";
            desc_materia.ReadOnly = true;
            // 
            // hsSemanales
            // 
            hsSemanales.HeaderText = "Horas Semanales";
            hsSemanales.MinimumWidth = 6;
            hsSemanales.Name = "hsSemanales";
            hsSemanales.ReadOnly = true;
            // 
            // hsTotales
            // 
            hsTotales.HeaderText = "Horas totales";
            hsTotales.MinimumWidth = 6;
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
            // FormModificacionMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 811);
            Controls.Add(dtgv_modificacionMateria);
            Controls.Add(nud_idPlan);
            Controls.Add(nud_hsTotales);
            Controls.Add(nud_hsSemanales);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_idPlan);
            Controls.Add(label5);
            Controls.Add(txt_descMateria);
            Controls.Add(lbl_DescEspecialidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificacionMaterias";
            Text = "FormModificacionMaterias";
            ((System.ComponentModel.ISupportInitialize)nud_hsSemanales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_hsTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_idPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionMateria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DataGridView dtgv_modificacionMateria;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn desc_materia;
        private DataGridViewTextBoxColumn hsSemanales;
        private DataGridViewTextBoxColumn hsTotales;
        private DataGridViewTextBoxColumn idPlan;
    }
}