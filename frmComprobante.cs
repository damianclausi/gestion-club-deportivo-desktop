using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmComprobante : Form
    {
        private frmPago _formPago;

        public string? dinamicoIdCliente;
        public string? dinamicoNombre;
        public string? dinamicoTipoCliente;
        public string? dinamicoActividad;
        public string? dinamicoFechaInscripcion;
        public string? dinamicoFechaVencimiento;
        public string? dinamicoFormaPago;
        public string? dininamicoImporte;

        public frmComprobante(frmPago formPago)
        {
            InitializeComponent();
            _formPago = formPago;
            //evento para mostrar la ventana Pago si cerramos con la X de la ventana
            this.FormClosing += new FormClosingEventHandler(frmComprobante_FormClosing);

        }

        private void frmComprobante_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar el formulario Pago
            _formPago.Show();
        }

        public frmComprobante()
        {
            InitializeComponent();
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            lblDinamicoIdCliente.Text = dinamicoIdCliente;
            lblDinamicoNombre.Text = dinamicoNombre;
            lblDinamicoTipoCliente.Text = dinamicoTipoCliente;
            lblDinamicoActividad.Text = dinamicoActividad;
            lblDinamicoFechaInscripcion.Text = dinamicoFechaInscripcion;
            lblDinamicoFormaPago.Text = dinamicoFormaPago;
            lblDinamicoImporte.Text = dininamicoImporte;
            lblDinamicoFechaVencimiento.Text = dinamicoFechaVencimiento;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            /* -----------------------------------------------------
                       * Ocultamos los botones que no pertenecen al diseño
                       * pero si para la funcionalidad
                       * Usamos la propiedad VISIBLE y los posibles
                       * valores son True o False
                       * ---------------------------------------------------- */
            btnImprimir.Visible = false;
            /* ---------------------------------------
            * creamos los objetos para la impresion
            * ------------------------------------------ */

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true; // visualizamos nuevamente el   objeto
            /* _________________________________
            * regreso al formulario principal
            * después del dar aviso
            * ---------------------------------- */
            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmPrincipal principal = new frmPrincipal();
            _formPago.Show();
            this.Close();
        }
        /* -------------------------------------------------------
      * Conjunto de sentencias necesarias para
      * el objeto Print
      * ------------------------------------------------------- */
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
