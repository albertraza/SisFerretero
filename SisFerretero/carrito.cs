using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SisFerretero
{
    public class carrito
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Und { get; set; }
        public decimal ITEBIS { get; set; }
        public decimal Total { get; set; }

        public carrito() { }
        public carrito(int c, string nombre, int cantidad, decimal precio, decimal itebis, decimal total)
        {
            Codigo = c;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio_Und = precio;
            ITEBIS = itebis;
            Total = total;
        }

        public List<carrito> getCarrito(string codigoFactura)
        {
            List<carrito> list = new List<carrito>();
            using ()
            {

            }
        }
    }
}
