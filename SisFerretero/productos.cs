using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class productos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public double precioUnd { get; set; }
        public int cantExistente { get; set; }
        public string Nombre_Suplidor { get; set; }

        public productos() { }
        public productos(int c, string n, string d, double pu, int ce, string ns)
        {
            codigo = c;
            nombre = n;
            detalles = d;
            precioUnd = pu;
            cantExistente = ce;
            Nombre_Suplidor = ns;
        }

        public static baseProductos getProducto(int codigoProducto)
        {
            baseProductos pProducto = new baseProductos();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Productos where codigo = '{0}'", codigoProducto), con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    pProducto.codigo = Convert.ToInt32(reader["codigo"]);
                    pProducto.nombre = reader["nombre"].ToString();
                    pProducto.detalles = reader["descripcion"].ToString();
                    pProducto.precioUnd = Convert.ToDouble(double.Parse(reader["precioUnd"].ToString()).ToString("f2"));
                    pProducto.cantExistente = Convert.ToInt32(reader["cantExistente"]);
                    pProducto.codigoSuplidor = Convert.ToInt32(reader["codigoSuplidor"]);
                    pProducto.Imp = Convert.ToInt32(reader["impuesto"]);
                }
                con.Close();
            }
            return pProducto;
        }
    }
    public class baseProductos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public double precioUnd { get; set; }
        public int cantExistente { get; set; }
        public int codigoSuplidor { get; set; }
        public int Imp { get; set; }

        public baseProductos() { }
        public baseProductos(int c, string n, string d, double pu, int ce, int cs, int im)
        {
            codigo = c;
            nombre = n;
            detalles = d;
            precioUnd = pu;
            cantExistente = ce;
            codigoSuplidor = cs;
            Imp = im;
        }
    }
}
