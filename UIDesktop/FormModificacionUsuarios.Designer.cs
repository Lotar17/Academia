namespace UIDesktop
{
    partial class FormModificacionUsuarios
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
            lbl_Habilitado = new Label();
            txt_NombreUsuario = new TextBox();
            lbl_NombreUsuario = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtgv_ModificacionUsuario = new DataGridView();
            id_usuario = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            habilitado = new DataGridViewTextBoxColumn();
            cbx_Habilitado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionUsuario).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(134, 41);
            label5.Name = "label5";
            label5.Size = new Size(272, 29);
            label5.TabIndex = 21;
            label5.Text = "Modificacion de Usuario";
            // 
            // lbl_Habilitado
            // 
            lbl_Habilitado.Anchor = AnchorStyles.None;
            lbl_Habilitado.AutoSize = true;
            lbl_Habilitado.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Habilitado.ForeColor = Color.Gainsboro;
            lbl_Habilitado.Location = new Point(72, 208);
            lbl_Habilitado.Name = "lbl_Habilitado";
            lbl_Habilitado.Size = new Size(71, 17);
            lbl_Habilitado.TabIndex = 18;
            lbl_Habilitado.Text = "Habilitado";
            // 
            // txt_NombreUsuario
            // 
            txt_NombreUsuario.Anchor = AnchorStyles.None;
            txt_NombreUsuario.Location = new Point(149, 147);
            txt_NombreUsuario.Name = "txt_NombreUsuario";
            txt_NombreUsuario.Size = new Size(279, 23);
            txt_NombreUsuario.TabIndex = 14;
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.Anchor = AnchorStyles.None;
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NombreUsuario.ForeColor = Color.Gainsboro;
            lbl_NombreUsuario.Location = new Point(12, 149);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(131, 17);
            lbl_NombreUsuario.TabIndex = 13;
            lbl_NombreUsuario.Text = "Nombre de Usuario";
            lbl_NombreUsuario.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(530, 332);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 12;
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
            btnCancelar.Location = new Point(285, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtgv_ModificacionUsuario
            // 
            dtgv_ModificacionUsuario.AllowUserToAddRows = false;
            dtgv_ModificacionUsuario.AllowUserToDeleteRows = false;
            dtgv_ModificacionUsuario.AllowUserToResizeColumns = false;
            dtgv_ModificacionUsuario.AllowUserToResizeRows = false;
            dtgv_ModificacionUsuario.Anchor = AnchorStyles.None;
            dtgv_ModificacionUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ModificacionUsuario.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_ModificacionUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_ModificacionUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ModificacionUsuario.Columns.AddRange(new DataGridViewColumn[] { id_usuario, nombre_usuario, habilitado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_ModificacionUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_ModificacionUsuario.GridColor = Color.Gainsboro;
            dtgv_ModificacionUsuario.Location = new Point(493, 75);
            dtgv_ModificacionUsuario.MultiSelect = false;
            dtgv_ModificacionUsuario.Name = "dtgv_ModificacionUsuario";
            dtgv_ModificacionUsuario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_ModificacionUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_ModificacionUsuario.RowHeadersVisible = false;
            dtgv_ModificacionUsuario.RowTemplate.Height = 25;
            dtgv_ModificacionUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_ModificacionUsuario.Size = new Size(404, 193);
            dtgv_ModificacionUsuario.TabIndex = 22;
            dtgv_ModificacionUsuario.CellClick += dtgv_ModificacionUsuario_CellClick;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "ID";
            id_usuario.Name = "id_usuario";
            id_usuario.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "Nombre de Usuario";
            nombre_usuario.Name = "nombre_usuario";
            nombre_usuario.ReadOnly = true;
            // 
            // habilitado
            // 
            habilitado.HeaderText = "Habilitado";
            habilitado.Name = "habilitado";
            habilitado.ReadOnly = true;
            // 
            // cbx_Habilitado
            // 
            cbx_Habilitado.Anchor = AnchorStyles.None;
            cbx_Habilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Habilitado.FormattingEnabled = true;
            cbx_Habilitado.Items.AddRange(new object[] { "Si", "No" });
            cbx_Habilitado.Location = new Point(149, 206);
            cbx_Habilitado.Name = "cbx_Habilitado";
            cbx_Habilitado.Size = new Size(121, 23);
            cbx_Habilitado.TabIndex = 23;
            // 
            // FormModificacionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(928, 450);
            Controls.Add(cbx_Habilitado);
            Controls.Add(dtgv_ModificacionUsuario);
            Controls.Add(label5);
            Controls.Add(lbl_Habilitado);
            Controls.Add(txt_NombreUsuario);
            Controls.Add(lbl_NombreUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormModificacionUsuarios";
            Text = "FormModificacionUsuarios";
            Load += FormModificacionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_ModificacionUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lbl_Habilitado;
        private TextBox txt_NombreUsuario;
        private Label lbl_NombreUsuario;
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridView dtgv_ModificacionUsuario;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn habilitado;
        private ComboBox cbx_Habilitado;
    }
}