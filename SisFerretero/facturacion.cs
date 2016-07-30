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
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int TotalProductos { get; set; }
        public double TotalCompradoSinITEBIS { get; set; }
        public double ITEBIS { get; set; }
        public double TotalPagar { get; set; }
        public string despachado { get; set; }

        // metodo para registrar una nueva factura
        public static string registerFactura(int codigoCliente, DateTime fechaRegistro, DateTime fechaEntrega, int totalArticulos, double totalComprado, double ITEBIS, double totalPagar, int despachado)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "registerFactura";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@codigoCliente", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoCliente"].Value = codigoCliente;

                comand.Parameters.Add(new SqlParameter("@fechaRegistro", System.Data.SqlDbType.DateTime));
                comand.Parameters["@fechaRegistro"].Value = fechaRegistro;

                comand.Parameters.Add(new SqlParameter("@fechaEntrega", System.Data.SqlDbType.DateTime));
                comand.Parameters["@fechaEntrega"].Value = fechaEntrega;

                comand.Parameters.Add(new SqlParameter("@totalArticulos", System.Data.SqlDbType.Int));
                comand.Parameters["@totalArticulos"].Value = totalArticulos;

                comand.Parameters.Add(new SqlParameter("@totalComprado", System.Data.SqlDbType.Money));
                comand.Parameters["@totalComprado"].Value = totalComprado;

                comand.Parameters.Add(new SqlParameter("@ITEBIS", System.Data.SqlDbType.Money));
                comand.Parameters["@ITEBIS"].Value = ITEBIS;

                comand.Parameters.Add(new SqlParameter("@totalPagar", System.Data.SqlDbType.Money));
                comand.Parameters["@totalPagar"].Value = totalPagar;

                comand.Parameters.Add(new SqlParameter("@despachado", System.Data.SqlDbType.Int));
                comand.Parameters["@despachado"].Value = despachado;

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

        // metodo para actualizar la factura para poder ser despachada
        public static string updateFactura(int codigoCliente, DateTime fechaEntrega, int totalArticulos, double totalComprado, double ITEBIS, double totalPagar, int despachado, int codigoFactura)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "updateFactura";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Cliente", System.Data.SqlDbType.Int));
                comand.Parameters["@Cliente"].Value = codigoCliente;

                comand.Parameters.Add(new SqlParameter("@fechaEntrega", System.Data.SqlDbType.DateTime));
                comand.Parameters["@fechaEntrega"].Value = fechaEntrega;

                comand.Parameters.Add(new SqlParameter("@totalArticulos", System.Data.SqlDbType.Int));
                comand.Parameters["@totalArticulos"].Value = totalArticulos;

                comand.Parameters.Add(new SqlParameter("@totalComprado", System.Data.SqlDbType.Money));
                comand.Parameters["@totalComprado"].Value = totalComprado;

                comand.Parameters.Add(new SqlParameter("@itebis", System.Data.SqlDbType.Money));
                comand.Parameters["@itebis"].Value = ITEBIS;

                comand.Parameters.Add(new SqlParameter("@totalPagar", System.Data.SqlDbType.Money));
                comand.Parameters["@totalPagar"].Value = totalPagar;

                comand.Parameters.Add(new SqlParameter("@despachado", System.Data.SqlDbType.Int));
                comand.Parameters["@despachado"].Value = despachado;

                comand.Parameters.Add(new SqlParameter("@codigoFactura", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoFactura"].Value = codigoFactura;

                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Factura creada!";
                }
                else
                {
                    mensaje = "La factura no se pudo registrar correctamente, Intente nuevamente";
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

        //metodo para cargar todas las facturas
        public static List<facturacion> listAllFacturas()
        {
            List<facturacion> list = new List<facturacion>();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand("select * from Factura inner join Clientes on Clientes.codigo = Factura.codigoCliente", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();
                    pFactura.codigo = Convert.ToInt32(re["codigo"]);
                    pFactura.Nombre_Cliente = re["nombre"].ToString();
                    pFactura.Apellido_Cliente = re["apellido"].ToString();
                    pFactura.fechaRegistro = DateTime.Parse(Convert.ToDateTime(re["fechaRegistro"]).ToString("MM/dd/yyyy"));
                    pFactura.fechaEntrega = DateTime.Parse(Convert.ToDateTime(re["fechaEntrega"]).ToString("MM/dd/yyyy"));
                    pFactura.TotalProductos = Convert.ToInt32(re["totalArticulos"]);
                    pFactura.TotalCompradoSinITEBIS = Convert.ToDouble(re["totalComprado"]);
                    pFactura.ITEBIS = Convert.ToDouble(re["ITEBIS"]);
                    pFactura.TotalPagar = Convert.ToDouble(re["totalPagar"]);
                    if (Convert.ToInt32(re["despachado"]) > 0)
                    {
                        pFactura.despachado = "Si";
                    }
                    else if(Convert.ToInt32(re["despachado"]) == 0)
                    {
                        pFactura.despachado = "No";
                    }
                    else
                    {
                        pFactura.despachado = "--";
                    }

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }

        // metodo para buscar las facturas
        public static List<facturacion> searchFacturas(string codigo, string cedula, string nombreCliente, string fecha)
        {
            List<facturacion> list = new List<facturacion>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Factura inner join Clientes on Clientes.codigo = Factura.codigoCliente where Factura.codigo Like '{0}%' and Clientes.cedula like '{1}%' and Clientes.nombre like '{2}%' and Factura.fechaRegistro like '{3}%'",
                    codigo, cedula, nombreCliente, fecha), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();
                    pFactura.codigo = Convert.ToInt32(re["codigo"]);
                    pFactura.Nombre_Cliente = re["nombre"].ToString();
                    pFactura.Apellido_Cliente = re["apellido"].ToString();
                    pFactura.fechaRegistro = DateTime.Parse(Convert.ToDateTime(re["fechaRegistro"]).ToString("MM/dd/yyyy"));
                    pFactura.fechaEntrega = DateTime.Parse(Convert.ToDateTime(re["fechaEntrega"]).ToString("MM/dd/yyyy"));
                    pFactura.TotalProductos = Convert.ToInt32(re["totalArticulos"]);
                    pFactura.TotalCompradoSinITEBIS = Convert.ToDouble(re["totalComprado"]);
                    pFactura.ITEBIS = Convert.ToDouble(re["ITEBIS"]);
                    pFactura.TotalPagar = Convert.ToDouble(re["totalPagar"]);
                    if (Convert.ToInt32(re["despachado"]) > 0)
                    {
                        pFactura.despachado = "Si";
                    }
                    else if (Convert.ToInt32(re["despachado"]) == 0)
                    {
                        pFactura.despachado = "No";
                    }
                    else
                    {
                        pFactura.despachado = "--";
                    }

                    list.Add(pFactura);
                }
                con.Close();
            }
            return list;
        }
    }
    public class baseFacturacion
    {
        public int codigo { get; set; }
        public int codigoCliente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int cantProductos { get; set; }
        public double TotalCompradoSinITEBIS { get; set; }
        public double ITEBIS { get; set; }
        public double TotalPagar { get; set; }
        public int despachado { get; set; }

        public baseFacturacion() { }
        public baseFacturacion(int c, int cCl, DateTime fR, DateTime fE, int cP, double TPSI, double Itebis, double tP, int D)
        {
            codigo = c;
            codigoCliente = cCl;
            fechaRegistro = fR;
            fechaEntrega = fE;
            cantProductos = cP;
            TotalCompradoSinITEBIS = TPSI;
            ITEBIS = Itebis;
            TotalPagar = tP;
            despachado = D;
        }

        // metodo para obtener la informacion de la factura
        public static baseFacturacion getFactura(int codigo)
        {
            baseFacturacion pFactura = new baseFacturacion();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Factura where codigo = '{0}'", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pFactura.codigo = Convert.ToInt32(re["codigo"]);
                        pFactura.codigoCliente = Convert.ToInt32(re["codigoCliente"]);
                        pFactura.fechaRegistro = DateTime.Parse(Convert.ToDateTime(re["fechaRegistro"]).ToString("MM/dd/yyyy"));
                        pFactura.fechaEntrega = DateTime.Parse(Convert.ToDateTime(re["fechaEntrega"]).ToString("MM/dd/yyyy"));
                        pFactura.cantProductos = Convert.ToInt32(re["totalArticulos"]);
                        pFactura.TotalCompradoSinITEBIS = Convert.ToDouble(re["totalComprado"]);
                        pFactura.ITEBIS = Convert.ToDouble(re["ITEBIS"]);
                        pFactura.TotalPagar = Convert.ToDouble(re["totalPagar"]);
                        pFactura.despachado = Convert.ToInt32(re["despachado"]);
                    }
                }
                else
                {
                    pFactura = null;
                }
                con.Close();
            }
            return pFactura;
        }
    }
}
