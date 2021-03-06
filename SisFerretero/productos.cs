﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SisFerretero
{
    public class productos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public double precioUnd { get; set; }
        public int cantExistente { get; set; }
        public string Nombre_Suplidor { get; set; }
        public string Categoria { get; set; }

        public productos() { }
        public productos(int c, string n, string d, double pu, int ce, string ns, string de)
        {
            codigo = c;
            nombre = n;
            detalles = d;
            precioUnd = pu;
            cantExistente = ce;
            Nombre_Suplidor = ns;
            Categoria = de;
        }

        // para tomar la informacion del producto desde la base de datos
        public static baseProductos getProducto(int NoProducto)
        {
            baseProductos pProducto = new baseProductos();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "getProducto";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoProducto", System.Data.SqlDbType.Int));
                comand.Parameters["@NoProducto"].Value = NoProducto;

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    pProducto.codigo = Convert.ToInt32(reader["NoProducto"]);
                    pProducto.nombre = reader["nombre"].ToString();
                    pProducto.detalles = reader["descripcion"].ToString();
                    pProducto.precioUnd = Convert.ToDouble(double.Parse(reader["precioUnd"].ToString()).ToString("f2"));
                    pProducto.cantExistente = Convert.ToInt32(reader["cantExistente"]);
                    pProducto.codigoSuplidor = Convert.ToInt32(reader["Suplidor"]);
                    pProducto.Imp = Convert.ToInt32(reader["impuesto"]);
                    pProducto.codigoCategoria = Convert.ToInt32(reader["Categoria"]);
                }
                con.Close();
            }
            return pProducto;
        }
        
        // para hacer una lista de todos los productos
        public static List<productos> listAllProducto()
        {
            List<productos> list = new List<productos>();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "listAllProducto";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    productos pProducto = new productos();
                    pProducto.codigo = Convert.ToInt32(re["codigo"]);
                    pProducto.nombre = re["nombre"].ToString();
                    pProducto.detalles = re["descripcion"].ToString();
                    pProducto.precioUnd = Convert.ToDouble(re["precioUnd"]);
                    pProducto.cantExistente = Convert.ToInt32(re["cantExistente"]);
                    pProducto.Nombre_Suplidor = re["NombreSuplidor"].ToString();
                    pProducto.Categoria = re["categoria"].ToString();

                    list.Add(pProducto);
                }
                con.Close();
            }
            return list;
        }

        // metodo para buscar un producto
        public static List<productos> searchProductos(string NoProducto, string nombre, string proveedor, string categoria)
        {
            List<productos> list = new List<productos>();
            using (SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "searchProducto";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@NoProducto", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NoProducto"].Value = NoProducto;

                comand.Parameters.Add(new SqlParameter("@NombreProducto", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NombreProducto"].Value = nombre;

                comand.Parameters.Add(new SqlParameter("@NombreSuplidor", System.Data.SqlDbType.VarChar));
                comand.Parameters["@NombreSuplidor"].Value = proveedor;

                comand.Parameters.Add(new SqlParameter("@Categoria", System.Data.SqlDbType.VarChar));
                comand.Parameters["@Categoria"].Value = categoria;

                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    productos pProducto = new productos();
                    pProducto.codigo = Convert.ToInt32(re["codigo"]);
                    pProducto.nombre = re["nombre"].ToString();
                    pProducto.detalles = re["descripcion"].ToString();
                    pProducto.precioUnd = Convert.ToDouble(re["precioUnd"]);
                    pProducto.cantExistente = Convert.ToInt32(re["cantExistente"]);
                    pProducto.Nombre_Suplidor = re["NombreSuplidor"].ToString();
                    pProducto.Categoria = re["categoria"].ToString();

                    list.Add(pProducto);
                }
                con.Close();
            }
            return list;
        }
    }
    public class baseProductos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public double precioUnd { get; set; }
        public int cantExistente { get; set; }
        public int codigoSuplidor { get; set; }
        public int Imp { get; set; }
        public int codigoCategoria { get; set; }

        public baseProductos() { }
        public baseProductos(int c, string n, string d, double pu, int ce, int cs, int im, int codigoCat)
        {
            codigo = c;
            nombre = n;
            detalles = d;
            precioUnd = pu;
            cantExistente = ce;
            codigoSuplidor = cs;
            Imp = im;
            codigoCategoria = codigoCat;
        }

        // metodo para registrar un nuevo producto
        public static string Registrar(baseProductos pProducto)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;

                comand.CommandText = "registerProducto";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = pProducto.nombre;

                comand.Parameters.Add(new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar));
                comand.Parameters["@descripcion"].Value = pProducto.detalles;

                comand.Parameters.Add(new SqlParameter("@precioUnidad", System.Data.SqlDbType.Money));
                comand.Parameters["@precioUnidad"].Value = pProducto.precioUnd;

                comand.Parameters.Add(new SqlParameter("@cantidadExistente", System.Data.SqlDbType.Int));
                comand.Parameters["@cantidadExistente"].Value = pProducto.cantExistente;

                comand.Parameters.Add(new SqlParameter("@Suplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@Suplidor"].Value = pProducto.codigoSuplidor;

                comand.Parameters.Add(new SqlParameter("@impuesto", System.Data.SqlDbType.Int));
                comand.Parameters["@impuesto"].Value = pProducto.Imp;

                comand.Parameters.Add(new SqlParameter("@Departamento", System.Data.SqlDbType.Int));
                comand.Parameters["@Departamento"].Value = pProducto.codigoCategoria;


                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Producto Registrado Existosamente!";
                }
                else
                {
                    mensaje = "No se pudo Registrar el Producto";
                }

                con.Close();
            }
            return mensaje;
        }

        // metodo para modificar un producto existente
        public static string update(baseProductos pProducto)
        {
            string mensaje = null;
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand();
                comand.Connection = con;

                comand.CommandText = "updateProducto";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                comand.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar));
                comand.Parameters["@nombre"].Value = pProducto.nombre;

                comand.Parameters.Add(new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar));
                comand.Parameters["@descripcion"].Value = pProducto.detalles;

                comand.Parameters.Add(new SqlParameter("@precioUnidad", System.Data.SqlDbType.Money));
                comand.Parameters["@precioUnidad"].Value = pProducto.precioUnd;

                comand.Parameters.Add(new SqlParameter("@cantidadExistente", System.Data.SqlDbType.Int));
                comand.Parameters["@cantidadExistente"].Value = pProducto.cantExistente;

                comand.Parameters.Add(new SqlParameter("@Suplidor", System.Data.SqlDbType.Int));
                comand.Parameters["@Suplidor"].Value = pProducto.codigoSuplidor;

                comand.Parameters.Add(new SqlParameter("@impuesto", System.Data.SqlDbType.Int));
                comand.Parameters["@impuesto"].Value = pProducto.Imp;

                comand.Parameters.Add(new SqlParameter("@Departamento", System.Data.SqlDbType.Int));
                comand.Parameters["@Departamento"].Value = pProducto.codigoCategoria;

                comand.Parameters.Add(new SqlParameter("@codigoProducto", System.Data.SqlDbType.Int));
                comand.Parameters["@codigoProducto"].Value = pProducto.codigo;

                if(comand.ExecuteNonQuery() > 0)
                {
                    mensaje = "Modificado Exitosamente!";
                }
                else
                {
                    mensaje = "No se pudo modificar";
                }
                con.Close();
            }
            return mensaje;
        }
    }
}
