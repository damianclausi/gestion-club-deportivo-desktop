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
    public partial class frmCarnet : Form
    {
        private frmPrincipal _formPrincipal;

        public frmCarnet(frmPrincipal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
            //evento para mostrar la ventan principal si cerramos con la X de la ventana
            this.FormClosing += new FormClosingEventHandler(frmCarnet_FormClosing);

        }

        private void frmCarnet_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar el formulario principal
            _formPrincipal.Show();
        }
        public frmCarnet()
        {
            InitializeComponent();
        }
        public string? dinamicoNombre;
        public string? dinamicoDocumento;
        public string? dinamicoDireccion;
        public string? dinamicoFechaNacimiento;
        public string? dinamicoFechaIngreso;
        public string? dininamicoCarnet;


        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblDinamicoNombre.Text = dinamicoNombre;
            lblDinamicoDocumento.Text = dinamicoDocumento;
            lblDinamicoDireccion.Text = dinamicoDireccion;
            lblDinamicoNacimiento.Text = dinamicoFechaNacimiento;
            lblDinamicoFechaIngreso.Text = dinamicoFechaIngreso;
            lblDinamicoCarnet.Text = dininamicoCarnet;
        }

        private void lblImprimir_Click(object sender, EventArgs e)
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
            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frmPrincipal principal = new frmPrincipal();
            _formPrincipal.Show();
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
