using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class Conexion
    {
        public string ObtenerConexion()
        {
            string conexion = ConfigurationManager.ConnectionStrings["CSSQL"].ToString();
            
            return conexion;
        }
    }
    
}
