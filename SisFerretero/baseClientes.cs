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

        public static baseClientes getClienteInfo(string cedula)
        {
            baseClientes pCliente = new baseClientes();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from clientes where cedula = '{0}'", cedula), con);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pCliente.codigo = Convert.ToInt32(reader["codigo"]);
                        pCliente.nombre = reader["nombre"].ToString();
                        pCliente.apellido = reader["apellido"].ToString();
                        pCliente.direccion = reader["direccion"].ToString();
                        pCliente.telefono = reader["telefono"].ToString();
                        pCliente.cedula = reader["cedula"].ToString();
                        pCliente.celular = reader["celular"].ToString();
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
    }
}
