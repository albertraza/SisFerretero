 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class baseClientes
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string cedula { get; set; }
        public string celular { get; set; }

        public baseClientes() { }
        public baseClientes(int co, string no, string ape, string dir, string tel, string ced, string cel)
        {
            codigo = co;
            nombre = no;
            apellido = ape;
            direccion = dir;
            telefono = tel;
            cedula = ced;
            celular = cel;
        }

        // metodo que obtiene la informacion del cliente con el numero de cedula
        public static baseClientes getClienteInfo(string cedula)
        {
            baseClientes pCliente = new baseClientes();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getClienteInfoCed";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@cedula", System.Data.SqlDbType.VarChar));
                comand.Parameters["@cedula"].Value = cedula;

                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pCliente.codigo = Convert.ToInt32(reader["NoCliente"]);
                        pCliente.nombre = reader["Name"].ToString();
                        pCliente.apellido = reader["LastName"].ToString();
                        pCliente.direccion = reader["AddressCl"].ToString();
                        pCliente.telefono = reader["phone"].ToString();
                        pCliente.cedula = reader["IDnum"].ToString();
                        pCliente.celular = reader["Cellphone"].ToString();
                    }
                }
                else
                {
                    pCliente = null;
                }
                con.Close();
            }
            return pCliente;
        }

        // metodo que obtiene la informacion del cliente con el codigo del cliente
        public static baseClientes getClienteInfoCod(int codigo)
        {
            baseClientes pCliente = new baseClientes();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getClienteInfo";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NOCliente", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NOCliente"].Value = codigo;

                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pCliente.codigo = Convert.ToInt32(reader["NoCliente"]);
                        pCliente.nombre = reader["Name"].ToString();
                        pCliente.apellido = reader["LastName"].ToString();
                        pCliente.direccion = reader["AddressCl"].ToString();
                        pCliente.telefono = reader["phone"].ToString();
                        pCliente.cedula = reader["IDnum"].ToString();
                        pCliente.celular = reader["Cellphone"].ToString();
                    }
                }
                else
                {
                    pCliente = null;
                }
                con.Close();
            }
            return pCliente;
        }

        // metodo que devuelte la cantidad de facturas que ha hecho este cliente
        public static int getTotalOrdenes(int codigo)   
        {
            int re = -1;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getTotalOrdenesCliente";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoCliente", System.Data.SqlDbType.Int));
                comand.Parameters["@NoCliente"].Value = codigo;

                re = Convert.ToInt32(comand.ExecuteScalar());
                con.Close();
            }
            return re;
        }
    }
}
