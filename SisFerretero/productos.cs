using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public string Departamento { get; set; }

        public productos() { }
        public productos(int c, string n, string d, double pu, int ce, string ns, string de)
        {
            codigo = c;
            nombre = n;
            detalles = d;
            precioUnd = pu;
            cantExistente = ce;
            Nombre_Suplidor = ns;
            Departamento = de;
        }

        // para tomar la informacion del producto desde la base de datos
        public static baseProductos getProducto(int codigoProducto)
        {
            baseProductos pProducto = new baseProductos();
            using(SqlConnection con = DataBase.connect())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Productos where codigo = '{0}'", codigoProducto), con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    pProducto.codigo = Convert.ToInt32(reader["codigo"]);
                    pProducto.nombre = reader["nombre"].ToString();
                    pProducto.detalles = reader["descripcion"].ToString();
                    pProducto.precioUnd = Convert.ToDouble(double.Parse(reader["precioUnd"].ToString()).ToString("f2"));
                    pProducto.cantExistente = Convert.ToInt32(reader["cantExistente"]);
                    pProducto.codigoSuplidor = Convert.ToInt32(reader["codigoSuplidor"]);
                    pProducto.Imp = Convert.ToInt32(reader["impuesto"]);
                    pProducto.codigoCategoria = Convert.ToInt32(reader["codDepartamento"]);
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
                SqlCommand comand = new SqlCommand("select Productos.codigo, Productos.nombre, Productos.descripcion, Productos.precioUnd, Productos.cantExistente, Suplidores.nombre as NombreSuplidor, categorias.categoria from Productos inner join categorias on categorias.codigo = Productos.codDepartamento inner join Suplidores on Suplidores.codigo = Productos.codigoSuplidor", con);
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
                    pProducto.Departamento = re["categoria"].ToString();

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
                SqlCommand comand = new SqlCommand(string.Format("execute registerProducto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'",
                    pProducto.nombre, pProducto.detalles, pProducto.precioUnd, pProducto.cantExistente, pProducto.codigoSuplidor, pProducto.Imp, pProducto.codigoCategoria), con);
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
    }
}
