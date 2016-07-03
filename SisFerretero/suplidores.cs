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
                SqlCommand comand = new SqlCommand("select * from Suplidores", con);
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
}
