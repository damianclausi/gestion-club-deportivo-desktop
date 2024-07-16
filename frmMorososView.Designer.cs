namespace ClubDeportivo
{
    partial class frmMorososView
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
            dgtvMorosos = new DataGridView();
            btnVolver = new Button();
            nroSocio = new DataGridViewTextBoxColumn();
            nombreApellido = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            fechaPago = new DataGridViewTextBoxColumn();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            diasDeMora = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgtvMorosos).BeginInit();
            SuspendLayout();
            // 
            // dgtvMorosos
            // 
            dgtvMorosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvMorosos.Columns.AddRange(new DataGridViewColumn[] { nroSocio, nombreApellido, direccion, fechaPago, fechaVencimiento, diasDeMora });
            dgtvMorosos.Location = new Point(30, 35);
            dgtvMorosos.Name = "dgtvMorosos";
            dgtvMorosos.RowTemplate.Height = 25;
            dgtvMorosos.Size = new Size(681, 460);
            dgtvMorosos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(636, 531);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // nroSocio
            // 
            nroSocio.HeaderText = "Nro de Socio";
            nroSocio.Name = "nroSocio";
            // 
            // nombreApellido
            // 
            nombreApellido.HeaderText = "Nombre";
            nombreApellido.Name = "nombreApellido";
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            // 
            // fechaPago
            // 
            fechaPago.HeaderText = "Fecha Pago";
            fechaPago.Name = "fechaPago";
            // 
            // fechaVencimiento
            // 
            fechaVencimiento.HeaderText = "Fecha de Vencimiento";
            fechaVencimiento.Name = "fechaVencimiento";
            // 
            // diasDeMora
            // 
            diasDeMora.HeaderText = "Dias de Mora";
            diasDeMora.Name = "diasDeMora";
            // 
            // frmMorososView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 566);
            Controls.Add(btnVolver);
            Controls.Add(dgtvMorosos);
            MaximizeBox = false;
            Name = "frmMorososView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Morosos";
            Load += frmMorososView_Load;
            ((System.ComponentModel.ISupportInitialize)dgtvMorosos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgtvMorosos;
        private Button btnVolver;
        private DataGridViewTextBoxColumn nroSocio;
        private DataGridViewTextBoxColumn nombreApellido;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn fechaPago;
        private DataGridViewTextBoxColumn fechaVencimiento;
        private DataGridViewTextBoxColumn diasDeMora;
    }
}