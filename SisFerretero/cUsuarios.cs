using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class cUsuarios
    {
        public string Nombre_Usuario { get; set; }
        public string Departamento { get; set; }

        public cUsuarios() { }
        public cUsuarios(string d, string n)
        {
            Departamento = d;
            Nombre_Usuario = n;
        }

        // metodo para buscar los usuarios
        public static List<cUsuarios> searchUsuarios(string NoUsuario, string UserName)
        {
            List<cUsuarios> list = new List<cUsuarios>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "searchUsuario";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoUser", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NoUser"].Value = NoUsuario;

                comand.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.VarChar));
                comand.Parameters["@UserName"].Value = UserName;

                SqlDataReader re = comand.ExecuteReader();

                while (re.Read())
                {
                    cUsuarios pUsuarios = new cUsuarios();
                    pUsuarios.Nombre_Usuario = re["UserName"].ToString();
                    pUsuarios.Departamento = re["Departamento"].ToString();

                    list.Add(pUsuarios);
                }
                con.Close();
            }
            return list;
        }
    }
}
