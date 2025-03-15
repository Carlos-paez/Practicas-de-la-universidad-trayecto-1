using System;

class Program
{
    static void Main(string[] args)
    {
        int factura_numero = 0;
        double total_dia = 0; // Inicializar total_dia
        double total_pagar;
        DateTime fecha = DateTime.Now;
        
	        while (true){
	
	        Console.WriteLine("Ingrese la acción que desea realizar: \n    1 = crear factura. \n    2 = Cierre de caja.");
	        int opccion = int.Parse(Console.ReadLine());
	
	        Console.Clear();
	
	        if (opccion == 1)
	        {
	           
	                // Pedir y capturar datos de los productos
	                Console.WriteLine("Ingrese el nombre del primer producto, presione enter y luego el precio del mismo:");
	                string producto1 = Console.ReadLine();
	                double precio1 = double.Parse(Console.ReadLine());
	
	                Console.WriteLine("Ingrese el nombre del segundo producto, presione enter y luego el precio del mismo:");
	                string producto2 = Console.ReadLine();
	                double precio2 = double.Parse(Console.ReadLine());
	
	                Console.WriteLine("Ingrese el nombre del tercer producto, presione enter y luego el precio del mismo:");
	                string producto3 = Console.ReadLine();
	                double precio3 = double.Parse(Console.ReadLine());
	
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
	
	                double total_base = precio1 + precio2 + precio3;
	                total_pagar = total_base + iva1 + iva2 + iva3; // Total a pagar incluye el IVA
	                total_dia += total_pagar; // Acumular total del día
	                factura_numero++; // Incrementar el número de factura
	
	                Console.Clear();
	
	                // Mostrar la factura
	                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
	                Console.WriteLine(fecha);
	                Console.WriteLine("Cliente: " + nombre_cliente);
	                Console.WriteLine("Ubicado en: " + direccion);
	                Console.WriteLine("Numero de factura: " + factura_numero);
	
	                Console.WriteLine("\n\n\n");
	                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
	
	                Console.WriteLine("");
	                Console.WriteLine("Precio individual de cada Producto");
	
	                Console.WriteLine(producto1 + ": " + precio1 + "                 Incluyendo el IVA: " + iva1);
	                Console.WriteLine(producto2 + ": " + precio2 + "                 Incluyendo el IVA: " + iva2);
	                Console.WriteLine(producto3 + ": " + precio3 + "                 Incluyendo el IVA: " + iva3);
	                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
	                Console.WriteLine("\n Precio total de productos: " + total_base);
	                Console.WriteLine("\n Total a pagar: " + total_pagar);
	
	                Console.ReadLine();
	
	                Console.Clear();
	                Console.WriteLine("\n\n\n");
	
	                if (total_pagar > 100 && total_pagar < 200)
	                {
	                    Console.WriteLine("\n Gracias por su compra");
	                }
	                else if (total_pagar < 100)
	                {
	                    Console.WriteLine("Que tenga feliz día");
	                }
	                else
	                {
	                    Console.WriteLine("Vuelva pronto");
	                }
	                Console.ReadKey(true);
	                Console.Clear();
	            }
	        
	
	        if (opccion == 2)
	        {
	            Console.WriteLine("Al " + fecha + " se crearon " + factura_numero + " facturas.");
	            Console.WriteLine("Sumando un total de: " + total_dia);
	            Console.ReadKey(true);
	            Console.Clear();
	        }
        }
    }
}
