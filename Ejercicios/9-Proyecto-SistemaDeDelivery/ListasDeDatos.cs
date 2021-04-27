using System;
using System.Collections.Generic;
public class ListasDeDatos
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public ListasDeDatos()
    {   
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Pizza Familiar", 150);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Pollo con tajadas", 75);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Tacos de Pollo", 45);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Baleadas", 25);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Pupusas", 40);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Pastelitos", 35);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7, "Hot Dogs", 30);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8, "Hamburguesa con papas", 85);
        ListadeProductos.Add(p8);
    }

    public void ListarProductos()
    {
        Console.Clear(); 
        Console.WriteLine("            DELI COMIDAS :)            ");
        Console.WriteLine("                  MENU                 ");
        Console.WriteLine("=======================================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.Clear();
        Console.WriteLine("           CREANDO ORDEN          ");
        Console.WriteLine("==================================");
        Console.WriteLine("");

        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("Numero de telefono: ");
        string telefono = Console.ReadLine();
        Console.Write("Ingrese su direccion: ");
        string direccion = Console.ReadLine();
        Console.Write("Ingrese su correo electronico: ");
        string correoElectronico = Console.ReadLine();

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, nombre, direccion);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
                Console.WriteLine("");
                Console.WriteLine("Subtotal: " + nuevaOrden.Subtotal);
                Console.WriteLine("Impuesto: " + nuevaOrden.Impuesto);
                Console.WriteLine("Total: " + nuevaOrden.Total);
                Console.WriteLine("");

            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
            Console.WriteLine("");
        }

        Console.WriteLine("");
        Console.WriteLine("Tarifa de envio: " + nuevaOrden.TarifaEnvio);
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.TotalOrden);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("              LISTA DE ORDENES              ");
        Console.WriteLine("============================================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha | Subtotal | Impuesto | Total");
        Console.WriteLine("Cliente | Direccion");
        Console.WriteLine("============================================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.Subtotal + " | " + orden.Impuesto +" | " + orden.TotalOrden);
            Console.WriteLine(orden.Nombre + " | " + orden.Direccion);
            
            foreach (var detalle in orden.ListaDetallesOrden)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}