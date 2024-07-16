using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Actividades
    {
        public  string IncrementarCapacidadOcupada(E_Actividad actividad)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                //llamamos el STORE PRECEDURE
                MySqlCommand comando = new MySqlCommand("IncrementarCapacidadOcupada", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //UTILIZAMOS LOS NOMBRES DE VARIABLE EN STORE PROCEDURE
                comando.Parameters.Add("p_NombreActividad", MySqlDbType.VarChar).Value = actividad.nombre;


                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "p_Resultado";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}
