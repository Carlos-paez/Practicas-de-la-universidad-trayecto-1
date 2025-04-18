public class Productos
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Productos(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    // Método que retorna la factura como string
    public string Facturar()
    {
    	return (Nombre + "				" + Precio);
    }
}

public class Cliente
{
	public string Nombre {get; set;}
	public string Direccion {get; set;}
	public int CI {get; set;}
	
	public Cliente(string nombre, string direccion, int ci)
	{
		Nombre = nombre;
		Direccion = direccion;
		CI = ci;
	}
	
	public string Data()
	{
		return ("Nombre:  "+Nombre + "\n" + "CI:  "+CI + "\n" + "Dirección:  "+Direccion);
	}
	
}