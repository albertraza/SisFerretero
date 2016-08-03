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
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getCategoria";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Categoria", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Categoria"].Value = categoria;

                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                { 
                    while (reader.Read())
                    {
                        pCateforia.codigo = Convert.ToInt32(reader["NoCategoria"]);
                        pCateforia.Categoria = reader["Nombre"].ToString();
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
        public static categoria getCategoriaCodigo(int NoCategoria)
        {
            categoria pCateforia = new categoria();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getCategoriaByNumber";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoCategoria", System.Data.SqlDbType.Int));
                comand.Parameters["@NoCategoria"].Value = NoCategoria;

                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pCateforia.codigo = Convert.ToInt32(reader["NoCategoria"]);
                        pCateforia.Categoria = reader["Nombre"].ToString();
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
