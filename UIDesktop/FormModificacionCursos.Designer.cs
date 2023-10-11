namespace UIDesktop
{
    partial class FormModificacionCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificacionCursos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label5 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            nud_anioCalendario = new NumericUpDown();
            nud_cupo = new NumericUpDown();
            nud_idComision = new NumericUpDown();
            nud_idMateria = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMensajeError = new Label();
            dtgv_modificacionCursos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            idMateria = new DataGridViewTextBoxColumn();
            idComision = new DataGridViewTextBoxColumn();
            anioCalendario = new DataGridViewTextBoxColumn();
            cupo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nud_anioCalendario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cupo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_idComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_idMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionCursos).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(168, 111);
            label5.Name = "label5";
            label5.Size = new Size(327, 36);
            label5.TabIndex = 71;
            label5.Text = "Modificacion de Cursos";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(675, 585);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(162, 75);
            btnAceptar.TabIndex = 68;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Gainsboro;
            btnCancelar.Location = new Point(394, 585);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 67;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // nud_anioCalendario
            // 
            nud_anioCalendario.Anchor = AnchorStyles.None;
            nud_anioCalendario.Location = new Point(322, 341);
            nud_anioCalendario.Margin = new Padding(3, 4, 3, 4);
            nud_anioCalendario.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_anioCalendario.Name = "nud_anioCalendario";
            nud_anioCalendario.Size = new Size(137, 27);
            nud_anioCalendario.TabIndex = 84;
            // 
            // nud_cupo
            // 
            nud_cupo.Anchor = AnchorStyles.None;
            nud_cupo.Location = new Point(322, 389);
            nud_cupo.Margin = new Padding(3, 4, 3, 4);
            nud_cupo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_cupo.Name = "nud_cupo";
            nud_cupo.Size = new Size(137, 27);
            nud_cupo.TabIndex = 83;
            // 
            // nud_idComision
            // 
            nud_idComision.Anchor = AnchorStyles.None;
            nud_idComision.Location = new Point(322, 288);
            nud_idComision.Margin = new Padding(3, 4, 3, 4);
            nud_idComision.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idComision.Name = "nud_idComision";
            nud_idComision.Size = new Size(137, 27);
            nud_idComision.TabIndex = 82;
            // 
            // nud_idMateria
            // 
            nud_idMateria.Anchor = AnchorStyles.None;
            nud_idMateria.Location = new Point(322, 237);
            nud_idMateria.Margin = new Padding(3, 4, 3, 4);
            nud_idMateria.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_idMateria.Name = "nud_idMateria";
            nud_idMateria.Size = new Size(137, 27);
            nud_idMateria.TabIndex = 81;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(182, 391);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 80;
            label4.Text = "Cupo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(182, 343);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 79;
            label3.Text = "Año Calendario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(182, 289);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 78;
            label2.Text = "ID Comision";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(182, 239);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 77;
            label1.Text = "ID Materia";
            // 
            // lblMensajeError
            // 
            lblMensajeError.Anchor = AnchorStyles.None;
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.DarkGray;
            lblMensajeError.Image = (Image)resources.GetObject("lblMensajeError.Image");
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(226, 480);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(107, 18);
            lblMensajeError.TabIndex = 85;
            lblMensajeError.Text = "Error Message";
            lblMensajeError.Visible = false;
            // 
            // dtgv_modificacionCursos
            // 
            dtgv_modificacionCursos.AllowUserToAddRows = false;
            dtgv_modificacionCursos.AllowUserToDeleteRows = false;
            dtgv_modificacionCursos.AllowUserToResizeColumns = false;
            dtgv_modificacionCursos.AllowUserToResizeRows = false;
            dtgv_modificacionCursos.Anchor = AnchorStyles.None;
            dtgv_modificacionCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_modificacionCursos.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_modificacionCursos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_modificacionCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_modificacionCursos.Columns.AddRange(new DataGridViewColumn[] { ID, idMateria, idComision, anioCalendario, cupo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_modificacionCursos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_modificacionCursos.GridColor = Color.Gainsboro;
            dtgv_modificacionCursos.Location = new Point(546, 159);
            dtgv_modificacionCursos.Margin = new Padding(3, 4, 3, 4);
            dtgv_modificacionCursos.MultiSelect = false;
            dtgv_modificacionCursos.Name = "dtgv_modificacionCursos";
            dtgv_modificacionCursos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_modificacionCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_modificacionCursos.RowHeadersVisible = false;
            dtgv_modificacionCursos.RowHeadersWidth = 51;
            dtgv_modificacionCursos.RowTemplate.Height = 25;
            dtgv_modificacionCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_modificacionCursos.Size = new Size(600, 257);
            dtgv_modificacionCursos.TabIndex = 86;
            dtgv_modificacionCursos.CellClick += dtgv_modificacionCurso_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // idMateria
            // 
            idMateria.HeaderText = "ID Materia";
            idMateria.MinimumWidth = 6;
            idMateria.Name = "idMateria";
            idMateria.ReadOnly = true;
            // 
            // idComision
            // 
            idComision.HeaderText = "ID Comision";
            idComision.MinimumWidth = 6;
            idComision.Name = "idComision";
            idComision.ReadOnly = true;
            // 
            // anioCalendario
            // 
            anioCalendario.HeaderText = "Año Calendario";
            anioCalendario.MinimumWidth = 6;
            anioCalendario.Name = "anioCalendario";
            anioCalendario.ReadOnly = true;
            // 
            // cupo
            // 
            cupo.HeaderText = "Cupo";
            cupo.MinimumWidth = 6;
            cupo.Name = "cupo";
            cupo.ReadOnly = true;
            // 
            // FormModificacionCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1258, 769);
            Controls.Add(dtgv_modificacionCursos);
            Controls.Add(lblMensajeError);
            Controls.Add(nud_anioCalendario);
            Controls.Add(nud_cupo);
            Controls.Add(nud_idComision);
            Controls.Add(nud_idMateria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificacionCursos";
            Text = "FormModificacionCursos";
            ((System.ComponentModel.ISupportInitialize)nud_anioCalendario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cupo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_idComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_idMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_modificacionCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown nud_anioCalendario;
        private NumericUpDown nud_cupo;
        private NumericUpDown nud_idComision;
        private NumericUpDown nud_idMateria;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblMensajeError;
        private DataGridView dtgv_modificacionCursos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn idMateria;
        private DataGridViewTextBoxColumn idComision;
        private DataGridViewTextBoxColumn anioCalendario;
        private DataGridViewTextBoxColumn cupo;
    }
}