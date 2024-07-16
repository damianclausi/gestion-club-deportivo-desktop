using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmClientesActividadView : Form
    {
        private frmPrincipal _formPrincipal;

        public frmClientesActividadView(frmPrincipal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
            this.FormClosing += new FormClosingEventHandler(frmClientesView_FormClosing);
        }

        private void frmClientesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formPrincipal.Show();
        }

        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.GetInstancia().CrearConexion();
                query = @"SELECT 
                            c.Id_Cliente AS ID_Cliente,
                            CASE 
                                WHEN s.Id_Cliente IS NOT NULL THEN 'Socio' 
                                ELSE 'No Socio' 
                            END AS Tipo_Cliente,
                            c.Nombre AS Nombre_Cliente,
                            c.DNI AS DNI,
                            c.Direccion AS Direccion,
                            c.Fecha_Nacimiento AS Fecha_Nacimiento,
                            c.Fecha_Alta AS Fecha_Alta,
                            CASE 
                                WHEN c.Ficha_Medica = 1 THEN 'Si' 
                                ELSE 'No' 
                            END AS Tiene_Ficha_Medica,
                            COALESCE(cs.Id_Cuota, cns.Id_Cuota, 0) AS ID_Cuota,
                            COALESCE(cs.Descripcion, cns.Descripcion, 'Sin actividad registrada') AS Descripcion_Cuota
                        FROM 
                            clientes c 
                        LEFT JOIN 
                            socios s ON c.Id_Cliente = s.Id_Cliente 
                        LEFT JOIN 
                            no_socios ns ON c.Id_Cliente = ns.Id_Cliente 
                        LEFT JOIN
                            cuotas cs ON s.Id_Socio = cs.Id_Socio
                        LEFT JOIN
                            cuotas cns ON ns.Id_NoSocio = cns.Id_NoSocio
                        ORDER BY 
                             c.Id_Cliente DESC;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    dtgvClientes.Rows.Clear(); // Clear existing rows
                    while (reader.Read())
                    {
                        int renglon = dtgvClientes.Rows.Add();
                        dtgvClientes.Rows[renglon].Cells["ID_Cliente"].Value = reader.GetInt32(0); // idCliente
                        dtgvClientes.Rows[renglon].Cells["Tipo_Cliente"].Value = reader.GetString(1); // Tipo de cliente
                        dtgvClientes.Rows[renglon].Cells["Nombre_Cliente"].Value = reader.GetString(2); // nombre y apellido
                        dtgvClientes.Rows[renglon].Cells["DNI"].Value = reader.GetInt32(3); // dni 
                        dtgvClientes.Rows[renglon].Cells["Direccion"].Value = reader.GetString(4); // direccion
                        dtgvClientes.Rows[renglon].Cells["Fecha_Nacimiento"].Value = reader.GetDateTime(5).ToString("dd-MM-yyyy"); // fecha nacimiento
                        dtgvClientes.Rows[renglon].Cells["Fecha_Alta"].Value = reader.GetDateTime(6).ToString("dd-MM-yyyy"); // fecha alta
                        dtgvClientes.Rows[renglon].Cells["Tiene_Ficha_Medica"].Value = reader.GetString(7); // ficha medica
                        dtgvClientes.Rows[renglon].Cells["ID_Cuota"].Value = reader.GetInt32(8); // id cuota (como entero)
                        dtgvClientes.Rows[renglon].Cells["Descripcion_Cuota"].Value = reader.GetString(9); // descripcion cuota
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

        private void ClientesView_Load(object sender, EventArgs e)
        {

            // DataGridView se redimensionará automáticamente cuando el contenedor cambie de tamaño,
            // manteniendo su posición relativa y tamaño en proporción al contenedor.
            dtgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            
            dtgvClientes.Columns.Clear();

            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID_Cliente", HeaderText = "ID Cliente" });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tipo_Cliente", HeaderText = "Tipo Cliente" });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre_Cliente", HeaderText = "Nombre y Apellido" });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "DNI", HeaderText = "DNI", Visible = false });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Direccion", HeaderText = "Direccion", Visible = false });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha_Nacimiento", HeaderText = "Fecha Nacimiento", Visible = false });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha_Alta", HeaderText = "Fecha Alta", Visible = false });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tiene_Ficha_Medica", HeaderText = "Ficha Médica", Visible = false });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID_Cuota", HeaderText = "ID Cuota" });
            dtgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion_Cuota", HeaderText = "Descripción Cuota" });

            // Crear un menú contextual para seleccionar
            // Crear un menú contextual para seleccionar columnas
            ContextMenuStrip columnContextMenu = new ContextMenuStrip();
            ToolStripMenuItem columnMenuItem;

            // Iterar sobre las columnas del DataGridView para agregarlas al menú contextual
            foreach (DataGridViewColumn column in dtgvClientes.Columns)
            {
                columnMenuItem = new ToolStripMenuItem(column.HeaderText);
                columnMenuItem.Checked = column.Visible;
                columnMenuItem.CheckOnClick = true;
                columnMenuItem.Tag = column;
                columnMenuItem.CheckedChanged += ColumnMenuItem_CheckedChanged;
                columnContextMenu.Items.Add(columnMenuItem);
            }

            // Asignar el menú contextual al DataGridView
            dtgvClientes.ContextMenuStrip = columnContextMenu;

            CargarGrilla();
        }

        private void ColumnMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            DataGridViewColumn column = (DataGridViewColumn)item.Tag;
            column.Visible = item.Checked;
        }

        private void FiltrarDatos(string filtro)
        {
            // Utiliza un DataView para filtrar los datos según el criterio proporcionado
            DataView dv = new DataView(dtgvClientes.DataSource as DataTable);
            dv.RowFilter = filtro;
            dtgvClientes.DataSource = dv;
        }
    }
}
