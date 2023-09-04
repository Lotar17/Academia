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
            label5 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dtgv_BajaUsuario = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewTextBoxColumn();
            id_persona = new DataGridViewTextBoxColumn();
            controllerBindingSource = new BindingSource(components);
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
            label5.Location = new Point(74, 22);
            label5.Name = "label5";
            label5.Size = new Size(184, 29);
            label5.TabIndex = 21;
            label5.Text = "Baja de Usuario";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(434, 335);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(142, 56);
            btnAceptar.TabIndex = 12;
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
            btnCancelar.Location = new Point(189, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dtgv_BajaUsuario
            // 
            dtgv_BajaUsuario.Anchor = AnchorStyles.None;
            dtgv_BajaUsuario.AutoGenerateColumns = false;
            dtgv_BajaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaUsuario.Columns.AddRange(new DataGridViewColumn[] { ID, nombre_usuario, Habilitado, id_persona });
            dtgv_BajaUsuario.DataSource = controllerBindingSource;
            dtgv_BajaUsuario.Location = new Point(172, 80);
            dtgv_BajaUsuario.Name = "dtgv_BajaUsuario";
            dtgv_BajaUsuario.RowTemplate.Height = 25;
            dtgv_BajaUsuario.Size = new Size(443, 205);
            dtgv_BajaUsuario.TabIndex = 22;
            dtgv_BajaUsuario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "Nombre de Usuario";
            nombre_usuario.Name = "nombre_usuario";
            // 
            // Habilitado
            // 
            Habilitado.HeaderText = "Habilitado";
            Habilitado.Name = "Habilitado";
            // 
            // id_persona
            // 
            id_persona.HeaderText = "ID Persona";
            id_persona.Name = "id_persona";
            // 
            // controllerBindingSource
            // 
            controllerBindingSource.DataSource = typeof(Dominio.Controller);
            // 
            // FormBajaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(777, 418);
            Controls.Add(dtgv_BajaUsuario);
            Controls.Add(label5);
            Controls.Add(btnAceptar);
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
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridView dtgv_BajaUsuario;
        private BindingSource controllerBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn Habilitado;
        private DataGridViewTextBoxColumn id_persona;
    }
}