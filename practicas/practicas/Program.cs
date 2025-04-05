using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la altura del rombo (mitad del alto total): ");
        int altura = int.Parse(Console.ReadLine());
        
        // Parte superior del rombo
        for (int i = 1; i <= altura; i++)
        {
            // Espacios en blanco
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }
            
            // Asteriscos
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
        
        // Parte inferior del rombo
        for (int i = altura - 1; i >= 1; i--)
        {
            // Espacios en blanco
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }
            
            // Asteriscos
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}