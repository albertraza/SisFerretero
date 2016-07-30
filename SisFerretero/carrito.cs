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

        //metodo para agregar un producto al carrito
        public static string añadirCarrito(int codigoProducto, int codigoFactura, int cantidadVendida, double itebis, double total)
        {
            string r = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "añadirCarrito";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@codigoProducto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoProducto"].Value = codigoProducto;

                comand.Parameters.Add(new SqlParameter("@codigoFactura", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoFactura"].Value = codigoFactura;

                comand.Parameters.Add(new SqlParameter("@cantidadVendida", System.Data.SqlDbType.Int));
                comand.Parameters["@cantidadVendida"].Value = cantidadVendida;

                comand.Parameters.Add(new SqlParameter("@ITEBIS", System.Data.SqlDbType.Money));
                comand.Parameters["@ITEBIS"].Value = itebis;

                comand.Parameters.Add(new SqlParameter("@total", System.Data.SqlDbType.Money));
                comand.Parameters["@total"].Value = total;

                if (comand.ExecuteNonQuery() > 0)
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

        // metodo para mostrar el carrito en una tabla cualquiera
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
                    pCarrito.Precio_Und = double.Parse(reader["precioUnd"].ToString());
                    pCarrito.ITEBIS = double.Parse(reader["ITEBIS"].ToString());
                    pCarrito.Total = double.Parse(reader["Total"].ToString());

                    list.Add(pCarrito);
                }
                con.Close();
            }
            return list;
        }

        // metodo para borrar el carrito
        public static string deleteCarrito(int codigoFactura)
        {
            string mensaje = null;
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("delete ProductosVendidos where codigoFactura = '{0}'", codigoFactura), con);
                if (comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Listo!";
                }
                else
                {
                    mensaje = "No se pudo borrar la factura correctamente";
                }
                con.Close();
            }
            return mensaje;
        }
    }
}
