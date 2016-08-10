using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class cUsuarios
    {
        public int NoUsuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Departamento { get; set; }

        public cUsuarios() { }
        public cUsuarios(int nu, string d, string n)
        {
            NoUsuario = nu;
            Departamento = d;
            Nombre_Usuario = n;
        }

        // metodo para buscar los usuarios
        public static List<cUsuarios> searchUsuarios(string NoUsuario, string UserName)
        {
            List<cUsuarios> list = new List<cUsuarios>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "searchUsuario";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoUser", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NoUser"].Value = NoUsuario;

                comand.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.VarChar));
                comand.Parameters["@UserName"].Value = UserName;

                SqlDataReader re = comand.ExecuteReader();

                while (re.Read())
                {
                    cUsuarios pUsuarios = new cUsuarios();
                    pUsuarios.NoUsuario = Convert.ToInt32(re["NoUsuario"]);
                    pUsuarios.Nombre_Usuario = re["UserName"].ToString();
                    pUsuarios.Departamento = re["Departamento"].ToString();

                    list.Add(pUsuarios);
                }
                con.Close();
            }
            return list;
        }

        // metodo para listar todos los usuarios
        public static List<cUsuarios> listAllUsuarios()
        {
            List<cUsuarios> list = new List<cUsuarios>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listAllUsuarios";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader re = comand.ExecuteReader();

                while (re.Read())
                {
                    cUsuarios pUsuarios = new cUsuarios();
                    pUsuarios.NoUsuario = Convert.ToInt32(re["NoUsuario"]);
                    pUsuarios.Nombre_Usuario = re["UserName"].ToString();
                    pUsuarios.Departamento = re["Departamento"].ToString();

                    list.Add(pUsuarios);
                }
                con.Close();
            }
            return list;
        }
    }

    public class baseUsuarios
    {
        public int codigo { get; set; }
        public string Nombre { get; set; }
        public int codDepartamento { get; set; }

        public baseUsuarios() { }
        public baseUsuarios(int c, string n, int d)
        {
            codigo = c;
            Nombre = n;
            codDepartamento = d;
        }

        // metodo para obtener la info del usuario
        public static baseUsuarios getUserInfo(int NoUser)
        {
            baseUsuarios pUser = new baseUsuarios();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getUsuario";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoUser", System.Data.SqlDbType.Int));
                comand.Parameters["@NoUser"].Value = NoUser;

                SqlDataReader re = comand.ExecuteReader();

                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        pUser.codigo = Convert.ToInt32(re["NoUser"]);
                        pUser.Nombre = re["UserName"].ToString();
                        pUser.codDepartamento = Convert.ToInt32(re["Departamento"]);
                    }
                }
                else
                {
                    pUser = null;
                }
                con.Close();
            }
            return pUser;
        }

        // metodo para actualizar la info del usuario
        public static string updateUserInfo(baseUsuarios pUser, string contrasena)
        {
            string pMensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "updateUserInfo";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoUser", System.Data.SqlDbType.Int));
                comand.Parameters["@NoUser"].Value = pUser.codigo;

                comand.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.VarChar));
                comand.Parameters["@UserName"].Value = pUser.Nombre;

                comand.Parameters.Add(new SqlParameter("@Password", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Password"].Value = contrasena;

                comand.Parameters.Add(new SqlParameter("@Departamento", System.Data.SqlDbType.Int));
                comand.Parameters["@Departamento"].Value = pUser.codDepartamento;

                if(comand.ExecuteNonQuery() > 0)
                {
                    pMensaje = "Modificado con Exito";
                }
                else
                {
                    pMensaje = "No se pudo modificar";
                }
                con.Close();
            }
            return pMensaje;
        }

        // metodo para eliminar los usuarios
        public static string deleteUsuario(int NoUsuario)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "deleteUser";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoUser", System.Data.SqlDbType.Int));
                comand.Parameters["@NoUser"].Value = NoUsuario;

                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Usuario Eliminado Exitosamente";
                }
                else
                {
                    mensaje = "No se pudo eliminar el usuario";
                }
                con.Close();
            }
            return mensaje;
        }

        // metodo para validar el usuario antes de ser registrado
        public static bool validateUser(string UserName)
        {
            bool validation = false;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "validateUserByUserName";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.VarChar));
                comand.Parameters["@UserName"].Value = UserName;

                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    validation = true;
                }
                else
                {
                    validation = false;
                }
                con.Close();
            }
            return validation;
        }
    }
}
