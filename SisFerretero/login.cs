using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class login
    {
        public static bool getUservalidation(string nombreUsuario, string contrasena)
        {
            bool validate = false;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Usuarios where contrasena = '{0}' and Nombre = '{1}'", contrasena, nombreUsuario), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    validate = true;
                }
                else
                {
                    validate = false;
                }
                con.Close();
            }
            return validate;
        }
    }
}
