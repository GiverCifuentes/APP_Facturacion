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

                while (respuestaInicio != 5)
                {
                    if (respuestaInicio == 1)
                    {
                        //gestion clientes:

                        int rtaCliente;
                        Console.WriteLine("(1) Agregar Cliente (2) Modificar cliente (3) eliminar cliente (4) Listar Clientes (5) salir del programa.");
                        rtaCliente = int.Parse(Console.ReadLine());

                        while (rtaCliente != 5)
                        {
                            if (rtaCliente == 1)
                            {
                                //agregar cliente
                                Console.WriteLine("agregar clientes");
                                Console.WriteLine("desea agregar más clientes?");
                                string agregarMas = Console.ReadLine();

                                if (agregarMas.Equals("no"))
                                {
                                    rtaCliente = 5;
                                }

                            }
                            else if (rtaCliente == 2)
                            {
                                //modificar cliente
                                Console.WriteLine("modiicar clientes");

                                Console.WriteLine("agregar clientes");
                                Console.WriteLine("desea modificar más clientes?");
                                string agregarMas = Console.ReadLine();

                                if (agregarMas.Equals("no"))
                                {
                                    rtaCliente = 5;
                                }
                            }
                            else if (rtaCliente == 3)
                            {
                                //eliminar cliente
                                Console.WriteLine("eliminar clientes");

                                Console.WriteLine("agregar clientes");
                                Console.WriteLine("desea eliminar más clientes?");
                                string agregarMas = Console.ReadLine();

                                if (agregarMas.Equals("no"))
                                {
                                    rtaCliente = 5;
                                }
                            }
                            else if (rtaCliente == 4)
                            {
                                //listar clientes
                                Console.WriteLine("listar clientes");

                                Console.WriteLine("agregar clientes");
                                Console.WriteLine("desea listar más clientes?");
                                string agregarMas = Console.ReadLine();

                                if (agregarMas.Equals("no"))
                                {
                                    rtaCliente = 5;
                                }
                            }

                            Console.WriteLine("desea seguir en el modulo clientes?");
                            string rtaSeguirModCliente = Console.ReadLine();

                            if (rtaSeguirModCliente.Equals("no"))
                            {
                                rtaCliente = 5;
                            }

                        }
                        Console.WriteLine("desea gestionar más clientes?");
                        string rtaModClientes = Console.ReadLine();

                        if (rtaModClientes.Equals("no"))
                        {
                            respuestaInicio = 5;
                        }
                    }
                    else if (respuestaInicio == 2)
                    {
                        //gestion productos
                        int rtaProductos;
                        Console.WriteLine("(1) Agregar Producto (2) Eliminar Producto (3) listar Producto (4) Salir del Modulo Producto.");
                        rtaProductos = int.Parse(Console.ReadLine());

                        while (rtaProductos != 4)
                        {
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
                            }
                            Console.WriteLine("desea gestionar más productos?");
                            string rtaModProductos = Console.ReadLine();

                            if (rtaModProductos.Equals("no"))
                            {
                                rtaProductos = 4;
                            }

                        }

                    }
                    else if (respuestaInicio == 3)
                    {
                        //facturar
                        int rtaFacturar;
                        Console.WriteLine("(1) Agregar Factura (2) listar todas las facturas (3) listar Por número de factura (4) Salir del Modulo Producto.");
                        rtaFacturar = int.Parse(Console.ReadLine());

                        while (rtaFacturar != 4)
                        {
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
                            Console.WriteLine("desea gestionar más facturas?");
                            string rtaModFactura = Console.ReadLine();

                            if (rtaModFactura.Equals("no"))
                            {
                                rtaFacturar = 4;
                            }
                        }
                    }
                    else if (respuestaInicio == 4)
                    {
                        //reportes
                        int rtaReportes;
                        Console.WriteLine("(1) Clientes > 30 años (2) Producto con Stock<2 (3) Facturas>200.000$ (4) Salir del Modulo Producto.");
                        rtaReportes = int.Parse(Console.ReadLine());

                        while (rtaReportes != 4)
                        {
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
                            Console.WriteLine("desea gestionar más facturas?");
                            string rtaModFactura = Console.ReadLine();

                            if (rtaModFactura.Equals("no"))
                            {
                                rtaReportes = 4;
                            }
                        }
                    }

                    Console.WriteLine("desea seguir trabajando modulos?");
                    string rtaSeguirEnModulos = Console.ReadLine();

                    if (rtaSeguirEnModulos.Equals("no"))
                    {
                        respuestaInicio = 5;
                    }

                }
                Console.WriteLine("desea seguir en el programa?");
                string rtaSeguir = Console.ReadLine();

                if (rtaSeguir.Equals("no"))
                {
                    seguir = "no";
                }
            }
        }
    }
}
