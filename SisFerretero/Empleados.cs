using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class Empleados
    {
        public int NoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Departamento { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }

        public Empleados()
        {

        }
        public Empleados(int nu, string no, string a, int d, string tel, string ced)
        {
            NoEmpleado = nu;
            Nombre = no;
            Apellido = a;
            Departamento = d;
            Telefono = tel;
            Cedula = ced;
        }

        // metodo para registrar un Empleado
        public static string registerEmpleado(Empleados pEmpleado)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "registerEmpleados";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = pEmpleado.Nombre;

                comand.Parameters.Add(new SqlParameter("@Apellido", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Apellido"].Value = pEmpleado.Apellido;

                comand.Parameters.Add(new SqlParameter("@Cedula", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Cedula"].Value = pEmpleado.Cedula;

                comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Telefono"].Value = pEmpleado.Telefono;

                comand.Parameters.Add(new SqlParameter("@Departamento", System.Data.SqlDbType.Int));
                comand.Parameters["@Departamento"].Value = pEmpleado.Departamento;

                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Registrado Exitosamente";
                }
                else
                {
                    mensaje = "No se pudo registrar";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo para obtener la info del empleado
        public static Empleados getEmpleadoByNo(int NoEmpleado)
        {
            Empleados pEmpleado = new Empleados();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getEmpleadoByNo";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoEmpleado", System.Data.SqlDbType.Int));
                comand.Parameters["@NoEmpleado"].Value = NoEmpleado;

                SqlDataReader reader = comand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pEmpleado.NoEmpleado = Convert.ToInt32(reader["NoEmpleado"]);
                        pEmpleado.Nombre = reader["Nombre"].ToString();
                        pEmpleado.Apellido = reader["Apellido"].ToString();
                        pEmpleado.Telefono = reader["Telefono"].ToString();
                        pEmpleado.Cedula = reader["Cedula"].ToString();
                        pEmpleado.Departamento = Convert.ToInt32(reader["Departamento"]);
                    }
                }
                else
                {
                    pEmpleado = null;
                }
                con.Close();
            }
            return pEmpleado;
        }

    }
    public class baseEmpleados
    {
        public int NoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }

        public baseEmpleados()
        {

        }
        public baseEmpleados(int nu, string no, string a, string d, string tel, string ced)
        {
            NoEmpleado = nu;
            Nombre = no;
            Apellido = a;
            Departamento = d;
            Telefono = tel;
            Cedula = ced;
        }

        // metodo para listar todos los empleados
        public static List<baseEmpleados> listAllEmpleados()
        {
            List<baseEmpleados> list = new List<baseEmpleados>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listAllEmpleadosAllInfo";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    baseEmpleados pEmpleado = new baseEmpleados();
                    pEmpleado.NoEmpleado = Convert.ToInt32(reader["NoEmpleado"]);
                    pEmpleado.Nombre = reader["Nombre"].ToString();
                    pEmpleado.Apellido = reader["Apellido"].ToString();
                    pEmpleado.Telefono = reader["Telefono"].ToString();
                    pEmpleado.Cedula = reader["Cedula"].ToString();
                    pEmpleado.Departamento = reader["Departamento"].ToString();

                    list.Add(pEmpleado);
                }
                con.Close();
            }
            return list;
        }

        // metodo para buscar los empleados
        public static List<baseEmpleados> searchEmpleados(string nombre, string cedula, string telefono)
        {
            List<baseEmpleados> list = new List<baseEmpleados>();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "searchEmpleados";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Nombre"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@Cedula", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Cedula"].Value = cedula;

                comand.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Telefono"].Value = telefono;

                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    baseEmpleados pEmpleado = new baseEmpleados();
                    pEmpleado.NoEmpleado = Convert.ToInt32(reader["NoEmpleado"]);
                    pEmpleado.Nombre = reader["Nombre"].ToString();
                    pEmpleado.Apellido = reader["Apellido"].ToString();
                    pEmpleado.Telefono = reader["Telefono"].ToString();
                    pEmpleado.Cedula = reader["Cedula"].ToString();
                    pEmpleado.Departamento = reader["Departamento"].ToString();

                    list.Add(pEmpleado);
                }
                con.Close();
            }
            return list;
        }
    }
}
