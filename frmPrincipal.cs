using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
           
        }

       

        internal string? rol;
        internal string? usuario;


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            if (rol == "Administrador")
            {
                btnListadoMorosos.Enabled = true;
            }

        }
        /*
        protected override void OnVisibleChanged(EventArgs e)
        {
            //para cargar la grilla con los datos actualizados
            dtgvClientes.Rows.Clear();
            base.OnVisibleChanged(e);
            if (Visible)
            {
                CargarGrilla();
            }
        }
        */

       

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            /*lo pasamos como parametro al formulario para poder volverlo a mostrar            
            el formulario principal cuando terminemos la inscripción*/
            frmIncripcion formInscripcion = new frmIncripcion(this);
            formInscripcion.Show();
            this.Hide();


        }

        private void btnCarnetSocio_Click(object sender, EventArgs e)
        {
            {
                // Abrir cuadro de diálogo para ingresar el número de cliente
                string numeroCliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de cliente:", "Número de Cliente", "");

                // Verificar si se ingresó un número de cliente
                if (!string.IsNullOrWhiteSpace(numeroCliente))
                {
                    MySqlConnection sqlCon = new MySqlConnection();
                    try
                    {
                        sqlCon = Conexion.GetInstancia().CrearConexion();
                        string query = "SELECT c.Nombre, c.DNI, c.Direccion, c.Fecha_Nacimiento, c.Fecha_Alta, s.Id_Carnet " +
                                       "FROM clientes c " +
                                       "INNER JOIN socios s ON c.Id_Cliente = s.Id_Cliente " +
                                       "WHERE c.Id_Cliente = @IdCliente";

                        MySqlCommand comando = new MySqlCommand(query, sqlCon);
                        comando.Parameters.AddWithValue("@IdCliente", numeroCliente);

                        sqlCon.Open();

                        MySqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            // Pasar los datos del socio al formulario de carnet                            
                            frmCarnet carnet = new frmCarnet(this);
                            carnet.dinamicoNombre = reader.GetString(0); // Nombre
                            carnet.dinamicoDocumento = reader.GetInt32(1).ToString(); // DNI
                            carnet.dinamicoDireccion = reader.GetString(2); // Dirección
                            carnet.dinamicoFechaNacimiento = reader.GetDateTime(3).ToString("yyyy-MM-dd"); // Fecha de Nacimiento
                            carnet.dinamicoFechaIngreso = reader.GetDateTime(4).ToString("yyyy-MM-dd"); // Fecha de Ingreso
                            carnet.dininamicoCarnet = reader.GetInt32(5).ToString(); // Número de Carnet
                            carnet.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El número de cliente ingresado no corresponde a un socio.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos del socio: " + ex.Message);
                    }
                    finally
                    {
                        sqlCon.Close();
                    }
                }


            }
        }

        private void btnPagarCurso_Click(object sender, EventArgs e)
        {
            /*lo pasamos como parametro al formulario para poder volverlo a mostrar            
             el formulario principal cuando terminemos la inscripción*/
            frmPago formPago = new frmPago(this);
            formPago.Show();
            this.Hide();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si cerramos el formulario principal aplicación con la X de la ventana se finaliza también
            Application.Exit();
        }

        private void btnListadoMorosos_Click(object sender, EventArgs e)
        {
            /*lo pasamos como parametro al formulario para poder volverlo a mostrar            
           el formulario principal cuando terminemos la inscripción*/
            frmMorososView formMorososView = new frmMorososView(this);
            formMorososView.Show();
            this.Hide();

        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            /*lo pasamos como parametro al formulario para poder volverlo a mostrar            
           el formulario principal cuando terminemos la inscripción*/
            frmClientesActividadView formClientes = new frmClientesActividadView(this);
            formClientes.Show();
            this.Hide();
        }
    }
}
