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
            components = new System.ComponentModel.Container();
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
            controllerBindingSource = new BindingSource(components);
            lbl_IdDelete = new Label();
            txt_IdDelete = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(147, 26);
            label5.Name = "label5";
            label5.Size = new Size(184, 29);
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
            btnEliminar.Location = new Point(518, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 56);
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
            btnCancelar.Location = new Point(273, 352);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
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
            dtgv_BajaUsuario.Location = new Point(235, 80);
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
            dtgv_BajaUsuario.Size = new Size(479, 205);
            dtgv_BajaUsuario.TabIndex = 22;
            dtgv_BajaUsuario.CellClick += dtgv_BajaUsuario_CellClick;
            dtgv_BajaUsuario.CellContentClick += dtgv_BajaUsuario_CellContentClick;
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
            // controllerBindingSource
            // 
            controllerBindingSource.DataSource = typeof(Dominio.Controller);
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(304, 309);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(197, 15);
            lbl_IdDelete.TabIndex = 23;
            lbl_IdDelete.Text = "Ingrese el ID del usuario a ELIMINAR";
            // 
            // txt_IdDelete
            // 
            txt_IdDelete.Anchor = AnchorStyles.None;
            txt_IdDelete.Location = new Point(528, 306);
            txt_IdDelete.Name = "txt_IdDelete";
            txt_IdDelete.Size = new Size(103, 23);
            txt_IdDelete.TabIndex = 24;
            txt_IdDelete.KeyPress += txt_IdDelete_KeyPress;
            // 
            // FormBajaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(928, 450);
            Controls.Add(txt_IdDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaUsuario);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Name = "FormBajaUsuario";
            Text = "Baja de Usuario";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)controllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridView dtgv_BajaUsuario;
        private BindingSource controllerBindingSource;
        private Label lbl_IdDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn Habilitado;
        private TextBox txt_IdDelete;
    }
}