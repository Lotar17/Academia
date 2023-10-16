namespace Academia
{
    partial class FormBajaUsuario
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
            btnEliminar = new Button();
            btnCancelar = new Button();
            dtgv_BajaUsuario = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewTextBoxColumn();
            lbl_IdDelete = new Label();
            nud_IdToDelete = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(245, 140);
            label5.Name = "label5";
            label5.Size = new Size(227, 36);
            label5.TabIndex = 21;
            label5.Text = "Baja de Usuario";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(669, 575);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 75);
            btnEliminar.TabIndex = 12;
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
            btnCancelar.Location = new Point(389, 575);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtgv_BajaUsuario
            // 
            dtgv_BajaUsuario.AllowUserToAddRows = false;
            dtgv_BajaUsuario.AllowUserToDeleteRows = false;
            dtgv_BajaUsuario.AllowUserToOrderColumns = true;
            dtgv_BajaUsuario.AllowUserToResizeColumns = false;
            dtgv_BajaUsuario.AllowUserToResizeRows = false;
            dtgv_BajaUsuario.Anchor = AnchorStyles.None;
            dtgv_BajaUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaUsuario.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaUsuario.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_BajaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_BajaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaUsuario.Columns.AddRange(new DataGridViewColumn[] { ID, nombre_usuario, Habilitado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_BajaUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_BajaUsuario.EnableHeadersVisualStyles = false;
            dtgv_BajaUsuario.GridColor = Color.Gainsboro;
            dtgv_BajaUsuario.Location = new Point(345, 212);
            dtgv_BajaUsuario.Margin = new Padding(3, 4, 3, 4);
            dtgv_BajaUsuario.MultiSelect = false;
            dtgv_BajaUsuario.Name = "dtgv_BajaUsuario";
            dtgv_BajaUsuario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_BajaUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_BajaUsuario.RowHeadersVisible = false;
            dtgv_BajaUsuario.RowHeadersWidth = 51;
            dtgv_BajaUsuario.RowTemplate.Height = 25;
            dtgv_BajaUsuario.ShowCellErrors = false;
            dtgv_BajaUsuario.ShowCellToolTips = false;
            dtgv_BajaUsuario.ShowEditingIcon = false;
            dtgv_BajaUsuario.ShowRowErrors = false;
            dtgv_BajaUsuario.Size = new Size(547, 273);
            dtgv_BajaUsuario.TabIndex = 22;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "Nombre de Usuario";
            nombre_usuario.MinimumWidth = 6;
            nombre_usuario.Name = "nombre_usuario";
            nombre_usuario.ReadOnly = true;
            // 
            // Habilitado
            // 
            Habilitado.HeaderText = "Habilitado";
            Habilitado.MinimumWidth = 6;
            Habilitado.Name = "Habilitado";
            Habilitado.ReadOnly = true;
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(424, 517);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(251, 20);
            lbl_IdDelete.TabIndex = 23;
            lbl_IdDelete.Text = "Ingrese el ID del usuario a ELIMINAR";
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Anchor = AnchorStyles.None;
            nud_IdToDelete.Location = new Point(681, 515);
            nud_IdToDelete.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(150, 27);
            nud_IdToDelete.TabIndex = 24;
            // 
            // FormBajaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 811);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaUsuario);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBajaUsuario";
            Text = "Baja de Usuario";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridView dtgv_BajaUsuario;
        private Label lbl_IdDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn Habilitado;
        private NumericUpDown nud_IdToDelete;
    }
}