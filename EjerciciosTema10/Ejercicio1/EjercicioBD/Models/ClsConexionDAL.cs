using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBD.Models
{
    public class ClsConexionDAL
    {

        /// <summary>
        /// Metodo que conecta el programa con una BD en Azure y muestra su estado
        /// </summary>
        /// <returns>Estado de la BD</returns>
        public static String AbrirConexion()
        {
            SqlConnection miConexion = new SqlConnection();
            String estadoConexion;
            try
            {
                miConexion.ConnectionString = "Server=tcp:nestorss.database.windows.net,1433;Initial Catalog=EusebioNS;Persist Security Info=False;User ID=usuario;Password=Lacampana123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                miConexion.Open();
                estadoConexion = miConexion.State.ToString();
            }
            catch (Exception ex)
            {
                estadoConexion = "Error: " + ex.Message;
            }
            finally
            {
                if (miConexion.State == System.Data.ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }
            return estadoConexion;
        }

    }
}
