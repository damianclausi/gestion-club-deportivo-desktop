using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Cuotas
    {
         

        public string PagarCuota(E_Cuota cuota)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                //llamamos el STORE PRECEDURE
                MySqlCommand comando = new MySqlCommand("CrearNuevaCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //UTILIZAMOS LOS NOMBRES DE VARIABLE EN STORE PROCEDURE
                comando.Parameters.Add("p_Descripcion", MySqlDbType.VarChar).Value = cuota.Descripcion;
                comando.Parameters.Add("p_Monto", MySqlDbType.Float).Value = cuota.Monto;
                comando.Parameters.Add("p_Fecha_Pago", MySqlDbType.Date).Value = cuota.FechaPago;
                comando.Parameters.Add("p_Fecha_vencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                comando.Parameters.Add("p_Id_Cliente", MySqlDbType.Int32).Value = cuota.id;

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
