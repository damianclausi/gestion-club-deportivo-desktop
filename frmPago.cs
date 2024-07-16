using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using Microsoft.VisualBasic;
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

namespace ClubDeportivo
{
    public partial class frmPago : Form
    {
        private frmPrincipal _formPrincipal;

        static float montoSocio = 25000;



        public frmPago(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            // Vincular el evento CheckedChanged del RadioButton rbtTarjeta al método rbtTarjeta_CheckedChanged
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;


            _formPrincipal = formPrincipal;
            //evento para mostrar la ventan principal si cerramos con la X de la ventana
            this.FormClosing += new FormClosingEventHandler(frmPago_FormClosing);

        }

        private void frmPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar el formulario principal
            _formPrincipal.Show();
        }
        public frmPago()
        {

            InitializeComponent();
            // Vincular el evento CheckedChanged del RadioButton rbtTarjeta al método rbtTarjeta_CheckedChanged
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formPrincipal.Show();
            this.Hide();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }



        private void BuscarCliente()
        {
            string nombreCliente;
            string numeroCliente = txtNumeroCliente.Text.Trim();
            // Verificar si se ingresó un número de cliente
            if (!string.IsNullOrWhiteSpace(numeroCliente))
            {
                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    sqlCon = Conexion.GetInstancia().CrearConexion();
                    string query = "SELECT c.Nombre, s.Id_Socio " +
                                   "FROM clientes c " +
                                   "LEFT JOIN socios s ON c.Id_Cliente = s.Id_Cliente " +
                                   "WHERE c.Id_Cliente = @IdCliente";

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@IdCliente", numeroCliente);

                    sqlCon.Open();

                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        // Obtener el nombre del cliente
                        nombreCliente = reader.GetString(0);
                        lblDinamicoNombreCliente.Text = nombreCliente;

                        dtpFechaPago.Enabled = true;
                        dtpFechaVencimiento.Enabled = true;


                        dtpFechaPago.Value = DateTime.Now;

                        cboTipoActividad.Enabled = true;
                        cboTipoActividad.Items.Clear(); // Limpiar los elementos del ComboBox

                        // Verificar si el cliente es socio o no
                        if (!reader.IsDBNull(1))
                        {
                            // Si el cliente es socio
                            dtpFechaVencimiento.Value = DateTime.Now.AddMonths(1);


                            int idSocio = reader.GetInt32(1);
                            lblDinamicoTipoCliente.Text = "Socio";
                            cboTipoActividad.Items.Add("FULL ACCESS - $25000");
                            cboTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
                            cboTipoActividad.SelectedIndex = 0;
                        }
                        else
                        {
                            // Si el cliente no es socio
                            dtpFechaVencimiento.Value = DateTime.Now;

                            lblDinamicoTipoCliente.Text = "No Socio";
                            LlenarComboBoxActividades(); // Llenar el ComboBox con actividades
                        }

                        //Hacemos visible los datos del cliente
                        lblDinamicoNombreCliente.Visible = true;
                        lblDinamicoTipoCliente.Visible = true;

                        // Habilitar el gpbFormaDePago, boton de pago 
                        gpbFormaDePago.Enabled = true;
                        btnPagar.Enabled = true;
                        //default efectivo el pago
                        rbtEfectivo.Checked = true;




                    }
                    else
                    {
                        MessageBox.Show("El número de cliente ingresado no corresponde a un cliente registrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos del cliente: " + ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void LlenarComboBoxActividades()
        {
            cboTipoActividad.Items.Clear(); // Limpiar los elementos del ComboBox

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                string query = "SELECT Nombre, Costo, Disponibilidad, capacidadActividad, capacidadOcupada FROM actividades";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);

                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                var actividades = new List<Tuple<string, float, int>>();

                while (reader.Read())
                {
                    string nombreActividad = reader.GetString(0);
                    float costo = reader.GetFloat(1);
                    int disponibilidad = reader.GetInt32(2);
                    int capacidad = reader.GetInt32(3);
                    int ocupadas = reader.GetInt32(4);

                    if (disponibilidad == 1)
                    {
                        int cupoDisponible = capacidad - ocupadas;
                        actividades.Add(Tuple.Create(nombreActividad, costo, cupoDisponible));
                    }
                    else
                    {
                        // Actividades no disponibles
                        actividades.Add(Tuple.Create(nombreActividad, costo, 0)); // Cupo disponible es cero
                    }
                }

                // Ordenar por capacidad disponible de forma descendente
                actividades = actividades.OrderByDescending(a => a.Item3).ToList();

                foreach (var actividad in actividades)
                {
                    if (actividad.Item3 > 0)
                    {
                        cboTipoActividad.Items.Add($"{actividad.Item1} - Costo: ${actividad.Item2}, Cupo disponible: {actividad.Item3}");
                    }
                    else
                    {
                        cboTipoActividad.Items.Add($"{actividad.Item1} - Costo: ${actividad.Item2}, Sin Cupo");
                    }
                }

                if (cboTipoActividad.Items.Count > 0)
                {
                    cboTipoActividad.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las actividades: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }






        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboCuotas.SelectedIndex = 0;//para que el valor en tarjeta quede en 1 y no genere en confusión mas allá que se deshablita
            // Verificar si el RadioButton rbtTarjeta está seleccionado
            if (rbtTarjeta.Checked)
            {
                // Habilitar el ComboBox cboCuotas
                cboCuotas.Enabled = true;
            }
            else
            {
                // Deshabilitar el ComboBox cboCuotas
                cboCuotas.Enabled = false;

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Obtener la actividad seleccionada
            string actividadSeleccionada = cboTipoActividad.SelectedItem != null ? cboTipoActividad.SelectedItem.ToString() : "No seleccionada";

            // Determinar la forma de pago y la cantidad de cuotas
            string formaPago = rbtEfectivo.Checked ? "Efectivo" : (rbtTarjeta.Checked ? "Tarjeta" : "No especificada");
            string descripcion;
            if (rbtTarjeta.Checked)
            {
                descripcion = $"Actividad: {actividadSeleccionada.Split(new string[] { ", Cupo disponible:" }, StringSplitOptions.None)[0]} - Forma de pago: {formaPago} ({cboCuotas.SelectedItem} cuotas)";
            }
            else
            {
                descripcion = $"Actividad: {actividadSeleccionada.Split(new string[] { ", Cupo disponible:" }, StringSplitOptions.None)[0]} - Forma de pago: {formaPago}";
            }

            // Determinar el monto
            float monto;
            if (lblDinamicoTipoCliente.Text == "Socio")
            {
                // monto = 25000; // Monto fijo para socios
                monto = frmPago.montoSocio; //USAMOS STATIC PARA TODA LA CLASE
            }
            else
            {
                // Obtener el costo de la actividad desde el texto seleccionado en el combo box
                string selectedActivity = actividadSeleccionada;
                int costoIndex = selectedActivity.IndexOf("Costo: $") + "Costo: $".Length;
                int endIndex = selectedActivity.IndexOf(", Cupo disponible:");
                // Verificar si la actividad seleccionada tiene cupo disponible
                if (actividadSeleccionada.Contains("Sin Cupo"))
                {
                    MessageBox.Show("La actividad seleccionada no tiene cupo disponible. Por favor, seleccione otra actividad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (costoIndex > "Costo: $".Length - 1 && endIndex > costoIndex)
                    {
                        string costoStr = selectedActivity.Substring(costoIndex, endIndex - costoIndex).Trim();
                        if (!float.TryParse(costoStr, out monto))
                        {
                            MessageBox.Show("Error al determinar el costo de la actividad seleccionada.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al determinar el costo de la actividad seleccionada.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                actividadSeleccionada = cboTipoActividad.SelectedItem != null ? cboTipoActividad.SelectedItem.ToString() : "No seleccionada";
            }

            // Crear el objeto E_Cuota
            E_Cuota eCuota = new E_Cuota();

            eCuota.Descripcion = descripcion;
            eCuota.Monto = monto;
            eCuota.FechaPago = dtpFechaPago.Value;
            eCuota.FechaVencimiento = dtpFechaVencimiento.Value;
            eCuota.id = int.Parse(txtNumeroCliente.Text.Trim());

            // Instanciar la clase Cuotas y realizar el pago
            Datos.Cuotas dCuota = new Datos.Cuotas();
            string respuesta = dCuota.PagarCuota(eCuota);

            // Manejar la respuesta
            bool esNumero = int.TryParse(respuesta, out int codigo);
            if (esNumero)
            {
                if (codigo == -1)
                {
                    MessageBox.Show("ERROR AL REGISTRAR EL PAGO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (codigo == -2)
                {
                    MessageBox.Show("Ya pago hoy", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    // Pago exitoso, mostrar el mensaje con ID de cuota y fecha actual
                    MessageBox.Show($"Pago exitoso, con ID CUOTA {codigo} - Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Habilito comprobante
                    btnComprobante.Enabled = true;
                    btnPagar.Enabled = false;

                    string tipoActividadSeleccionada;
                    // Pago exitoso, guardar el tipo de actividad seleccionada
                    if (lblDinamicoTipoCliente.Text == "No Socio")
                    {
                        tipoActividadSeleccionada = cboTipoActividad.SelectedItem.ToString().Split('-')[0].Trim();

                        E_Actividad eActividad = new E_Actividad();
                        eActividad.nombre = tipoActividadSeleccionada;

                        Datos.Actividades dActividad = new Datos.Actividades();
                        respuesta = dActividad.IncrementarCapacidadOcupada(eActividad);

                        // Obtener el ID del cliente
                        int idCliente = int.Parse(txtNumeroCliente.Text.Trim());

                        // Insertar la actividad para el cliente no socio
                        Datos.NoSociosActividades noSociosActividades = new Datos.NoSociosActividades();
                        respuesta = noSociosActividades.InsertarNoSocioActividad(idCliente, tipoActividadSeleccionada);
                    }
                    else
                    {
                        tipoActividadSeleccionada = "FULL ACCESS"; // Para socios, asumimos que siempre es "FULL ACCESS"
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Error: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarFormulario()
        {
            // Limpiar campos y restablecer valores predeterminados
            txtNumeroCliente.Text = "";
            lblDinamicoNombreCliente.Text = "";
            lblDinamicoTipoCliente.Text = "";
            cboTipoActividad.Items.Clear();
            cboTipoActividad.Enabled = false;
            gpbFormaDePago.Enabled = false;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = 0;
            btnPagar.Enabled = false;
            btnComprobante.Enabled = false;
            dtpFechaPago.Enabled = false;
            dtpFechaVencimiento.Enabled = false;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            /* Lo pasamos como parámetro al formulario para poder volverlo a mostrar            
            el formulario Pago cuando terminemos la inscripción */
            frmComprobante formComprobante = new frmComprobante(this);

            // Asignar los valores correctos a las propiedades del formulario de comprobante
            formComprobante.dinamicoIdCliente = txtNumeroCliente.Text.Trim();
            formComprobante.dinamicoNombre = lblDinamicoNombreCliente.Text; // Nombre del cliente



            // Fecha de inscripción**
            formComprobante.dinamicoFechaInscripcion = DateTime.Now.ToString("dd-MM-yyyy");

            // Forma de pago basado en el RadioButton seleccionado
            if (rbtEfectivo.Checked)
            {
                formComprobante.dinamicoFormaPago = "Efectivo";
            }
            else if (rbtTarjeta.Checked)
            {
                formComprobante.dinamicoFormaPago = "Tarjeta";
                formComprobante.dinamicoFormaPago += $" ({cboCuotas.SelectedItem} cuotas)";
            }

            // Establecer el importe adecuadamente
            if (lblDinamicoTipoCliente.Text == "Socio")
            {
                formComprobante.dinamicoTipoCliente = "Socio";
                formComprobante.dininamicoImporte = "25000"; // Importe para socios
                formComprobante.dinamicoFechaVencimiento = DateTime.Now.AddMonths(1).ToString("dd-MM-yyyy");
                formComprobante.dinamicoActividad = "FULL ACCESS";
            }
            else
            {
                formComprobante.dinamicoTipoCliente = "No Socio";
                // Obtener solo el nombre de la actividad sin el costo y cupo disponible
                string selectedActivity = cboTipoActividad.SelectedItem.ToString();
                int index = selectedActivity.IndexOf(" - Costo: ");
                if (index >= 0)
                {
                    formComprobante.dinamicoActividad = selectedActivity.Substring(0, index);
                }
                else
                {
                    formComprobante.dinamicoActividad = selectedActivity; // En caso de que el formato sea inesperado
                }
                formComprobante.dinamicoFechaVencimiento = DateTime.Now.ToString("dd-MM-yyyy");
                // Extraer el importe desde el ComboBox (el formato es "Nombre - Costo: $<costo>, Cupo disponible: <cupo>")
                int costoIndex = selectedActivity.IndexOf("Costo: $") + "Costo: $".Length;
                int endIndex = selectedActivity.IndexOf(", Cupo disponible:");
                if (costoIndex > "Costo: $".Length - 1 && endIndex > costoIndex)
                {
                    string costoStr = selectedActivity.Substring(costoIndex, endIndex - costoIndex).Trim();
                    formComprobante.dininamicoImporte = costoStr;
                }
                else
                {
                    formComprobante.dininamicoImporte = "0"; // En caso de que el formato sea inesperado
                }
            }

            formComprobante.Show();
            this.Hide();
        }


        private void frmPago_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
