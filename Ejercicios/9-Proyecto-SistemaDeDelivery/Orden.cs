using System;
using System.Collections.Generic;

public class Orden
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrden { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<DetallesOrden> ListaDetallesOrden { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }
    public double TarifaEnvio { get; set; }
    public double Total { get; set; }
    public double TotalOrden { get; set; }

    public Orden(int codigo, DateTime fecha, string numeroOrden, string nombre, string direccion)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numeroOrden;
        Nombre = nombre;
        Direccion = direccion;
        ListaDetallesOrden = new List<DetallesOrden>();
    }

    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaDetallesOrden.Count + 1;
        int cantidad = 1;

        DetallesOrden o = new DetallesOrden(nuevoCodigo, 1, producto);
        ListaDetallesOrden.Add(o);

        Subtotal += cantidad * producto.Precio;
        Impuesto = Subtotal * 0.15;
        TarifaEnvio = 40;
        Total = Subtotal + Impuesto;
        TotalOrden = Total + TarifaEnvio;
    }


}