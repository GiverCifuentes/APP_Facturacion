using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Facturacion
{
    class Producto
    {
        int idProducto;
        string nombreProducto;
        int stock;
        int valor;

        public int IdProducto { get; set; }
        public int NombreProducto { get; set; }
        public int Stock { get; set; }
        public int Valor { get; set; }
    }
}
