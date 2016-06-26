using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class facturacion
    {
        public int codigo { get; set; }
        public decimal ITEBIS { get; set; }
        public decimal TotalComprado { get; set; }
        public int Total_Articulos { get; set; }

        // metodo para registrar una nueva factura
        public static string registerFactura(int codigoCliente, DateTime fechaRegistro, DateTime fechaEntrega, int totalArticulos, decimal totalComprado, decimal ITEBIS, decimal totalPagar)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("execute registerFactura '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'", codigoCliente, fechaRegistro, fechaEntrega, totalArticulos, totalComprado, ITEBIS, totalPagar), con);
                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Factura registrada!";
                }
                else
                {
                    mensaje = "No se pudo registrar la factura";
                }
                con.Close();
            }
            return mensaje;
        }
        // metodo para obtener el ID de la nueva Factura
        public static int getNewFacturaID()
        {
            int r = -1;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select codigo from Factura where codigoCliente = 0", con);
                r = Convert.ToInt32(comand.ExecuteScalar());
                con.Close();
            }
            return r;
        }
        // metodo para borrar las facturas junto con el carrito de compras
        public static string deleteFactura(int codigoFactura)
        {
            string r = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("delete Factura where codigo = '{0}'", codigoFactura), con);
                comand.ExecuteNonQuery();
                SqlCommand comand1 = new SqlCommand(string.Format("delete ProductosVendidos where codigoFactura = '{0}'", codigoFactura), con);
                comand.ExecuteNonQuery();
                if (comand1.ExecuteNonQuery() > 0 && comand.ExecuteNonQuery() > 0)
                {
                    r = "Factura Cancelada";
                }
                else
                {
                    r = "No se pudo cancelar la factura";
                }
                con.Close();
            }
            return r;
        }
    }
}
