public class Cliente: Persona
{
 public double Saldo { get; set; }
    public Cliente(string nombre, string telefono, string direccion, string correoElectronico)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        CorreoElectronico = correoElectronico;
    }
}