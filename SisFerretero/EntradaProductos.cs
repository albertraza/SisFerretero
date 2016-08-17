using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class EntradaProductos
    {
        public int codigo { get; set; }
        public int codigoProducto { get; set; }
        public int CantidadComprada { get; set; }
        public int codigoSuplidor { get; set; }
        public DateTime fechaEntrada { get; set; }

        public EntradaProductos() { }
        public EntradaProductos(int c, int cp, int cc, int cs, DateTime fe)
        {
            codigo = c;
            codigoProducto = cp;
            CantidadComprada = cc;
            codigoSuplidor = cs;
            fechaEntrada = fe;
        }


        // metodo para registrar la entrada de productos
        public static string registerEntrada(EntradaProductos pEntrada)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "registerEntradaProducto";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@codigoProducto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoProducto"].Value = pEntrada.codigoProducto;

                comand.Parameters.Add(new SqlParameter("@cantidadAnadida", System.Data.SqlDbType.Int));
                comand.Parameters["@cantidadAnadida"].Value = pEntrada.CantidadComprada;

                comand.Parameters.Add(new SqlParameter("@codigoSuplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoSuplidor"].Value = pEntrada.codigoSuplidor;

                comand.Parameters.Add(new SqlParameter("@fechaEntrada", System.Data.SqlDbType.Date));
                comand.Parameters["@fechaEntrada"].Value = pEntrada.fechaEntrada;

                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Registrado Exitosamente";
                }
                else
                {
                    mensaje = "No se pudo Registrar";
                }
                con.Close();
            }
            return mensaje;
        }
    }
}
