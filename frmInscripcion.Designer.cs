namespace ClubDeportivo
{
    partial class frmIncripcion
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
            lblNombre = new Label();
            lblInscripcion = new Label();
            txtNombre = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnInscribir = new Button();
            picInscripcion = new PictureBox();
            label1 = new Label();
            txtDireccion = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            chkSocio = new CheckBox();
            label3 = new Label();
            chkFichaMedica = new CheckBox();
            lblFichaMedica = new Label();
            ((System.ComponentModel.ISupportInitialize)picInscripcion).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(162, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre y Apellido";
            // 
            // lblInscripcion
            // 
            lblInscripcion.AutoSize = true;
            lblInscripcion.Location = new Point(284, 27);
            lblInscripcion.Name = "lblInscripcion";
            lblInscripcion.Size = new Size(126, 15);
            lblInscripcion.TabIndex = 2;
            lblInscripcion.Text = "INSCRIPCION CLIENTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(292, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(165, 169);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 7;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(292, 161);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(195, 23);
            txtDocumento.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(287, 328);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(412, 328);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(153, 328);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(75, 23);
            btnInscribir.TabIndex = 6;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += button1_Click;
            // 
            // picInscripcion
            // 
            picInscripcion.Image = Properties.Resources.altaUsuario1;
            picInscripcion.Location = new Point(12, 55);
            picInscripcion.Name = "picInscripcion";
            picInscripcion.Size = new Size(144, 133);
            picInscripcion.SizeMode = PictureBoxSizeMode.Zoom;
            picInscripcion.TabIndex = 15;
            picInscripcion.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 127);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 16;
            label1.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(292, 119);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(195, 23);
            txtDireccion.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(165, 207);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(119, 15);
            lblFechaNacimiento.TabIndex = 18;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(292, 207);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(101, 23);
            dtpFechaNacimiento.TabIndex = 194;
            dtpFechaNacimiento.Value = new DateTime(2024, 5, 12, 19, 12, 17, 0);
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.Location = new Point(256, 254);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(15, 14);
            chkSocio.TabIndex = 5;
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 253);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 21;
            label3.Text = "Socio";
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Location = new Point(256, 288);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(15, 14);
            chkFichaMedica.TabIndex = 195;
            chkFichaMedica.UseVisualStyleBackColor = true;
            // 
            // lblFichaMedica
            // 
            lblFichaMedica.AutoSize = true;
            lblFichaMedica.Location = new Point(165, 289);
            lblFichaMedica.Name = "lblFichaMedica";
            lblFichaMedica.Size = new Size(77, 15);
            lblFichaMedica.TabIndex = 196;
            lblFichaMedica.Text = "Ficha Médica";
            // 
            // frmIncripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 380);
            Controls.Add(lblFichaMedica);
            Controls.Add(chkFichaMedica);
            Controls.Add(label3);
            Controls.Add(chkSocio);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(label1);
            Controls.Add(btnInscribir);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNombre);
            Controls.Add(lblInscripcion);
            Controls.Add(lblNombre);
            Controls.Add(picInscripcion);
            MaximizeBox = false;
            Name = "frmIncripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSCRIPCION CLIENTE";
            Load += frmIncripcion_Load;
            ((System.ComponentModel.ISupportInitialize)picInscripcion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblInscripcion;
        private TextBox txtNombre;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnInscribir;
        private PictureBox picInscripcion;
        private Label label1;
        private TextBox txtDireccion;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox chkSocio;
        private Label label3;
        private CheckBox chkFichaMedica;
        private Label lblFichaMedica;
    }
}