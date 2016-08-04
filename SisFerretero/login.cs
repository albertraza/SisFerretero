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
        public static bool getUservalidation(string UserName, string Password)
        {
            bool validate = false;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getUserValidation";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.VarChar));
                comand.Parameters["@UserName"].Value = UserName;

                comand.Parameters.Add(new SqlParameter("@Password", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Password"].Value = Password;

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
