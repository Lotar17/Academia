namespace UIDesktop
{
    partial class frm_ConsultaUsuario : Form
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
            label5 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            ipb_Usuario = new FontAwesome.Sharp.IconPictureBox();
            lbl_IdPersona = new Label();
            lbl_Habilitado = new Label();
            lbl_NombreUsuario = new Label();
            lbl_Id = new Label();
            nud_Id = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Id).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(208, 114);
            label5.Name = "label5";
            label5.Size = new Size(230, 29);
            label5.TabIndex = 21;
            label5.Text = "Consulta de Usuario";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(236, 234);
            label1.Name = "label1";
            label1.Size = new Size(220, 17);
            label1.TabIndex = 13;
            label1.Text = "Ingrese el ID del usuario a buscar";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(607, 431);
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
            btnCancelar.Location = new Point(362, 431);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ipb_Usuario);
            panel1.Controls.Add(lbl_IdPersona);
            panel1.Controls.Add(lbl_Habilitado);
            panel1.Controls.Add(lbl_NombreUsuario);
            panel1.Controls.Add(lbl_Id);
            panel1.Location = new Point(563, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 223);
            panel1.TabIndex = 22;
            panel1.Visible = false;
            // 
            // ipb_Usuario
            // 
            ipb_Usuario.Anchor = AnchorStyles.None;
            ipb_Usuario.BackColor = Color.FromArgb(32, 30, 45);
            ipb_Usuario.ForeColor = Color.Gainsboro;
            ipb_Usuario.IconChar = FontAwesome.Sharp.IconChar.User;
            ipb_Usuario.IconColor = Color.Gainsboro;
            ipb_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipb_Usuario.IconSize = 100;
            ipb_Usuario.Location = new Point(197, 12);
            ipb_Usuario.Name = "ipb_Usuario";
            ipb_Usuario.Size = new Size(100, 100);
            ipb_Usuario.TabIndex = 23;
            ipb_Usuario.TabStop = false;
            ipb_Usuario.Visible = false;
            // 
            // lbl_IdPersona
            // 
            lbl_IdPersona.Anchor = AnchorStyles.None;
            lbl_IdPersona.AutoSize = true;
            lbl_IdPersona.ForeColor = Color.Gainsboro;
            lbl_IdPersona.Location = new Point(16, 172);
            lbl_IdPersona.Name = "lbl_IdPersona";
            lbl_IdPersona.Size = new Size(82, 15);
            lbl_IdPersona.TabIndex = 3;
            lbl_IdPersona.Text = "ID de Persona:";
            lbl_IdPersona.Visible = false;
            // 
            // lbl_Habilitado
            // 
            lbl_Habilitado.Anchor = AnchorStyles.None;
            lbl_Habilitado.AutoSize = true;
            lbl_Habilitado.ForeColor = Color.Gainsboro;
            lbl_Habilitado.Location = new Point(16, 151);
            lbl_Habilitado.Name = "lbl_Habilitado";
            lbl_Habilitado.Size = new Size(65, 15);
            lbl_Habilitado.TabIndex = 2;
            lbl_Habilitado.Text = "Habilitado:";
            lbl_Habilitado.Visible = false;
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.Anchor = AnchorStyles.None;
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.ForeColor = Color.Gainsboro;
            lbl_NombreUsuario.Location = new Point(16, 125);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(113, 15);
            lbl_NombreUsuario.TabIndex = 1;
            lbl_NombreUsuario.Text = "Nombre de Usuario:";
            lbl_NombreUsuario.Visible = false;
            // 
            // lbl_Id
            // 
            lbl_Id.Anchor = AnchorStyles.None;
            lbl_Id.AutoSize = true;
            lbl_Id.ForeColor = Color.Gainsboro;
            lbl_Id.Location = new Point(16, 104);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(21, 15);
            lbl_Id.TabIndex = 0;
            lbl_Id.Text = "ID:";
            lbl_Id.Visible = false;
            // 
            // nud_Id
            // 
            nud_Id.Anchor = AnchorStyles.None;
            nud_Id.Location = new Point(286, 260);
            nud_Id.Margin = new Padding(3, 2, 3, 2);
            nud_Id.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_Id.Name = "nud_Id";
            nud_Id.Size = new Size(131, 23);
            nud_Id.TabIndex = 23;
            // 
            // frm_ConsultaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1063, 608);
            Controls.Add(nud_Id);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_ConsultaUsuario";
            Text = "FormConsultaUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipb_Usuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Panel panel1;
        private Label lbl_IdPersona;
        private Label lbl_Habilitado;
        private Label lbl_NombreUsuario;
        private Label lbl_Id;
        private FontAwesome.Sharp.IconPictureBox ipb_Usuario;
        private NumericUpDown nud_Id;
    }
}