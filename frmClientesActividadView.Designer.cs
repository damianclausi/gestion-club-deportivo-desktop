namespace ClubDeportivo
{
    partial class frmClientesActividadView
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
            dtgvClientes = new DataGridView();
            idCliente = new DataGridViewTextBoxColumn();
            tipoCliente = new DataGridViewTextBoxColumn();
            nombreCliente = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            fichaMedica = new DataGridViewTextBoxColumn();
            idCuota = new DataGridViewTextBoxColumn();
            descripcionCuota = new DataGridViewTextBoxColumn();
            lblFiltros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dtgvClientes
            // 
            dtgvClientes.AllowUserToAddRows = false;
            dtgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Columns.AddRange(new DataGridViewColumn[] { idCliente, tipoCliente, nombreCliente, dni, direccion, fechaNacimiento, fechaAlta, fichaMedica, idCuota, descripcionCuota });
            dtgvClientes.Location = new Point(12, 41);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.ReadOnly = true;
            dtgvClientes.RowHeadersVisible = false;
            dtgvClientes.RowTemplate.Height = 25;
            dtgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvClientes.Size = new Size(772, 449);
            dtgvClientes.TabIndex = 7;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "ID Cliente";
            idCliente.Name = "idCliente";
            idCliente.ReadOnly = true;
            idCliente.Width = 77;
            // 
            // tipoCliente
            // 
            tipoCliente.HeaderText = "Tipo de Cliente";
            tipoCliente.Name = "tipoCliente";
            tipoCliente.ReadOnly = true;
            tipoCliente.Width = 102;
            // 
            // nombreCliente
            // 
            nombreCliente.HeaderText = "Nombre y Apellido";
            nombreCliente.Name = "nombreCliente";
            nombreCliente.ReadOnly = true;
            nombreCliente.Width = 121;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Width = 52;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Width = 82;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            fechaNacimiento.Width = 132;
            // 
            // fechaAlta
            // 
            fechaAlta.HeaderText = "Fecha de Alta";
            fechaAlta.Name = "fechaAlta";
            fechaAlta.ReadOnly = true;
            fechaAlta.Width = 76;
            // 
            // fichaMedica
            // 
            fichaMedica.HeaderText = "Ficha Medica";
            fichaMedica.Name = "fichaMedica";
            fichaMedica.ReadOnly = true;
            fichaMedica.Width = 94;
            // 
            // idCuota
            // 
            idCuota.HeaderText = "ID Cuota";
            idCuota.Name = "idCuota";
            idCuota.ReadOnly = true;
            idCuota.Width = 72;
            // 
            // descripcionCuota
            // 
            descripcionCuota.HeaderText = "Descripcion Cuota";
            descripcionCuota.Name = "descripcionCuota";
            descripcionCuota.ReadOnly = true;
            descripcionCuota.Width = 118;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Location = new Point(12, 9);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(532, 15);
            lblFiltros.TabIndex = 8;
            lblFiltros.Text = "Fiiltros: Botón derecho para ver más campos - Ordernar por columna haciendo click sobre la misma";
            // 
            // frmClientesActividadView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 517);
            Controls.Add(lblFiltros);
            Controls.Add(dtgvClientes);
            Name = "frmClientesActividadView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actividades por Cliente";
            Load += ClientesView_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvClientes;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn tipoCliente;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn fechaAlta;
        private DataGridViewTextBoxColumn fichaMedica;
        private DataGridViewTextBoxColumn idCuota;
        private DataGridViewTextBoxColumn descripcionCuota;
        private Label lblFiltros;
    }
}