using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Interfaces;
using System.Net.Http.Json;

namespace ClubDeportivo.Datos
{
    class NoSocios : IInscribir<E_NoSocio>
    {
        public string Inscribir(E_NoSocio clienteNoSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                //llamamos el STORE PRECEDURE
                MySqlCommand comando = new MySqlCommand("CrearNuevoClienteNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //UTILIZAMOS LOS NOMBRES DE VARIABLE EN STORE PROCEDURE
                comando.Parameters.Add("p_Nombre", MySqlDbType.VarChar).Value = clienteNoSocio.NombreNoSocio;
                comando.Parameters.Add("p_DNI", MySqlDbType.Int32).Value = clienteNoSocio.DniNoSocio;
                comando.Parameters.Add("p_Direccion", MySqlDbType.VarChar).Value = clienteNoSocio.DireccionNoSocio;
                comando.Parameters.Add("p_FechaNacimiento", MySqlDbType.Date).Value = clienteNoSocio.FechaNacimientoNoSocio;
                comando.Parameters.Add("p_FechaAlta", MySqlDbType.Date).Value = clienteNoSocio.FechaAltaNoSocio;
                comando.Parameters.Add("p_FichaMedica", MySqlDbType.Bit).Value = clienteNoSocio.FichaMedicaNoSocio; 


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
