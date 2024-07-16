namespace ClubDeportivo
{
    partial class frmCarnet
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
            picAvatar = new PictureBox();
            lblTitulo = new Label();
            lblNombreApellido = new Label();
            lblDocumento = new Label();
            lblSubtitulo = new Label();
            lblDireccion = new Label();
            lblFechaNacimiento = new Label();
            lblCarnet = new Label();
            lblFechaIngreso = new Label();
            lblDinamicoDocumento = new Label();
            lblDinamicoNombre = new Label();
            lblDinamicoDireccion = new Label();
            lblDinamicoNacimiento = new Label();
            lblDinamicoFechaIngreso = new Label();
            lblDinamicoCarnet = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.avatar3;
            picAvatar.Location = new Point(23, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(133, 142);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(184, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 42);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CLUB DEPORTIVO";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(182, 118);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(113, 15);
            lblNombreApellido.TabIndex = 2;
            lblNombreApellido.Text = "Nombre y Apellido: ";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(182, 148);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.Location = new Point(231, 64);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(187, 28);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "CARNET ASOCIADO";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(182, 174);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(182, 203);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(125, 15);
            lblFechaNacimiento.TabIndex = 6;
            lblFechaNacimiento.Text = "Fecha de Nacimiento: ";
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Location = new Point(182, 257);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(111, 15);
            lblCarnet.TabIndex = 7;
            lblCarnet.Text = "Número de Carnet: ";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(182, 228);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(99, 15);
            lblFechaIngreso.TabIndex = 8;
            lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lblDinamicoDocumento
            // 
            lblDinamicoDocumento.AutoSize = true;
            lblDinamicoDocumento.Location = new Point(318, 148);
            lblDinamicoDocumento.Name = "lblDinamicoDocumento";
            lblDinamicoDocumento.Size = new Size(120, 15);
            lblDinamicoDocumento.TabIndex = 9;
            lblDinamicoDocumento.Text = "dinamicoDocumento";
            // 
            // lblDinamicoNombre
            // 
            lblDinamicoNombre.AutoSize = true;
            lblDinamicoNombre.Location = new Point(318, 118);
            lblDinamicoNombre.Name = "lblDinamicoNombre";
            lblDinamicoNombre.Size = new Size(101, 15);
            lblDinamicoNombre.TabIndex = 10;
            lblDinamicoNombre.Text = "dinamicoNombre";
            // 
            // lblDinamicoDireccion
            // 
            lblDinamicoDireccion.AutoSize = true;
            lblDinamicoDireccion.Location = new Point(318, 174);
            lblDinamicoDireccion.Name = "lblDinamicoDireccion";
            lblDinamicoDireccion.Size = new Size(107, 15);
            lblDinamicoDireccion.TabIndex = 11;
            lblDinamicoDireccion.Text = "dinamicoDireccion";
            // 
            // lblDinamicoNacimiento
            // 
            lblDinamicoNacimiento.AutoSize = true;
            lblDinamicoNacimiento.Location = new Point(319, 203);
            lblDinamicoNacimiento.Name = "lblDinamicoNacimiento";
            lblDinamicoNacimiento.Size = new Size(119, 15);
            lblDinamicoNacimiento.TabIndex = 12;
            lblDinamicoNacimiento.Text = "dinamicoNacimiento";
            // 
            // lblDinamicoFechaIngreso
            // 
            lblDinamicoFechaIngreso.AutoSize = true;
            lblDinamicoFechaIngreso.Location = new Point(318, 228);
            lblDinamicoFechaIngreso.Name = "lblDinamicoFechaIngreso";
            lblDinamicoFechaIngreso.Size = new Size(141, 15);
            lblDinamicoFechaIngreso.TabIndex = 13;
            lblDinamicoFechaIngreso.Text = "dinamicoFechaDeIngreso";
            // 
            // lblDinamicoCarnet
            // 
            lblDinamicoCarnet.AutoSize = true;
            lblDinamicoCarnet.Location = new Point(318, 257);
            lblDinamicoCarnet.Name = "lblDinamicoCarnet";
            lblDinamicoCarnet.Size = new Size(92, 15);
            lblDinamicoCarnet.TabIndex = 14;
            lblDinamicoCarnet.Text = "dinamicoCarnet";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(389, 300);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(106, 32);
            btnImprimir.TabIndex = 15;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += lblImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 347);
            Controls.Add(btnImprimir);
            Controls.Add(lblDinamicoCarnet);
            Controls.Add(lblDinamicoFechaIngreso);
            Controls.Add(lblDinamicoNacimiento);
            Controls.Add(lblDinamicoDireccion);
            Controls.Add(lblDinamicoNombre);
            Controls.Add(lblDinamicoDocumento);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblCarnet);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblDireccion);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblDocumento);
            Controls.Add(lblNombreApellido);
            Controls.Add(lblTitulo);
            Controls.Add(picAvatar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet";
            Load += frmCarnet_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Label lblTitulo;
        private Label lblNombreApellido;
        private Label lblDocumento;
        private Label lblSubtitulo;
        private Label lblDireccion;
        private Label lblFechaNacimiento;
        private Label lblCarnet;
        private Label lblFechaIngreso;
        private Label lblDinamicoDocumento;
        private Label lblDinamicoNombre;
        private Label lblDinamicoDireccion;
        private Label lblDinamicoNacimiento;
        private Label lblDinamicoFechaIngreso;
        private Label lblDinamicoCarnet;
        private Button btnImprimir;
    }
}