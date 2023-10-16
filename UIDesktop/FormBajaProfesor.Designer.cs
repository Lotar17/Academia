namespace UIDesktop
{
    partial class FormBajaProfesor
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
            lbl_IdDelete = new Label();
            dtgv_BajaProfesor = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            fechaNac = new DataGridViewTextBoxColumn();
            legajo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            nud_IdToDelete = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaProfesor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).BeginInit();
            SuspendLayout();
            // 
            // lbl_IdDelete
            // 
            lbl_IdDelete.Anchor = AnchorStyles.None;
            lbl_IdDelete.AutoSize = true;
            lbl_IdDelete.ForeColor = Color.Gainsboro;
            lbl_IdDelete.Location = new Point(407, 529);
            lbl_IdDelete.Name = "lbl_IdDelete";
            lbl_IdDelete.Size = new Size(259, 20);
            lbl_IdDelete.TabIndex = 35;
            lbl_IdDelete.Text = "Ingrese el ID del profesor a ELIMINAR";
            // 
            // dtgv_BajaProfesor
            // 
            dtgv_BajaProfesor.AllowUserToAddRows = false;
            dtgv_BajaProfesor.AllowUserToDeleteRows = false;
            dtgv_BajaProfesor.AllowUserToOrderColumns = true;
            dtgv_BajaProfesor.AllowUserToResizeColumns = false;
            dtgv_BajaProfesor.AllowUserToResizeRows = false;
            dtgv_BajaProfesor.Anchor = AnchorStyles.None;
            dtgv_BajaProfesor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_BajaProfesor.BackgroundColor = Color.FromArgb(32, 30, 45);
            dtgv_BajaProfesor.BorderStyle = BorderStyle.Fixed3D;
            dtgv_BajaProfesor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_BajaProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_BajaProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_BajaProfesor.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, apellido, direccion, email, telefono, fechaNac, legajo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_BajaProfesor.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_BajaProfesor.EnableHeadersVisualStyles = false;
            dtgv_BajaProfesor.GridColor = Color.Gainsboro;
            dtgv_BajaProfesor.Location = new Point(86, 201);
            dtgv_BajaProfesor.Margin = new Padding(3, 4, 3, 4);
            dtgv_BajaProfesor.MultiSelect = false;
            dtgv_BajaProfesor.Name = "dtgv_BajaProfesor";
            dtgv_BajaProfesor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_BajaProfesor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_BajaProfesor.RowHeadersVisible = false;
            dtgv_BajaProfesor.RowHeadersWidth = 51;
            dtgv_BajaProfesor.RowTemplate.Height = 25;
            dtgv_BajaProfesor.ShowCellErrors = false;
            dtgv_BajaProfesor.ShowCellToolTips = false;
            dtgv_BajaProfesor.ShowEditingIcon = false;
            dtgv_BajaProfesor.ShowRowErrors = false;
            dtgv_BajaProfesor.Size = new Size(1087, 273);
            dtgv_BajaProfesor.TabIndex = 34;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // fechaNac
            // 
            fechaNac.HeaderText = "Fecha de Nacimiento";
            fechaNac.MinimumWidth = 6;
            fechaNac.Name = "fechaNac";
            fechaNac.ReadOnly = true;
            // 
            // legajo
            // 
            legajo.HeaderText = "Legajo";
            legajo.MinimumWidth = 6;
            legajo.Name = "legajo";
            legajo.ReadOnly = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(41, 87);
            label5.Name = "label5";
            label5.Size = new Size(236, 36);
            label5.TabIndex = 33;
            label5.Text = "Baja de Profesor";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gainsboro;
            btnEliminar.Location = new Point(653, 588);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 75);
            btnEliminar.TabIndex = 32;
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
            btnCancelar.Location = new Point(373, 588);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 75);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nud_IdToDelete
            // 
            nud_IdToDelete.Anchor = AnchorStyles.None;
            nud_IdToDelete.Location = new Point(672, 527);
            nud_IdToDelete.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_IdToDelete.Name = "nud_IdToDelete";
            nud_IdToDelete.Size = new Size(150, 27);
            nud_IdToDelete.TabIndex = 36;
            // 
            // FormBajaProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1215, 749);
            Controls.Add(nud_IdToDelete);
            Controls.Add(lbl_IdDelete);
            Controls.Add(dtgv_BajaProfesor);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBajaProfesor";
            Text = "FormBajaProfesor";
            ((System.ComponentModel.ISupportInitialize)dtgv_BajaProfesor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_IdToDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_IdDelete;
        private DataGridView dtgv_BajaProfesor;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fechaNac;
        private DataGridViewTextBoxColumn legajo;
        private Label label5;
        private Button btnEliminar;
        private Button btnCancelar;
        private NumericUpDown nud_IdToDelete;
    }
}