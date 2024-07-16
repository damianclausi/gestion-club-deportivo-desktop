using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// --------------------
// Referencia a MySQL (se agrega como libreria)
using MySql.Data.MySqlClient;
using ClubDeportivo.Datos;

namespace ClubDeportivo.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
            this.baseDatos = "ComDEq9PI";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }        
            catch (Exception ex)
            {
                cadena = null;
                throw ;
            }
            return cadena;
            }
        // para evaluar la instancia de la conectividad
        public static Conexion GetInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }

}
