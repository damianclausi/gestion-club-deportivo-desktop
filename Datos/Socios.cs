using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Interfaces;


namespace ClubDeportivo.Datos
{
    class Socios : IInscribir<E_Socio>
    {
        public  string Inscribir(E_Socio clienteSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                //llamamos el STORE PRECEDURE
                MySqlCommand comando = new MySqlCommand("CrearNuevoClienteSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //UTILIZAMOS LOS NOMBRES DE VARIABLE EN STORE PROCEDURE
                comando.Parameters.Add("p_Nombre", MySqlDbType.VarChar).Value = clienteSocio.NombreSocio;
                comando.Parameters.Add("p_DNI", MySqlDbType.Int32).Value = clienteSocio.DniSocio;
                comando.Parameters.Add("p_Direccion", MySqlDbType.VarChar).Value = clienteSocio.DireccionSocio;
                comando.Parameters.Add("p_FechaNacimiento", MySqlDbType.Date).Value = clienteSocio.FechaNacimientoSocio;
                comando.Parameters.Add("p_FechaAlta", MySqlDbType.Date).Value = clienteSocio.FechaAltaSocio;
                comando.Parameters.Add("p_FichaMedica", MySqlDbType.Bit).Value = clienteSocio.FichaMedicaSocio;



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
