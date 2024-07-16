namespace ClubDeportivo
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblPass = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            picLogin = new PictureBox();
            lblInfo = new Label();
            lblInfo2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(158, -118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(158, -68);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(254, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(137, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter_1;
            txtUsuario.Leave += txtUsuario_Leave_1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(254, 160);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(137, 23);
            txtPass.TabIndex = 1;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.KeyDown += txtPass_KeyDown;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(197, 264);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // picLogin
            // 
            picLogin.BackgroundImage = Properties.Resources.login;
            picLogin.BackgroundImageLayout = ImageLayout.Zoom;
            picLogin.Image = Properties.Resources.login;
            picLogin.InitialImage = null;
            picLogin.Location = new Point(73, 76);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(131, 129);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 5;
            picLogin.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(223, 208);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(206, 15);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Usuario: prueba  -  Contraseña:123456";
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(223, 233);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(204, 15);
            lblInfo2.TabIndex = 7;
            lblInfo2.Text = "Usuario: admin  -  Contraseña: admin";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 327);
            Controls.Add(lblInfo2);
            Controls.Add(lblInfo);
            Controls.Add(picLogin);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
        private PictureBox picLogin;
        private Label lblInfo;
        private Label lblInfo2;
    }
}
