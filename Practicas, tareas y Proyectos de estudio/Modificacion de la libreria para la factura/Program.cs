using System;
using System.Collections.Generic;

namespace practicando
{
    public class Prog
    {
        public static void Main()
        { 
            List<Producto> ProductosList = new List<Producto>();
            List<Usuarios> userList = new List<Usuarios>();

            try
            {
                New_User(userList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado" + ex.Message);
            }
            
            while (true)
            {
                try
                {
                    Agregar(ProductosList);
                    Venta(userList, ProductosList);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error inesperado" + ex.Message);
                }

                Console.WriteLine("Si desea salir del sistema ingrese si, si desea continuar ingrese no");
                string salir = Console.ReadLine();

                if (salir.Contains("si"))
                {
                    break;
                }
            }
            
            Console.ReadKey(true);
        }

        public static void New_User (List<Usuarios> usersList)
                {
                    try
                    {
                        Console.WriteLine("Ingrese un nombre para su usuario");
                        string name = Console.ReadLine();
        
                        Console.WriteLine("Ingrese su cedula de identidad");
                        int cedula = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Ingrese su Dirección Actual");
                        string addres = Console.ReadLine();
        
                        Usuarios User = new Usuarios(name, cedula, addres);
                        usersList.Add(User);
                        
                        Console.Clear();
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("Error de formato" + fe.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error de Argumento" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inesperado" + ex.Message);
                    }
        
                }
        
        public static void Agregar(List<Producto> ProductosList)
        {
            string opcion = "";
            do
            {
                try
                {
                    
                    Console.WriteLine("Desea ingresar un Producto? \nsi o no");
                    opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "si":
                            Console.WriteLine("Ingrese el nombre del Producto");
                            string name_book = Console.ReadLine();

                            Console.WriteLine("Ingrese Precio del Producto");
                            int money = int.Parse(Console.ReadLine());

                            Producto ProductoI = new Producto(name_book, money);
                            ProductosList.Add(ProductoI);
                            break;
                        
                        case "no":
                            Console.WriteLine("Gracias por su preferencia\n");
                            break;
                        
                        default:
                            Console.WriteLine("Opción Iinvalida");
                            break;
                    }
                    
                   

                    foreach (Producto myitem in ProductosList)
                    {
                        Console.Clear();
                        Console.WriteLine(myitem.Info());
                    }
                    
                    Console.Clear();
                }

                catch (FormatException fe)
                {
                    Console.WriteLine("Error, Formato invalido" + fe.Message);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error e de argumento" + ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error inesperado" + ex.Message);
                }
            } while (opcion == "si");
        }

        public static void Venta(List<Usuarios> userslist, List<Producto> productosList)
        {
            try
            {
                foreach (var user in userslist)
                {
                    user.Vender(productosList);
                }
            
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey(true);
                Console.Clear();
            }

            catch (FormatException fe)
            {
                Console.WriteLine("Error, Formato invalido" + fe.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Error e de argumento" + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado" + ex.Message);
            }
        }

    }
}