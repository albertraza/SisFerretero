using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class departamento
    {
        public int NoDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }

        public departamento() { }
        public departamento(int c, string nom, string deta)
        {
            NoDepartamento = c;
            Nombre = nom;
            Detalles = deta;
        }

        // metodo para obtener la info del departamento por nombre
        public static departamento getDepartamentoByName(string Nombre)
        {
            departamento pDepartamento = new departamento();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getDepartamentoByName";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = Nombre;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pDepartamento.NoDepartamento = Convert.ToInt32(re["NoDepartamento"]);
                        pDepartamento.Nombre = re["Nombre"].ToString();
                        pDepartamento.Detalles = re["Detalles"].ToString();
                    }
                }
                else
                {
                    pDepartamento = null;
                }
                con.Close();
            }
            return pDepartamento;
        }
    }
}
