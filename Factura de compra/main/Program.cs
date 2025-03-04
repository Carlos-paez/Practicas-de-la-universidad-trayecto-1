using System;

class Program
{
    static void Main(string[] args)
    {
    	while (true){
    		 // Pedir y capturar datos de los productos
        Console.WriteLine("Ingrese el nombre del primer producto, presione enter y luego el precio del mismo:");
        string producto1 = Console.ReadLine();
        float precio1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre del segundo producto, presione enter y luego el precio del mismo:");
        string producto2 = Console.ReadLine();
        float precio2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre del tercer producto, presione enter y luego el precio del mismo:");
        string producto3 = Console.ReadLine();
        float precio3 = float.Parse(Console.ReadLine());

        // Calcular el IVA de cada producto
        double iva1 = precio1 * 0.16;
        double iva2 = precio2 * 0.16;
        double iva3 = precio3 * 0.16;

       // Capturar datos del cliente
       Console.WriteLine("Ingrese el nombre y apellido del cliente");
       string nombre_cliente = Console.ReadLine();
       
       Console.WriteLine("Ingrese la dirección actual del cliente");
       string direccion = Console.ReadLine();
       
       
       Console.WriteLine("\n\n\n");
       
       DateTime fecha = DateTime.Now;
       float total_base = precio1 + precio2 + precio3;
       double total_pagar = iva1 + iva2 + iva3;
       
       Console.Clear();
       
       //mostrar la factura
       
       Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
       Console.WriteLine(fecha);
       Console.WriteLine("Cliente: " + nombre_cliente);
       Console.WriteLine("Ubicado en: " + direccion);
       
       Console.WriteLine("\n\n\n");
       Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
       
       Console.WriteLine("");
       
       Console.WriteLine("Precio individual de cada Productos");
       
       Console.WriteLine(producto1 + ": " + precio1 + "                 Incluyendo el IVA: " + iva1);
       Console.WriteLine(producto2 + ": " + precio2 + "                 Incluyendo el IVA: " + iva2);
       Console.WriteLine(producto3 + ": " + precio3 + "                 Incluyendo el IVA: " + iva3);
       Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
       Console.WriteLine("\n Precio total de productos: " + total_base);
       Console.WriteLine("\n Total a pagar: " + total_pagar);
       
       Console.ReadLine();
       
       Console.Clear();
       Console.WriteLine("\n\n\n");
       
       if (total_pagar > 100 && total_pagar < 200){
       	Console.WriteLine("\n Gracias por su compra");
       }
       
       else if (total_pagar < 100){
       	Console.WriteLine("Que tenga feliz dia");
       }
       
       else {
       	Console.WriteLine("Buelva pronto");
       }
       Console.ReadKey(true);
       Console.Clear();
    		
    	}
    }
}