using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using static Mysqlx.Crud.Order.Types;

namespace ClubDeportivo
{
    public partial class frmIncripcion : Form
    {
        private frmPrincipal _formPrincipal;

        public frmIncripcion(frmPrincipal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
            //evento para mostrar la ventan principal si cerramos con la X de la ventana
            this.FormClosing += new FormClosingEventHandler(frmInscripcion_FormClosing);

        }

        private void frmInscripcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar el formulario principal
            _formPrincipal.Show();
        }

        public frmIncripcion()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtDocumento.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*)", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarDNI(txtDocumento.Text))
            {
                MessageBox.Show("El DNI ingresado no es válido. Debe contener entre 7 y 8 dígitos.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                
                string auxNombre; 
                int auxDni; 
                string auxDireccion; 
                DateTime auxFechaNacimiento; 
                DateTime auxFechaAlta;
                bool auxFichaMedica;
                
                auxNombre = txtNombre.Text;
                auxDireccion = txtDireccion.Text;
                auxDni = Convert.ToInt32(txtDocumento.Text);
                auxFechaNacimiento = dtpFechaNacimiento.Value;
                auxFechaAlta = DateTime.Now;
                auxFichaMedica = chkSocio.Checked;

                if (chkSocio.Checked)
                {
                    E_Socio socio = new E_Socio();
                    socio.NombreSocio = auxNombre;
                    socio.DireccionSocio = auxDireccion;
                    socio.DniSocio = auxDni;
                    socio.FechaNacimientoSocio = auxFechaNacimiento;
                    socio.FechaAltaSocio = auxFechaAlta;
                    socio.FichaMedicaSocio = auxFichaMedica;


                    Datos.Socios socios = new Datos.Socios();
                    
                    respuesta = socios.Inscribir(socio);
                }
                else
                {
                    E_NoSocio noSocio = new E_NoSocio();
                    noSocio.NombreNoSocio = auxNombre;
                    noSocio.DireccionNoSocio = auxDireccion;
                    noSocio.DniNoSocio = auxDni;
                    noSocio.FechaNacimientoNoSocio = auxFechaNacimiento;
                    noSocio.FechaAltaNoSocio = auxFechaAlta;
                    noSocio.FichaMedicaNoSocio = auxFichaMedica;


                    Datos.NoSocios noSocios = new Datos.NoSocios();
                    respuesta = noSocios.Inscribir(noSocio);
                }

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == -1)
                    {
                        MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con éxito: " + txtNombre.Text + " con código de Cliente Nro " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtNombre.Focus();
            chkSocio.Checked = false;
            chkFichaMedica.Checked = false;

        }

        private void frmIncripcion_Load(object sender, EventArgs e)
        {
        }
        private bool ValidarDNI(string dni)
        {
            // Verificar si el DNI tiene entre 7 y 8 caracteres y si todos son dígitos
            if (dni.Length >= 7 && dni.Length <= 8 && dni.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }


    }

}

