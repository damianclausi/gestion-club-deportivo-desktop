using Org.BouncyCastle.Pqc.Crypto.Lms;
using ClubDeportivo.Datos;
using System.Data;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ClubDeportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }


        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que   contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");

                frmPrincipal Principal = new frmPrincipal();


                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);


                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
        //para poder ingresar con enter desde el segundo textbox
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se produzca el sonido de "ding"
                btnIngresar.PerformClick(); // Simula el clic en el botón
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si cerramos el formulario de la login de  aplicación con la X de la ventana se finaliza también
            Application.Exit();
        }
    }
}
