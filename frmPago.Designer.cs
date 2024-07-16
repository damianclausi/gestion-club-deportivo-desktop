namespace ClubDeportivo
{
    partial class frmPago
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
            gpbFormaDePago = new GroupBox();
            cboCuotas = new ComboBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            lblIngreseCliente = new Label();
            txtNumeroCliente = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            btnBuscar = new Button();
            cboTipoActividad = new ComboBox();
            lblTipoActividad = new Label();
            lblDinamicoNombreCliente = new Label();
            lblDinamicoTipoCliente = new Label();
            btnLimpiar = new Button();
            dtpFechaPago = new DateTimePicker();
            dtpFechaVencimiento = new DateTimePicker();
            lblFechaPago = new Label();
            lblFechaVencimiento = new Label();
            gpbFormaDePago.SuspendLayout();
            SuspendLayout();
            // 
            // gpbFormaDePago
            // 
            gpbFormaDePago.Controls.Add(cboCuotas);
            gpbFormaDePago.Controls.Add(rbtTarjeta);
            gpbFormaDePago.Controls.Add(rbtEfectivo);
            gpbFormaDePago.Enabled = false;
            gpbFormaDePago.Location = new Point(370, 48);
            gpbFormaDePago.Name = "gpbFormaDePago";
            gpbFormaDePago.Size = new Size(246, 166);
            gpbFormaDePago.TabIndex = 0;
            gpbFormaDePago.TabStop = false;
            gpbFormaDePago.Text = "Forma de Pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Enabled = false;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(15, 103);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 4;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(15, 66);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(59, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(15, 27);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblIngreseCliente
            // 
            lblIngreseCliente.AutoSize = true;
            lblIngreseCliente.Location = new Point(36, 48);
            lblIngreseCliente.Name = "lblIngreseCliente";
            lblIngreseCliente.Size = new Size(146, 15);
            lblIngreseCliente.TabIndex = 2;
            lblIngreseCliente.Text = "Ingrese número de Cliente";
            // 
            // txtNumeroCliente
            // 
            txtNumeroCliente.Location = new Point(36, 71);
            txtNumeroCliente.Name = "txtNumeroCliente";
            txtNumeroCliente.Size = new Size(102, 23);
            txtNumeroCliente.TabIndex = 3;
            // 
            // btnPagar
            // 
            btnPagar.Enabled = false;
            btnPagar.Location = new Point(385, 269);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(385, 315);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(102, 23);
            btnComprobante.TabIndex = 5;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(541, 315);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(172, 73);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cboTipoActividad
            // 
            cboTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoActividad.Enabled = false;
            cboTipoActividad.FormattingEnabled = true;
            cboTipoActividad.Location = new Point(36, 191);
            cboTipoActividad.Name = "cboTipoActividad";
            cboTipoActividad.Size = new Size(286, 23);
            cboTipoActividad.TabIndex = 0;
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(36, 159);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(99, 15);
            lblTipoActividad.TabIndex = 8;
            lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // lblDinamicoNombreCliente
            // 
            lblDinamicoNombreCliente.AutoSize = true;
            lblDinamicoNombreCliente.Location = new Point(36, 130);
            lblDinamicoNombreCliente.Name = "lblDinamicoNombreCliente";
            lblDinamicoNombreCliente.Size = new Size(138, 15);
            lblDinamicoNombreCliente.TabIndex = 9;
            lblDinamicoNombreCliente.Text = "dinamicoNombreCliente";
            lblDinamicoNombreCliente.Visible = false;
            // 
            // lblDinamicoTipoCliente
            // 
            lblDinamicoTipoCliente.AutoSize = true;
            lblDinamicoTipoCliente.Location = new Point(181, 130);
            lblDinamicoTipoCliente.Name = "lblDinamicoTipoCliente";
            lblDinamicoTipoCliente.Size = new Size(117, 15);
            lblDinamicoTipoCliente.TabIndex = 10;
            lblDinamicoTipoCliente.Text = "dinamicoTipoCliente";
            lblDinamicoTipoCliente.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(541, 269);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Enabled = false;
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(224, 267);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(98, 23);
            dtpFechaPago.TabIndex = 12;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Enabled = false;
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(224, 315);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(98, 23);
            dtpFechaVencimiento.TabIndex = 13;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(150, 277);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(68, 15);
            lblFechaPago.TabIndex = 14;
            lblFechaPago.Text = "Fecha Pago";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(111, 321);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(107, 15);
            lblFechaVencimiento.TabIndex = 15;
            lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 385);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblFechaPago);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(dtpFechaPago);
            Controls.Add(btnLimpiar);
            Controls.Add(lblDinamicoTipoCliente);
            Controls.Add(lblDinamicoNombreCliente);
            Controls.Add(lblTipoActividad);
            Controls.Add(cboTipoActividad);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtNumeroCliente);
            Controls.Add(lblIngreseCliente);
            Controls.Add(gpbFormaDePago);
            MaximizeBox = false;
            Name = "frmPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos";
            Load += frmPago_Load_1;
            gpbFormaDePago.ResumeLayout(false);
            gpbFormaDePago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbFormaDePago;
        private ComboBox cboTipoActividad;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private Label lblTipoActividad;
        private TextBox textBox1;
        private Button btnBuscar;
        private Button button2;
        private Button button3;
        private Label lblIngreseCliente;
        private TextBox txtNumeroCliente;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
        private ComboBox cboCuotas;
        private Label lblDinamicoNombreCliente;
        private Label lblDinamicoTipoCliente;
        private Button btnLimpiar;
        private DateTimePicker dtpFechaPago;
        private DateTimePicker dtpFechaVencimiento;
        private Label lblFechaPago;
        private Label lblFechaVencimiento;
    }
}