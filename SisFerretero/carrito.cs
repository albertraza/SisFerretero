using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class carrito
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio_Und { get; set; }
        public double ITEBIS { get; set; }
        public double Total { get; set; }

        public carrito() { }
        public carrito(int c, string nombre, int cantidad, double precio, double itebis, double total)
        {
            Codigo = c;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio_Und = precio;
            ITEBIS = itebis;
            Total = total;
        }

        public static string añadirCarrito(int codigoProducto, int codigoFactura, int cantidadVendida, decimal itebis, decimal total)
        {
            string r = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("execute añadirCarrito '{0}', '{1}', '{2}', {3}, '{4}'", codigoProducto, codigoFactura, cantidadVendida, itebis, total), con);
                if(comand.ExecuteNonQuery() > 0)
                {
                    r = "Producto añadido al carrito!";
                }
                else
                {
                    r = "No se pudo añadir al carrito";
                }
                con.Close();
            }
            return r;
        }
        public static List<carrito> getCarrito(int codigoFactura)
        {
            List<carrito> list = new List<carrito>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select codigoProducto, nombre, cantidadVendida, precioUnd, ITEBIS, Total from ProductosVendidos inner join Productos on Productos.codigo = ProductosVendidos.codigoProducto where codigoFactura = '{0}'", codigoFactura), con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    carrito pCarrito = new carrito();

                    pCarrito.Codigo = Convert.ToInt32(reader["codigoProducto"]);
                    pCarrito.Nombre = reader["nombre"].ToString();
                    pCarrito.Cantidad = Convert.ToInt32(reader["cantidadVendida"]);
                    pCarrito.Precio_Und = Convert.ToDouble(double.Parse(reader["precioUnd"].ToString()).ToString("f2"));
                    pCarrito.ITEBIS = Convert.ToDouble(double.Parse(reader["ITEBIS"].ToString()).ToString("f2"));
                    pCarrito.Total = Convert.ToDouble(double.Parse(reader["Total"].ToString()).ToString("f2"));

                    list.Add(pCarrito);
                }
                con.Close();
            }
            return list;
        }
    }
}
