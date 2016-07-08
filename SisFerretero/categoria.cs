using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class categoria
    {
        public int codigo { get; set; }
        public string Categoria { get; set; }

        public categoria() { }
        public categoria(int c, string ca)
        {
            codigo = c;
            Categoria = ca;
        }

        // metodo que obtiene la categoria
        public static categoria getCategoria(string categoria)
        {
            categoria pCateforia = new categoria();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from categorias where categoria = '{0}'", categoria), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                { 
                    while (reader.Read())
                    {
                        pCateforia.codigo = Convert.ToInt32(reader["codigo"]);
                        pCateforia.Categoria = reader["categoria"].ToString();
                    }
                }
                else
                {
                    pCateforia = null;
                }
                con.Close();
            }
            return pCateforia;
        }
    }
}
