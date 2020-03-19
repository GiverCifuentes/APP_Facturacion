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
            List<Cliente> listaClientes = new List<Cliente>();
            List<Factura> listaFacturas = new List<Factura>();
            List<Producto> listaProductos = new List<Producto>();
           
            string seguir = "si";
            int doc;
            string datoModificar;
            int idFactura = 0;
            bool resp = true;

            while (seguir != "no")
            {
                int respuestaInicio;
                Console.Clear();
                Console.WriteLine("+=========================================+");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                Console.WriteLine("|       ELija el Modulo a ingresar        |");
                Console.WriteLine("+=========================================+");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|          *ELIJA UNA OPCION*             |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("| (1) Gestion de Clientes                 |");
                Console.WriteLine("| (2) Gestion de Productos                |");
                Console.WriteLine("| (3) Facturacion                         |");
                Console.WriteLine("| (4) Gestion de Reportes                 |");
                Console.WriteLine("| (5) Salir                               |");
                Console.WriteLine("+=========================================+");
                respuestaInicio = int.Parse(Console.ReadLine());

                if (respuestaInicio == 1)
                {
                    //gestion clientes:

                    int rtaCliente;
                    Console.Clear();
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                    Console.WriteLine("|         **GESTION DE CLIENTES**         |");
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("| (1) Agregar Cliente                     |");
                    Console.WriteLine("| (2) Modificar Cliente                   |");
                    Console.WriteLine("| (3) Cambiar Estado del Cliente          |");
                    Console.WriteLine("| (4) Listar clientes                     |");
                    Console.WriteLine("| (5) salir del modulo clientes           |");
                    Console.WriteLine("+=========================================+");
                    rtaCliente = int.Parse(Console.ReadLine());

                    if (rtaCliente == 1)
                    {
                        //TODO: agregar cliente
                        Cliente cliente = new Cliente();
                        
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|    Ingrese el documento del cliente     |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        cliente.documento = int.Parse(Console.ReadLine());                        
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|    Ingrese el nombre del cliente        |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        cliente.nombreCliente = Console.ReadLine();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|          Ingrese el telefono            |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        cliente.telefono = int.Parse(Console.ReadLine());
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|        Ingrese la edad del cliente      |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        cliente.edad = int.Parse(Console.ReadLine());

                        listaClientes.Add(cliente);
                    }
                    else if (rtaCliente == 2)
                    {
                        {//TODO: modificar cliente
                            Console.Clear();
                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      Digite el documento del cliente    |");
                            Console.WriteLine("|                a modificar              |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            doc = int.Parse(Console.ReadLine());

                            for (int i = 0; i < listaClientes.Count; i++)
                            {
                                if (doc == listaClientes[i].documento && listaClientes[i].estado == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("+=========================================+");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("|             Desea modificar:            |");
                                    Console.WriteLine("|         nombre, edad o telefono         |");
                                    Console.WriteLine("|                                         |");
                                    Console.WriteLine("+=========================================+");
                                    datoModificar = Console.ReadLine();
                                    switch (datoModificar)
                                    {
                                        case "nombre":
                                            Console.Clear();
                                            Console.WriteLine("+=========================================+");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|          Ingrese el nuevo nombre        |");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("+=========================================+");
                                            string nomCliente = Console.ReadLine();
                                            listaClientes[i].nombreCliente = nomCliente;
                                            break;
                                        case "edad":
                                            Console.Clear();
                                            Console.WriteLine("+=========================================+");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|          Ingrese la nueva edad          |");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("+=========================================+");
                                            int edadCliente = int.Parse(Console.ReadLine());
                                            listaClientes[i].edad = edadCliente;
                                            break;
                                        case "telefono":
                                            Console.Clear();
                                            Console.WriteLine("+=========================================+");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("|        Ingrese el nuevo telefono        |");
                                            Console.WriteLine("|                                         |");
                                            Console.WriteLine("+=========================================+");
                                            int telCliente = int.Parse(Console.ReadLine());
                                            listaClientes[i].telefono = telCliente;
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    else if (rtaCliente == 3)
                    {
                        //TODO: cambiar estado cliente
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|     Digite el documento del cliente     |");
                        Console.WriteLine("|          a modificar el estado          |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        doc = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listaClientes.Count; i++)
                        {
                            if (doc == listaClientes[i].documento)
                            {
                                Console.Clear();
                                Console.WriteLine("+=========================================+");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("|            Estado a Modificar:          |");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("| (0) para deshabilitar                   |");
                                Console.WriteLine("| (1) para habilitar                      |");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("+=========================================+");
                                int estadoModificar = int.Parse(Console.ReadLine());
                                switch (estadoModificar)
                                {
                                    case 1:
                                        listaClientes[i].estado = estadoModificar;
                                        break;
                                    case 0:
                                        listaClientes[i].estado = estadoModificar;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaCliente == 4)
                    {
                        //TODO: listar clientes

                        int rtaListar;
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|          Listar Cliente por:            |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("| (1) listar clientes por documento       |");
                        Console.WriteLine("| (2) listar todos los clientes           |");
                        Console.WriteLine("+=========================================+");
                        rtaListar = int.Parse(Console.ReadLine());

                        if (rtaListar == 1)
                        {
                            //listar por documento
                            Console.Clear();
                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|     Ingrese el numero del documento     |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var client in listaClientes)
                            {
                                if (client.documento == doc)
                                {                                    
                                    Console.WriteLine("+=========================================+");
                                    Console.WriteLine($" >Nombre: {client.NombreCliente}");
                                    Console.WriteLine($" >Documento: {client.Documento}");
                                    Console.WriteLine($" >Telefono: {client.Telefono}");
                                    Console.WriteLine($" >Edad: {client.Edad}");
                                    Console.WriteLine($" >Estado: { client.Estado}");
                                    Console.WriteLine("+=========================================+");
                                }
                            }
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los clientes

                            foreach (Cliente client in listaClientes)
                            {                                
                                Console.WriteLine("+=========================================+");
                                Console.WriteLine(" >Nombre: " + client.NombreCliente);
                                Console.WriteLine(" >Documento: " + client.Documento);
                                Console.WriteLine(" >Telefono: " + client.Telefono);
                                Console.WriteLine(" >Edad: " + client.Edad);
                                Console.WriteLine(" >Estado: " + client.Estado);
                                Console.WriteLine("+=========================================+");
                            }
                        }
                    }
                }

                else if (respuestaInicio == 2)
                {
                    //gestion productos
                    int rtaProductos;
                    Console.Clear();
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                    Console.WriteLine("|         **GESTION DE PRODUCTOS**        |");
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("| (1) Agregar Producto                    |");
                    Console.WriteLine("| (2) Cambiar Estado de Producto          |");
                    Console.WriteLine("| (3) Modificar Producto                  |");
                    Console.WriteLine("| (4) Listar Productos                    |");
                    Console.WriteLine("+=========================================+");
                    rtaProductos = int.Parse(Console.ReadLine());

                    if (rtaProductos == 1)
                    {
                        //Agregar producto
                        Producto producto = new Producto();

                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      Ingrese el codigo del producto     |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        producto.idProducto = int.Parse(Console.ReadLine());
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      Ingrese el nombre del producto     |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        producto.nombreProducto = Console.ReadLine();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      Ingrese el valor del producto      |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        producto.valor = int.Parse(Console.ReadLine());
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|       Ingrese el stock del producto     |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        producto.stock = int.Parse(Console.ReadLine());

                        listaProductos.Add(producto);
                    }
                    else if (rtaProductos == 2)
                    {
                        //Modificar estado producto
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      Ingrese el codigo del producto     |");
                        Console.WriteLine("|           a cambiar de estado           |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        int codModificar = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaProductos.Count; i++)
                        {
                            if (codModificar == listaProductos[i].idProducto)
                            {
                                Console.WriteLine("+=========================================+");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("|            Estado modificar:            |");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("| (0) para deshabilitar                   |");
                                Console.WriteLine("| (1) para habilitar                      |");
                                Console.WriteLine("+=========================================+");
                                int cambEstadoP = int.Parse(Console.ReadLine());
                                switch (cambEstadoP)
                                {
                                    case 1:
                                        listaProductos[i].estadoProducto = cambEstadoP;
                                        break;
                                    case 0:
                                        listaProductos[i].estadoProducto = cambEstadoP;
                                        break;
                                }
                            }
                        }
                    }

                    else if (rtaProductos == 3)
                    {
                        //Modificar producto
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|      Digite el codigo del producto      |");
                        Console.WriteLine("|                a modificar              |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("+=========================================+");
                        doc = int.Parse(Console.ReadLine());

                        for (int i = 0; i < listaProductos.Count; i++)
                        {
                            if (doc == listaProductos[i].IdProducto)
                            {                                
                                Console.WriteLine("+=========================================+");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("|             Desea modificar:            |");
                                Console.WriteLine("|          nombre, precio o stock         |");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("+=========================================+");
                                datoModificar = Console.ReadLine();
                                switch (datoModificar)
                                {
                                    case "nombre":                                        
                                        Console.WriteLine("+=========================================+");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|  Ingrese el nuevo nombre del producto   |");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("+=========================================+");
                                        string nomProducto = Console.ReadLine();
                                        listaProductos[i].nombreProducto = nomProducto;
                                        break;
                                    case "precio":                                        
                                        Console.WriteLine("+=========================================+");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|         Ingrese el precio nuevo         |");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("+=========================================+");
                                        int precioProducto = int.Parse(Console.ReadLine());
                                        listaProductos[i].valor = precioProducto;
                                        break;
                                    case "stock":                                        
                                        Console.WriteLine("+=========================================+");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|          Ingrese el nuevo stock         |");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("+=========================================+");
                                        int stockproduct = int.Parse(Console.ReadLine());
                                        listaProductos[i].stock = stockproduct;
                                        break;
                                }
                            }
                        }
                    }
                    else if (rtaProductos == 4)
                    {
                        //Listar producto

                        int rtaListar;
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|          Listar Producto por :          |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("| (1) listar producto por Id              |");
                        Console.WriteLine("| (2) listar todos los productos          |");
                        Console.WriteLine("+=========================================+");
                        rtaListar = int.Parse(Console.ReadLine());

                        if (rtaListar == 1)
                        {
                            //listar por id producto
                            Producto producto = new Producto();
                          
                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|        Ingrese el numero del id         |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var product in listaProductos)
                            {
                                if (product.idProducto == doc)
                                {                                    
                                    Console.WriteLine("+=========================================+");
                                    Console.WriteLine(" >Codigo producto: " + product.IdProducto);
                                    Console.WriteLine(" >Nombre: " + product.NombreProducto);
                                    Console.WriteLine(" >Valor: " + product.Valor);
                                    Console.WriteLine(" >Stock: " + product.Stock);
                                    Console.WriteLine(" >Estado: " + product.EstadoProducto);
                                    Console.WriteLine("+=========================================+");
                                }
                            }
                        }
                        else if (rtaListar == 2)
                        {
                            //listar todos los productos

                            foreach (Producto product in listaProductos)
                            {
                                Console.WriteLine("+=========================================+");
                                Console.WriteLine(" >Codigo producto: " + product.IdProducto);
                                Console.WriteLine(" >Nombre: " + product.NombreProducto);
                                Console.WriteLine(" >Valor: " + product.Valor);
                                Console.WriteLine(" >Stock: " + product.Stock);
                                Console.WriteLine(" >Estado: " + product.EstadoProducto);
                                Console.WriteLine("+=========================================+");
                            }
                        }
                    }
                }
               
                else if (respuestaInicio == 3)
                {
                    //facturar
                    Cliente clienteFactura = new Cliente();
                    int rtaFacturar;
                    string rtaFactura;

                    Console.Clear();
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                    Console.WriteLine("|           GESTION DE FACTURAS           |");
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("| (1) Agregar Factura                     |");
                    Console.WriteLine("| (2) listar todas las facturas           |");
                    Console.WriteLine("+=========================================+");
                    rtaFacturar = int.Parse(Console.ReadLine());

                    if (rtaFacturar == 1)
                    {
                        resp = true;

                        while (resp)
                        {
                            Factura nuevaFactura = new Factura();
                            idFactura++;
                            nuevaFactura.IdFactura = idFactura;
                            int idProducto;
                            
                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|    Ingrese la Fecha de lafactura:       |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            string fecha = Console.ReadLine();

                            nuevaFactura.Fecha = fecha;
                            //datos del cliente:

                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|    Ingrese el documento del cliente     |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            int idCliente = int.Parse(Console.ReadLine());

                            for (int i = 0; i < listaClientes.Count; i++)
                            {
                                if (idCliente == listaClientes[i].documento)
                                {
                                    nuevaFactura.IdCliente = listaClientes[i].documento;
                                    nuevaFactura.NombreCliente = listaClientes[i].NombreCliente;
                                    Console.WriteLine("** datos agregados **");
                                }                                
                            }                           
                            bool agregar = true;
                            while (agregar)
                            {
                                //agrego producto a listaFacturas:
                                Producto producto = new Producto();

                                Console.WriteLine("+=========================================+");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("| Ingrese el codigo del producto comprado |");
                                Console.WriteLine("|                                         |");
                                Console.WriteLine("+=========================================+");
                                idProducto = int.Parse(Console.ReadLine());

                                for (int p = 0; p < listaProductos.Count; p++)
                                {

                                    if (idProducto == listaProductos[p].idProducto)
                                    {
                                        Console.WriteLine("+=========================================+");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|             Ingrese la cantidad         |");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("+=========================================+");
                                        int cantidad = int.Parse(Console.ReadLine());
                                        producto.IdProducto = listaProductos[p].idProducto;
                                        producto.NombreProducto = listaProductos[p].nombreProducto;
                                        if (listaProductos[p].stock < cantidad)
                                        {
                                            Console.WriteLine("** ¡OJO! **");
                                            Console.WriteLine("¡¡No hay stock suficientes!! hay: " + listaProductos[p].Stock);
                                        }
                                        else if (listaProductos[p].stock > 0)
                                        {
                                            producto.CantidadVendida = cantidad;
                                            producto.Stock = listaProductos[p].inventario(producto.CantidadVendida);

                                            //Actualizo stock en listaProductos:
                                            listaProductos[p].Stock = producto.Stock;

                                            producto.Valor = listaProductos[p].Valor;

                                            //sacor valor total por producto
                                            nuevaFactura.SubtotalProducto = nuevaFactura.PrecioXCantidad(producto.CantidadVendida, producto.Valor);

                                            //saco valor total por factura
                                            nuevaFactura.TotalFactura = nuevaFactura.totalFactura + nuevaFactura.SubtotalProducto;
                                        }
                                        else if (listaProductos[p].stock == 0)
                                        {
                                            Console.WriteLine("** ¡OJO! **");
                                            Console.WriteLine(" ¡¡No hay productos!! ");
                                        }
                                        else if (idProducto != listaProductos[p].idProducto)
                                        {
                                            Console.WriteLine("** ¡OJO! **");
                                            Console.WriteLine(" >El producto no existe en inventario< ");
                                        }

                                        nuevaFactura.listaProductos.Add(producto);
                                        
                                        Console.WriteLine("+=========================================+");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("|      ¿Desea agregar mas productos?      |");
                                        Console.WriteLine("|          (si)            (no)           |");
                                        Console.WriteLine("|                                         |");
                                        Console.WriteLine("+=========================================+");

                                        rtaFactura = Console.ReadLine();

                                        if (rtaFactura.Equals("si"))
                                        {
                                            agregar = true;
                                        }
                                        else if (rtaFactura.Equals("no"))
                                        {
                                            agregar = false;
                                        }
                                    }
                                }
                            }                            
                            listaFacturas.Add(nuevaFactura);
                            Console.Clear();
                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|      ¿Desea agregar mas facturas?       |");
                            Console.WriteLine("|          (si)            (no)           |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            string masFacturas = Console.ReadLine();

                            if (masFacturas.Equals("si"))
                            {
                                resp = true;
                            }
                            else if (masFacturas.Equals("no"))
                            {
                                resp = false;
                            }
                        }
                    }
                    else if (rtaFacturar == 2)
                    {
                        //listar las facturas por codigo
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("|          Listar Factura por             |");
                        Console.WriteLine("|                                         |");
                        Console.WriteLine("| (1) listar por codigo factura           |");
                        Console.WriteLine("| (2) todas las facturas                  |");
                        Console.WriteLine("+=========================================+");
                        int rta = int.Parse(Console.ReadLine());
                        if (rta == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("+=========================================+");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("|    Ingrese el numero de la factura      |");
                            Console.WriteLine("|                                         |");
                            Console.WriteLine("+=========================================+");
                            doc = int.Parse(Console.ReadLine());

                            foreach (var factura in listaFacturas)
                            {
                                if (doc == factura.idFactura)
                                {
                                    Console.WriteLine("+===========Información Factura===========+");
                                    Console.WriteLine(" >Numero de factura: " + factura.idFactura);                                      
                                    Console.WriteLine(" >Fecha: " + factura.fecha);
                                    Console.WriteLine(" >Cliente: " + factura.nombreCliente);
                                    Console.WriteLine(" >Total factura: " + factura.totalFactura);
                                    Console.WriteLine("+==========Detalle de productos===========+");

                                    foreach (Producto producto in factura.listaProductos)
                                    {
                                        Console.WriteLine(" >NombreProducto: " + producto.NombreProducto);
                                        Console.WriteLine(" >Cantidad: " + producto.CantidadVendida);
                                        Console.WriteLine(" >Valor Unitario: $" + producto.Valor);
                                        Console.WriteLine(" >SubTotal: $" + (producto.CantidadVendida * producto.Valor));
                                        Console.WriteLine("+=========================================+");
                                    }
                                }
                            }
                        }
                        else if (rta == 2)
                        {
                            //listar todas las facturas

                            foreach (Factura factura in listaFacturas)
                            {
                                Console.WriteLine("+===========Información Factura===========+");
                                Console.WriteLine(" >Numero de factura: " + factura.idFactura);
                                Console.WriteLine(" >Fecha: " + factura.fecha);
                                Console.WriteLine(" >Cliente: " + factura.nombreCliente);
                                Console.WriteLine(" >Total factura: " + factura.totalFactura);
                                Console.WriteLine("+==========Detalle de productos===========+");                                

                                    foreach (Producto producto in factura.listaProductos)
                                    {
                                    Console.WriteLine(" >NombreProducto: " + producto.NombreProducto);
                                    Console.WriteLine(" >Cantidad: " + producto.CantidadVendida);
                                    Console.WriteLine(" >Valor Unitario: $" + producto.Valor);
                                    Console.WriteLine(" >SubTotal: $" + (producto.CantidadVendida * producto.Valor));
                                    Console.WriteLine("+=========================================+");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("******************************************");
                                Console.WriteLine("******************************************");
                                Console.WriteLine("******************************************");

                                Console.WriteLine("");
                            }                            
                        }
                    }
                }
                else if (respuestaInicio == 4)
                {
                    //reportes
                    int rtaReportes;
                    Console.Clear();
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                    Console.WriteLine("|                 REPORTES                |");
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("| (1) Clientes mayores 30 años            |");
                    Console.WriteLine("| (2) Producto con Stock menor a 2 unds   |");
                    Console.WriteLine("| (3) Facturas con valor mayor a $200.000 |");
                    Console.WriteLine("+=========================================+");
                    rtaReportes = int.Parse(Console.ReadLine());

                    if (rtaReportes == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("");
                        Console.WriteLine("  ** Los clientes mayores a 30 años son ** ");
                        Console.WriteLine("");
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("");


                        foreach (Cliente client in listaClientes)
                        {
                            if (client.edad >= 30)
                            {
                                Console.WriteLine(" >Nombre: " + client.NombreCliente);                                                    
                                Console.WriteLine(" >Documento: " + client.Documento);
                                Console.WriteLine(" >Telefono: " + client.Telefono);
                                Console.WriteLine(" >>Edad: " + client.Edad);
                                Console.WriteLine(" >Estado: " + client.Estado);
                                Console.WriteLine("+=========================================+");
                            }
                        }                        
                    }
                    else if (rtaReportes <= 2)
                    {
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("");
                        Console.WriteLine(" ** Los productos con menos de ** ");
                        Console.WriteLine(" **       2 Stock son          ** ");
                        Console.WriteLine("");
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("");


                        foreach (Producto product in listaProductos)
                        {
                            if (product.stock <= 2)
                            {
                                Console.WriteLine(" >Nombre: " + product.NombreProducto);
                                Console.WriteLine(" >Valor: " + product.Valor);
                                Console.WriteLine(" >>Stock: " + product.Stock);
                                Console.WriteLine(" >Estado: " + product.EstadoProducto);
                                Console.WriteLine("+=========================================+");
                            }
                        }
                    }
                    else if (rtaReportes == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("");
                        Console.WriteLine(" ** Las facturas mayores a $200.000 son ** ");
                        Console.WriteLine("");
                        Console.WriteLine("+=========================================+");
                        Console.WriteLine("");


                        foreach (Factura factur in listaFacturas)
                        {
                            if (factur.totalFactura >= 200000)
                            {
                                Console.WriteLine(" >>Id Factura: " + factur.IdFactura);
                                Console.WriteLine(" >Fecha: " + factur.Fecha);
                                Console.WriteLine(" >>Total Factura: " + factur.totalFactura);
                                Console.WriteLine("+=========================================+");
                            }
                        }
                    }
                }               
                Console.WriteLine("+=========================================+");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|      ¿Desea volver al menú principal?   |");
                Console.WriteLine("|           (si)          (no)            |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("+=========================================+");
                string rtaSeguir = Console.ReadLine();

                if (rtaSeguir.Equals("no"))
                {
                    seguir = "no";
                    Console.Clear();
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|     Gracias por utilizar el programa    |");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|      KREMO SISTEMA DE FACTURACION       |");
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("+=========================================+");
                    Console.WriteLine("");
                    Console.WriteLine(" * Para salir presione cualquier tecla... ");
                }
            }
        }  
    }
}

