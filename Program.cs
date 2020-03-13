using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Cliente> listaClientes = new List<Cliente>();
            //Cliente cliente = new Cliente();
            //List<Producto> listaProductos = new List<Producto>();

            string seguir = "si";

            while (seguir != "no")
            {
                int respuestaInicio;
                Console.WriteLine("Elija una opción");
                Console.WriteLine("(1) para gestion de clientes (2) para gestion de productos (3) para facturación (4) Gestión de reportes (5) Para salir del programa");
                respuestaInicio = int.Parse(Console.ReadLine());

                if (respuestaInicio == 1)
                {
                    //gestion clientes:

                int rtaCliente;
                Console.WriteLine("(1) Agregar Cliente (2) Modificar cliente (3) eliminar cliente (4) Listar Clientes.");
                rtaCliente = int.Parse(Console.ReadLine());
                    if (rtaCliente == 1)
                    {
                        //TODO: agregar cliente

                    }
                    else if (rtaCliente == 2)
                    {
                        //TODO: modificar cliente

                        //haga modificar cliente:

                    }
                    else if (rtaCliente == 3)
                    {
                        //TODO: eliminar cliente

                    }
                    else if (rtaCliente == 4)
                    {
                        //TODO: listar clientes
                        int rtaListar;
                        Console.WriteLine("(1) listar clientes por documento (2) listar todos los clientes.");
                        rtaListar = int.Parse(Console.ReadLine());


                        if (rtaListar == 1)
                        {
                            //listar por documento
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los clientes
                        }
                    }                    
                }
                else if (respuestaInicio == 2)
                {
                    //gestion productos
                    int rtaProductos;
                    Console.WriteLine("(1) Agregar Producto (2) Eliminar Producto (3) listar Producto");
                    rtaProductos = int.Parse(Console.ReadLine());

                    if (rtaProductos == 1)
                    {
                        //Agregar producto
                    }
                    else if (rtaProductos == 2)
                    {
                        //Eliminar producto
                    }
                    else if (rtaProductos == 3)
                    {
                        //Listar producto

                        Console.WriteLine("listar por (1) Id Producto (2) listar todos los productos");
                        int rtaProductosListar = int.Parse(Console.ReadLine());

                        if (rtaProductosListar == 1)
                        {
                            //listar por Id
                        }
                        else if (rtaProductosListar == 2)
                        {
                            //listar todos los productos.
                        }
                    }
                }
                else if (respuestaInicio == 3)
                {
                    //facturar
                    int rtaFacturar;
                    Console.WriteLine("(1) Agregar Factura (2) listar todas las facturas (3) listar Por número de factura.");
                    rtaFacturar = int.Parse(Console.ReadLine());

                    if (rtaFacturar == 1)
                    {
                        //Agregar factura
                    }
                    else if (rtaFacturar == 2)
                    {
                        //listar todas las facturas
                    }
                    else if (rtaFacturar == 3)
                    {
                        //Listar por número de factura
                    }
                }
                else if (respuestaInicio == 4)
                {
                    //reportes
                    int rtaReportes;
                    Console.WriteLine("(1) Clientes > 30 años (2) Producto con Stock<2 (3) Facturas>200.000$.");
                    rtaReportes = int.Parse(Console.ReadLine());

                    if (rtaReportes == 1)
                    {
                        //Clientes > 30
                    }
                    else if (rtaReportes == 2)
                    {
                        //Producto Stock<2
                    }
                    else if (rtaReportes == 3)
                    {
                        //Facturas>200.000
                    }
                }

                Console.WriteLine("desea volver al menú principal?");
                string rtaSeguir = Console.ReadLine();

                if (rtaSeguir.Equals("no"))
                {
                    seguir = "no";
                }
            }
        }
    }
}
