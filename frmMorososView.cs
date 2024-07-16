using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClubDeportivo
{
    public partial class frmMorososView : Form
    {
        private frmPrincipal _formPrincipal;

        public frmMorososView(frmPrincipal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
            //evento para mostrar la ventan principal si cerramos con la X de la ventana
            this.FormClosing += new FormClosingEventHandler(frmMorososView_FormClosing);
        }

        private void frmMorososView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar el formulario principal
            _formPrincipal.Show();
        }
        public frmMorososView()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            /*frmPrincipal principal = new frmPrincipal();
            principal.Show();*/
            _formPrincipal.Show();
            this.Hide();
        }

        private void frmMorososView_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.GetInstancia().CrearConexion();
                query = @"SELECT 
                                s.Id_Socio AS ""Nro de Socio"",
                                c.Nombre,
                                c.Direccion,
                                q.Fecha_Pago,
                                q.Fecha_Vencimiento,
                                DATEDIFF(CURDATE(), q.Fecha_Vencimiento) AS ""Dias de Mora""
                            FROM 
                                cuotas q
                            INNER JOIN 
                                socios s ON q.Id_Socio = s.Id_Socio
                            INNER JOIN 
                                clientes c ON s.Id_Cliente = c.Id_Cliente
                            INNER JOIN (
                                SELECT 
                                    Id_Socio, 
                                    MAX(Fecha_Pago) AS Ultima_Fecha_Pago
                                FROM 
                                    cuotas
                                GROUP BY 
                                    Id_Socio
                            ) ult_q ON q.Id_Socio = ult_q.Id_Socio AND q.Fecha_Pago = ult_q.Ultima_Fecha_Pago
                            WHERE 
                                q.Fecha_Vencimiento <= CURDATE() 
                                AND DATEDIFF(CURDATE(), q.Fecha_Vencimiento) > 0;
                            ";


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    { 
                        int renglon = dgtvMorosos.Rows.Add();
                        dgtvMorosos.Rows[renglon].Cells[0].Value = reader.GetInt32(0);//numero de socio
                        dgtvMorosos.Rows[renglon].Cells[1].Value = reader.GetString(1); // nombre   
                        dgtvMorosos.Rows[renglon].Cells[2].Value = reader.GetString(2);//direccion                         
                        dgtvMorosos.Rows[renglon].Cells[3].Value = reader.GetDateTime(3).ToString("dd-MM-yyyy");//fecha de pago
                        dgtvMorosos.Rows[renglon].Cells[4].Value = reader.GetDateTime(4).ToString("dd-MM-yyyy");//fecha de vencimiento
                        dgtvMorosos.Rows[renglon].Cells[5].Value = reader.GetInt32(5);//dias de mora
                       
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
        }

    }
}
