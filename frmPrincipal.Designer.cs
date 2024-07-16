namespace ClubDeportivo
{
    partial class frmPrincipal
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
            btnAltaCliente = new Button();
            btnPagarCurso = new Button();
            btnListadoMorosos = new Button();
            btnSalir = new Button();
            lblIngreso = new Label();
            btnCarnetSocio = new Button();
            btnListarClientes = new Button();
            SuspendLayout();
            // 
            // btnAltaCliente
            // 
            btnAltaCliente.Location = new Point(52, 68);
            btnAltaCliente.Name = "btnAltaCliente";
            btnAltaCliente.Size = new Size(186, 41);
            btnAltaCliente.TabIndex = 0;
            btnAltaCliente.Text = "Alta Cliente";
            btnAltaCliente.UseVisualStyleBackColor = true;
            btnAltaCliente.Click += btnInscribir_Click;
            // 
            // btnPagarCurso
            // 
            btnPagarCurso.Location = new Point(339, 68);
            btnPagarCurso.Name = "btnPagarCurso";
            btnPagarCurso.Size = new Size(179, 41);
            btnPagarCurso.TabIndex = 2;
            btnPagarCurso.Text = "Pagar";
            btnPagarCurso.UseVisualStyleBackColor = true;
            btnPagarCurso.Click += btnPagarCurso_Click;
            // 
            // btnListadoMorosos
            // 
            btnListadoMorosos.Enabled = false;
            btnListadoMorosos.Location = new Point(52, 283);
            btnListadoMorosos.Name = "btnListadoMorosos";
            btnListadoMorosos.Size = new Size(173, 41);
            btnListadoMorosos.TabIndex = 3;
            btnListadoMorosos.Text = "Listar Morosos (solo admin)";
            btnListadoMorosos.UseVisualStyleBackColor = true;
            btnListadoMorosos.Click += btnListadoMorosos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(437, 296);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 28);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button5_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(35, 17);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(173, 15);
            lblIngreso.TabIndex = 5;
            lblIngreso.Text = "USUARIO: UsuarioPrueba (Tipo)";
            lblIngreso.Click += lblIngreso_Click;
            // 
            // btnCarnetSocio
            // 
            btnCarnetSocio.Location = new Point(339, 175);
            btnCarnetSocio.Name = "btnCarnetSocio";
            btnCarnetSocio.Size = new Size(173, 41);
            btnCarnetSocio.TabIndex = 1;
            btnCarnetSocio.Text = "Emitir Carnet Socio";
            btnCarnetSocio.UseVisualStyleBackColor = true;
            btnCarnetSocio.Click += btnCarnetSocio_Click;
            // 
            // btnListarClientes
            // 
            btnListarClientes.Location = new Point(52, 175);
            btnListarClientes.Name = "btnListarClientes";
            btnListarClientes.Size = new Size(179, 39);
            btnListarClientes.TabIndex = 8;
            btnListarClientes.Text = "Listar Clientes con Actividades";
            btnListarClientes.UseVisualStyleBackColor = true;
            btnListarClientes.Click += btnListarClientes_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 364);
            Controls.Add(btnListarClientes);
            Controls.Add(btnCarnetSocio);
            Controls.Add(lblIngreso);
            Controls.Add(btnSalir);
            Controls.Add(btnListadoMorosos);
            Controls.Add(btnPagarCurso);
            Controls.Add(btnAltaCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltaCliente;
        private Button btnPagarCurso;
        private Button btnListadoMorosos;
        private Button btnSalir;
        private Label lblIngreso;
        private Button btnCarnetSocio;
        private Button btnListarClientes;
    }
}