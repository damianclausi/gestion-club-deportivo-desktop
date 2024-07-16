namespace ClubDeportivo
{
    partial class frmComprobante
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
            groupBox1 = new GroupBox();
            lblTitulo = new Label();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label11 = new Label();
            picAvatar = new PictureBox();
            groupBox3 = new GroupBox();
            lblDinamicoFechaVencimiento = new Label();
            lblFechaVencimiento = new Label();
            lblDinamicoIdCliente = new Label();
            lblCliente = new Label();
            lblDinamicoImporte = new Label();
            lblImporte = new Label();
            lblDinamicoFormaPago = new Label();
            lblFormaPago = new Label();
            lblDinamicoFechaInscripcion = new Label();
            lblFechaInscripcion = new Label();
            lblDinamicoActividad = new Label();
            lblActividad = new Label();
            lblDinamicoNombre = new Label();
            btnImprimir = new Button();
            imageList1 = new ImageList(components);
            lblTipoActividad = new Label();
            lblDinamicoTipoCliente = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTitulo);
            groupBox1.Location = new Point(56, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(70, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(371, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "COMPROBANTE DE PAGO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(picAvatar);
            groupBox2.Location = new Point(56, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(538, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(338, 31);
            label13.Name = "label13";
            label13.Size = new Size(182, 28);
            label13.TabIndex = 3;
            label13.Text = "DATOS GENERALES";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(29, 31);
            label11.Name = "label11";
            label11.Size = new Size(166, 28);
            label11.TabIndex = 1;
            label11.Text = "CLUB DEPORTIVO";
            // 
            // picAvatar
            // 
            picAvatar.Image = Properties.Resources.avatar_running;
            picAvatar.InitialImage = Properties.Resources.avatar_running;
            picAvatar.Location = new Point(219, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(100, 82);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblDinamicoTipoCliente);
            groupBox3.Controls.Add(lblTipoActividad);
            groupBox3.Controls.Add(lblDinamicoFechaVencimiento);
            groupBox3.Controls.Add(lblFechaVencimiento);
            groupBox3.Controls.Add(lblDinamicoIdCliente);
            groupBox3.Controls.Add(lblCliente);
            groupBox3.Controls.Add(lblDinamicoImporte);
            groupBox3.Controls.Add(lblImporte);
            groupBox3.Controls.Add(lblDinamicoFormaPago);
            groupBox3.Controls.Add(lblFormaPago);
            groupBox3.Controls.Add(lblDinamicoFechaInscripcion);
            groupBox3.Controls.Add(lblFechaInscripcion);
            groupBox3.Controls.Add(lblDinamicoActividad);
            groupBox3.Controls.Add(lblActividad);
            groupBox3.Controls.Add(lblDinamicoNombre);
            groupBox3.Location = new Point(56, 267);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(536, 262);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lblDinamicoFechaVencimiento
            // 
            lblDinamicoFechaVencimiento.AutoSize = true;
            lblDinamicoFechaVencimiento.Location = new Point(138, 191);
            lblDinamicoFechaVencimiento.Name = "lblDinamicoFechaVencimiento";
            lblDinamicoFechaVencimiento.Size = new Size(154, 15);
            lblDinamicoFechaVencimiento.TabIndex = 12;
            lblDinamicoFechaVencimiento.Text = "dinamicoFechaVencimiento";
            lblDinamicoFechaVencimiento.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(25, 191);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(107, 15);
            lblFechaVencimiento.TabIndex = 11;
            lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // lblDinamicoIdCliente
            // 
            lblDinamicoIdCliente.AutoSize = true;
            lblDinamicoIdCliente.Location = new Point(88, 53);
            lblDinamicoIdCliente.Name = "lblDinamicoIdCliente";
            lblDinamicoIdCliente.Size = new Size(104, 15);
            lblDinamicoIdCliente.TabIndex = 10;
            lblDinamicoIdCliente.Text = "dinamicoIdCliente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(25, 53);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 15);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "ID Cliente";
            // 
            // lblDinamicoImporte
            // 
            lblDinamicoImporte.AutoSize = true;
            lblDinamicoImporte.Location = new Point(392, 224);
            lblDinamicoImporte.Name = "lblDinamicoImporte";
            lblDinamicoImporte.Size = new Size(99, 15);
            lblDinamicoImporte.TabIndex = 8;
            lblDinamicoImporte.Text = "dinamicoImporte";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(325, 224);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(61, 15);
            lblImporte.TabIndex = 7;
            lblImporte.Text = "Importe: $";
            // 
            // lblDinamicoFormaPago
            // 
            lblDinamicoFormaPago.AutoSize = true;
            lblDinamicoFormaPago.Location = new Point(118, 224);
            lblDinamicoFormaPago.Name = "lblDinamicoFormaPago";
            lblDinamicoFormaPago.Size = new Size(132, 15);
            lblDinamicoFormaPago.TabIndex = 6;
            lblDinamicoFormaPago.Text = "dinamicoFormaDePago";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(25, 224);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(87, 15);
            lblFormaPago.TabIndex = 5;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // lblDinamicoFechaInscripcion
            // 
            lblDinamicoFechaInscripcion.AutoSize = true;
            lblDinamicoFechaInscripcion.Location = new Point(146, 157);
            lblDinamicoFechaInscripcion.Name = "lblDinamicoFechaInscripcion";
            lblDinamicoFechaInscripcion.Size = new Size(146, 15);
            lblDinamicoFechaInscripcion.TabIndex = 4;
            lblDinamicoFechaInscripcion.Text = "dinamicoFechaInscripcion";
            // 
            // lblFechaInscripcion
            // 
            lblFechaInscripcion.AutoSize = true;
            lblFechaInscripcion.Location = new Point(25, 157);
            lblFechaInscripcion.Name = "lblFechaInscripcion";
            lblFechaInscripcion.Size = new Size(115, 15);
            lblFechaInscripcion.TabIndex = 3;
            lblFechaInscripcion.Text = "Fecha de inscripción";
            // 
            // lblDinamicoActividad
            // 
            lblDinamicoActividad.AutoSize = true;
            lblDinamicoActividad.Location = new Point(88, 124);
            lblDinamicoActividad.Name = "lblDinamicoActividad";
            lblDinamicoActividad.Size = new Size(107, 15);
            lblDinamicoActividad.TabIndex = 2;
            lblDinamicoActividad.Text = "dinamicoActividad";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(25, 124);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(57, 15);
            lblActividad.TabIndex = 1;
            lblActividad.Text = "Actividad";
            // 
            // lblDinamicoNombre
            // 
            lblDinamicoNombre.AutoSize = true;
            lblDinamicoNombre.Location = new Point(25, 19);
            lblDinamicoNombre.Name = "lblDinamicoNombre";
            lblDinamicoNombre.Size = new Size(138, 15);
            lblDinamicoNombre.TabIndex = 0;
            lblDinamicoNombre.Text = "dinamicoNombreCliente";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(499, 535);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(95, 33);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(25, 91);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(86, 15);
            lblTipoActividad.TabIndex = 13;
            lblTipoActividad.Text = "Tipo de Cliente";
            // 
            // lblDinamicoTipoCliente
            // 
            lblDinamicoTipoCliente.AutoSize = true;
            lblDinamicoTipoCliente.Location = new Point(117, 91);
            lblDinamicoTipoCliente.Name = "lblDinamicoTipoCliente";
            lblDinamicoTipoCliente.Size = new Size(117, 15);
            lblDinamicoTipoCliente.TabIndex = 14;
            lblDinamicoTipoCliente.Text = "dinamicoTipoCliente";
            // 
            // frmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 580);
            Controls.Add(btnImprimir);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "frmComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            Load += frmComprobante_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblDinamicoImporte;
        private Label lblImporte;
        private Label lblDinamicoFormaPago;
        private Label lblFormaPago;
        private Label lblDinamicoFechaInscripcion;
        private Label lblFechaInscripcion;
        private Label lblDinamicoActividad;
        private Label lblActividad;
        private Label lblDinamicoNombre;
        private Button btnImprimir;
        private PictureBox picAvatar;
        private Label lblTitulo;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private ImageList imageList1;
        private Label lblDinamicoIdCliente;
        private Label lblCliente;
        private Label lblDinamicoFechaVencimiento;
        private Label lblFechaVencimiento;
        private Label lblDinamicoTipoCliente;
        private Label lblTipoActividad;
    }
}