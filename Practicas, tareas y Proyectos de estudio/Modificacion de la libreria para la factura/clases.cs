using System;
using System.Collections.Generic;

namespace practicando
{
    public class Producto
    {
        //Atributos
        private string nombre;
        private double precio;

        //Constructor
        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        //Guetter y Setter
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }

        //Metodos
        public string Info()
        {
            return nombre + "\t" + precio;
        }

        public double CalcularIva()
        {
            return precio * 0.16;
        }
    }

    public class Usuarios
    {
        //Atributos
        private string nombre;
        private int cedula;
        private string direccion;

        //Constructor 
        public Usuarios(string nombre, int cedula, string direccion)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.direccion = direccion;
        }

        //GeTter y Setter
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetCedula()
        {
            return cedula;
        }

        public void SetCedula(int cedula)
        {
            this.cedula = cedula;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        //Metodos
        public void Vender(List<Producto> productosList)
        {
            Console.WriteLine($"Nombre {GetNombre()}\n Cédula {GetCedula()}\n Dirección {GetDireccion()}\n productos:");

            double total = 0;
            double totalIva = 0;

            foreach (var producto in productosList)
            {
                double iva = producto.CalcularIva();
                Console.WriteLine($"{producto.Info()} - IVA: {iva:C}");
                total += producto.GetPrecio();
                totalIva += iva;
            }

            Console.WriteLine($"Total sin IVA: {total:C}");
            Console.WriteLine($"Total IVA: {totalIva:C}");
            Console.WriteLine($"Total con IVA: {(total + totalIva):C}");
        }
    }
}

