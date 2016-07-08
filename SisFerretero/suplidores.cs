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
                SqlCommand comand = new SqlCommand("select * from Suplidores where nombre != 'Todos'", con);
                SqlDataReader rea = comand.ExecuteReader();
                while(rea.Read())
                {
                    suplidores pSuplidores = new suplidores();
                    pSuplidores.Codigo = Convert.ToInt32(rea["codigo"]);
                    pSuplidores.Nombre_Suplidor = rea["nombre"].ToString();
                    pSuplidores.Telefono = rea["telefono"].ToString();
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
        public static baseSuplidores getSuplidores(int codigo)
        {
            baseSuplidores pSuplidor = new baseSuplidores();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Suplidores where codigo = '{0}'", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pSuplidor.codigo = Convert.ToInt32(re["codigo"]);
                        pSuplidor.nombre = re["nombre"].ToString();
                        pSuplidor.descripcion = re["descripcion"].ToString();
                        pSuplidor.Telefono = re["telefono"].ToString();
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
