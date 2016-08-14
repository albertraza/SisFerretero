using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class suplidores
    {
        public int Codigo { get; set; }
        public string Nombre_Suplidor { get; set; }
        public string Telefono { get; set; }

        public suplidores() { }
        public suplidores(int c, string ns, string t)
        {
            Codigo = c;
            Nombre_Suplidor = ns;
            Telefono = t;
        }

        // metodo para hacer una lista de los suplidores solo con el codigo, nombe y telefono //
        public static List<suplidores> ListSuplidoresCodigoNombre()
        {
            List<suplidores> list = new List<suplidores>();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "ListSuplidoresCodigoNombre";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rea = comand.ExecuteReader();
                while(rea.Read())
                {
                    suplidores pSuplidores = new suplidores();
                    pSuplidores.Codigo = Convert.ToInt32(rea["NoSuplidor"]);
                    pSuplidores.Nombre_Suplidor = rea["NombreSuplidor"].ToString();
                    pSuplidores.Telefono = rea["Telefono"].ToString();
                    list.Add(pSuplidores);
                }
                con.Close();
            }
            return list;
        }
    }
    public class baseSuplidores
    {
        public int NoSuplidor { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string Telefono { get; set; }
        public string direccion { get; set; }

        public baseSuplidores() { }
        public baseSuplidores(int c, string n, string des, string tel, string dir)
        {
            NoSuplidor = c;
            nombre = n;
            descripcion = des;
            Telefono = tel;
            direccion = dir;
        }

        // metodo para obtener la info del suplidor
        public static baseSuplidores getSuplidores(int NoSuplidor)
        {
            baseSuplidores pSuplidor = new baseSuplidores();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getSuplidoresByNumber";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoSuplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@NoSuplidor"].Value = NoSuplidor;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pSuplidor.NoSuplidor = Convert.ToInt32(re["NoSuplidor"]);
                        pSuplidor.nombre = re["NombreSuplidor"].ToString();
                        pSuplidor.descripcion = re["descripcion"].ToString();
                        pSuplidor.Telefono = re["Telefono"].ToString();
                        pSuplidor.direccion = re["direccion"].ToString();
                    }
                }
                else
                {
                    pSuplidor = null;
                }
                con.Close();
            }
            return pSuplidor;
        }

        // metodo para obtener el la info del suplidor solo con el nombre
        public static baseSuplidores getSuplidorNombreSupl(string nombre)
        {
            baseSuplidores pSuplidor = new baseSuplidores();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getSuplidorNombreSupl";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = nombre;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pSuplidor.NoSuplidor = Convert.ToInt32(re["NoSuplidor"]);
                        pSuplidor.nombre = re["NombreSuplidor"].ToString();
                        pSuplidor.descripcion = re["descripcion"].ToString();
                        pSuplidor.Telefono = re["Telefono"].ToString();
                        pSuplidor.direccion = re["direccion"].ToString();
                    }
                }
                else
                {
                    pSuplidor = null;
                }
                con.Close();
            }
            return pSuplidor;
        }

        // metodo para registrar un nuevo suplidor
        public static string registerSuplidor(baseSuplidores pSuplidor)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "registerSuplidor";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = pSuplidor.nombre;

                comand.Parameters.Add(new SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Descripcion"].Value = pSuplidor.descripcion;

                comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Telefono"].Value = pSuplidor.Telefono;

                comand.Parameters.Add(new SqlParameter("@Direccion", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Direccion"].Value = pSuplidor.direccion;

                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Registrado Exitosamente";
                }
                else
                {
                    mensaje = "No se pudo registrar el suplidor";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo para modificar los suplidores
        public static string updateSuplidor(baseSuplidores pSuplidor)
        {
            string mensaje = null;
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "updateSuplidor";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = pSuplidor.nombre;

                comand.Parameters.Add(new SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Descripcion"].Value = pSuplidor.descripcion;

                comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Telefono"].Value = pSuplidor.Telefono;

                comand.Parameters.Add(new SqlParameter("@Direccion", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Direccion"].Value = pSuplidor.direccion;

                comand.Parameters.Add(new SqlParameter("@NoSuplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@NoSuplidor"].Value = pSuplidor.NoSuplidor;

                if (comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Modificado Exitosamente";
                }
                else
                {
                    mensaje = "No se pudo modificar el suplidor";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo para eliminar el suplidor
        public static string deleteSuplidor(int NoSuplidor)
        {
            string mensaje = null;
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "deleteSuplidor";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoSuplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@NoSuplidor"].Value = NoSuplidor;

                if (comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Modificado Exitosamente";
                }
                else
                {
                    mensaje = "No se pudo modificar el suplidor";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo para cargar todos los suplidores
        public static List<baseSuplidores> listAllSuplidores()
        {
            List<baseSuplidores> list = new List<baseSuplidores>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listAllSuplidores";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    baseSuplidores pSuplidor = new baseSuplidores();
                    pSuplidor.NoSuplidor = Convert.ToInt32(re["codigo"]);
                    pSuplidor.nombre = re["nombre"].ToString();
                    pSuplidor.descripcion = re["descripcion"].ToString();
                    pSuplidor.Telefono = re["telefono"].ToString();
                    pSuplidor.direccion = re["direccion"].ToString();

                    list.Add(pSuplidor);
                }
                con.Close();
            }
            return list;
        }

        // metodo pata buscar los suplidores
        public static List<baseSuplidores> searchSuplidores(string NoSuplidor, string Nombre, string Telefono)
        {
            List<baseSuplidores> list = new List<baseSuplidores>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "searchSuplidor";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoSuplidor", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NoSuplidor"].Value = NoSuplidor;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = Nombre;

                comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Telefono"].Value = Telefono;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    baseSuplidores pSuplidor = new baseSuplidores();
                    pSuplidor.NoSuplidor = Convert.ToInt32(re["codigo"]);
                    pSuplidor.nombre = re["nombre"].ToString();
                    pSuplidor.descripcion = re["descripcion"].ToString();
                    pSuplidor.Telefono = re["telefono"].ToString();
                    pSuplidor.direccion = re["direccion"].ToString();

                    list.Add(pSuplidor);
                }
                con.Close();
            }
            return list;
        }
    }
}
