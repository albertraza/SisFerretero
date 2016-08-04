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
        public static string registerFactura(int Cliente, DateTime fechaRegistro, DateTime fechaEntrega, int totalArticulos, double totalComprado, double ITEBIS, double totalPagar, int despachado)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "registerFactura";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@codigoCliente", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoCliente"].Value = Cliente;

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
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;

                // este SP no contiene parametros a llenar
                comand.CommandText = "getNewFacturaID";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

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
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "deleteFactura";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoFactura", System.Data.SqlDbType.Int));
                comand.Parameters["@NoFactura"].Value = codigoFactura;

                SqlCommand comand1 = new SqlCommand();
                comand1.Connection = con;
                comand1.CommandText = "deleteProductosVendidos";
                comand1.CommandType = System.Data.CommandType.StoredProcedure;

                comand1.Parameters.Add(new SqlParameter("@NoFactura", System.Data.SqlDbType.Int));
                comand1.Parameters["@NoFactura"].Value = codigoFactura;

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
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listAllFactura";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();
                    pFactura.codigo = Convert.ToInt32(re["NoFactura"]);
                    pFactura.Nombre_Cliente = re["NombreCliente"].ToString();
                    pFactura.Apellido_Cliente = re["ApellidoCliente"].ToString();
                    pFactura.fechaRegistro = DateTime.Parse(Convert.ToDateTime(re["fechaRegistro"]).ToString("MM/dd/yyyy"));
                    pFactura.fechaEntrega = DateTime.Parse(Convert.ToDateTime(re["fechaEntrega"]).ToString("MM/dd/yyyy"));
                    pFactura.TotalProductos = Convert.ToInt32(re["Total_articulos"]);
                    pFactura.TotalCompradoSinITEBIS = Convert.ToDouble(re["Total_Sin_Impuestos"]);
                    pFactura.ITEBIS = Convert.ToDouble(re["ITEBIS"]);
                    pFactura.TotalPagar = Convert.ToDouble(re["Total_a_Pagar"]);
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
        public static List<facturacion> searchFacturas(string NoFactura, string cedula, string nombreCliente, string fecha)
        {
            List<facturacion> list = new List<facturacion>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "searchFacturas";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoFactura", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NoFactura"].Value = NoFactura;

                comand.Parameters.Add(new SqlParameter("@cedula", System.Data.SqlDbType.VarChar));
                comand.Parameters["@cedula"].Value = cedula;

                comand.Parameters.Add(new SqlParameter("@NombreCliente", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NombreCliente"].Value = nombreCliente;

                comand.Parameters.Add(new SqlParameter("@fecha", System.Data.SqlDbType.DateTime));
                comand.Parameters["@fecha"].Value = fecha;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    facturacion pFactura = new facturacion();
                    pFactura.codigo = Convert.ToInt32(re["NoFactura"]);
                    pFactura.Nombre_Cliente = re["NombreCliente"].ToString();
                    pFactura.Apellido_Cliente = re["ApellidoCliente"].ToString();
                    pFactura.fechaRegistro = DateTime.Parse(Convert.ToDateTime(re["fechaRegistro"]).ToString("MM/dd/yyyy"));
                    pFactura.fechaEntrega = DateTime.Parse(Convert.ToDateTime(re["fechaEntrega"]).ToString("MM/dd/yyyy"));
                    pFactura.TotalProductos = Convert.ToInt32(re["Total_articulos"]);
                    pFactura.TotalCompradoSinITEBIS = Convert.ToDouble(re["Total_Sin_Impuestos"]);
                    pFactura.ITEBIS = Convert.ToDouble(re["ITEBIS"]);
                    pFactura.TotalPagar = Convert.ToDouble(re["Total_a_Pagar"]);
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

        // metodo para listar todas las ordenes no completadas
        public static List<facturaPendiente> listAllFacturasNoDespachadas()
        {
            List<facturaPendiente> list = new List<facturaPendiente>();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listAllFacturasNoDespachadas";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    facturaPendiente pFactura = new facturaPendiente();
                    pFactura.Codigo_Factura = Convert.ToInt32(reader["NoFactura"]);
                    pFactura.Nombre_Cliente = reader["NombreCliente"].ToString();
                    pFactura.Apellido_Cliente = reader["ApellidoCliente"].ToString();
                    pFactura.Total_Articulos = Convert.ToInt32(reader["Total_articulos"]);
                    pFactura.Total_a_Pagar = Convert.ToDouble(reader["Total_a_Pagar"]);

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
        public static baseFacturacion getFactura(int NoFactura)
        {
            baseFacturacion pFactura = new baseFacturacion();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getBaseFactura";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoFactura", System.Data.SqlDbType.Int));
                comand.Parameters["@NoFactura"].Value = NoFactura;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pFactura.codigo = Convert.ToInt32(re["NoFactura"]);
                        pFactura.codigoCliente = Convert.ToInt32(re["NoCliente"]);
                        pFactura.fechaRegistro = DateTime.Parse(Convert.ToDateTime(re["fechaRegistro"]).ToString("MM/dd/yyyy"));
                        pFactura.fechaEntrega = DateTime.Parse(Convert.ToDateTime(re["fechaEntrega"]).ToString("MM/dd/yyyy"));
                        pFactura.cantProductos = Convert.ToInt32(re["totalArticulos"]);
                        pFactura.TotalCompradoSinITEBIS = Convert.ToDouble(re["TotalSinImpuestos"]);
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
    public class facturaPendiente
    {
        public int Codigo_Factura { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public int Total_Articulos { get; set; }
        public double Total_a_Pagar { get; set; }

        public facturaPendiente() { }
        public facturaPendiente(int c, string n, string a, int ta, double tp)
        {
            Codigo_Factura = c;
            Nombre_Cliente = n;
            Apellido_Cliente = a;
            Total_Articulos = ta;
            Total_a_Pagar = tp;
        }
    }
}
