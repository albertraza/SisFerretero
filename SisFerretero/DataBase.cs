using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SisFerretero.Properties;

namespace SisFerretero
{
    public class DataBase
    {
        // metodo para poder obtener y devolver la conexion de la base de datos.
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(Settings.Default.FerreteriaDBConnectionString);
            con.Open();
            return con;
        }
    }
}
