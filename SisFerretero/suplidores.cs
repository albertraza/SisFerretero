using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class suplidores
    {
        public int Codigo { get; set; }
        public string Nombre_Suplidor { get; set; }
        public string Telefono { get; set; }

        public suplidores() { }
        public suplidores(int c, string ns, string t)
        {
            Codigo = c;
            Nombre_Suplidor = ns;
            Telefono = t;
        }

        // metodo para hacer una lista de los suplidores solo con el codigo, nombe y telefono //
        public static List<suplidores> ListSuplidoresCodigoNombre()
        {
            List<suplidores> list = new List<suplidores>();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "ListSuplidoresCodigoNombre";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rea = comand.ExecuteReader();
                while(rea.Read())
                {
                    suplidores pSuplidores = new suplidores();
                    pSuplidores.Codigo = Convert.ToInt32(rea["NoSuplidor"]);
                    pSuplidores.Nombre_Suplidor = rea["NombreSuplidor"].ToString();
                    pSuplidores.Telefono = rea["Telefono"].ToString();
                    list.Add(pSuplidores);
                }
                con.Close();
            }
            return list;
        }
    }
    public class baseSuplidores
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string Telefono { get; set; }
        public string direccion { get; set; }

        public baseSuplidores() { }
        public baseSuplidores(int c, string n, string des, string tel, string dir)
        {
            codigo = c;
            nombre = n;
            descripcion = des;
            Telefono = tel;
            direccion = dir;
        }

        // metodo para obtener la info del suplidor
        public static baseSuplidores getSuplidores(int NoSuplidor)
        {
            baseSuplidores pSuplidor = new baseSuplidores();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getSuplidoresByNumber";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoSuplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@NoSuplidor"].Value = NoSuplidor;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pSuplidor.codigo = Convert.ToInt32(re["NoSuplidor"]);
                        pSuplidor.nombre = re["NombreSuplidor"].ToString();
                        pSuplidor.descripcion = re["descripcion"].ToString();
                        pSuplidor.Telefono = re["Telefono"].ToString();
                        pSuplidor.direccion = re["direccion"].ToString();
                    }
                }
                else
                {
                    pSuplidor = null;
                }
                con.Close();
            }
            return pSuplidor;
        }

        // metodo para obtener el la info del suplidor solo con el nombre
        public static baseSuplidores getSuplidorNombreSupl(string nombre)
        {
            baseSuplidores pSuplidor = new baseSuplidores();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getSuplidorNombreSupl";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = nombre;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pSuplidor.codigo = Convert.ToInt32(re["NoSuplidor"]);
                        pSuplidor.nombre = re["NombreSuplidor"].ToString();
                        pSuplidor.descripcion = re["descripcion"].ToString();
                        pSuplidor.Telefono = re["Telefono"].ToString();
                        pSuplidor.direccion = re["direccion"].ToString();
                    }
                }
                else
                {
                    pSuplidor = null;
                }
                con.Close();
            }
            return pSuplidor;
        }
    }
}
