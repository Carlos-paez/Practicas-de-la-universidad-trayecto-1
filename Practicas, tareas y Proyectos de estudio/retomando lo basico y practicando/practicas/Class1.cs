using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicas
{
    public class usuarios
    {
        string Nombre;
        string Apellido;
        string CI;
        string Genero;
        DateTime FechaNacimiento;

        public usuarios(string nombre, string apellido, string ci, string genero, DateTime fechaNacimiento)
        {
            this.Nombre= nombre;
            this.Apellido = apellido;
            this.CI = ci;
            this.Genero = genero;
            this.FechaNacimiento = fechaNacimiento;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }
        public void SetApellido(string apellido)
        {
            this.Apellido = apellido;
        }

        public string GetCI()
        {
            return CI;
        }
        public void SetCI(string ci)
        {
            this.CI = ci;
        }

        public string GetGenero()
        {
            return Genero;
        }
        public void SetGenero(string genero)
        {
            this.Genero = genero;
        }

        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.FechaNacimiento = fechaNacimiento;
        }
    }

    public class administradores
    {
        private string Nombre;
        private string Apellido;
        private string CI;
        private string Genero;
        private DateTime FechaNacimiento;
        private string Permisos;
        private string Alias;

        public administradores(string nombre, string apellido, string ci, string genero, DateTime fechaNacimiento, string
            permisos, string alias)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.CI = ci;
            this.Genero = genero;
            this.FechaNacimiento = fechaNacimiento;
            this.Permisos = permisos;
            this.Alias = alias;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }
        public void SetApellido(string apellido)
        {
            this.Apellido = apellido;
        }

        public string GetCI()
        {
            return CI;
        }
        public void SetCI(string ci)
        {
            this.CI = ci;
        }

        public string GetGenero()
        {
            return Genero;
        }
        public void SetGenero(string genero)
        {
            this.Genero = genero;
        }

        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public string GetPermisos()
        {
            return Permisos;
        }
        public void SetPermisos(string permisos)
        {
            this.Permisos = permisos;
        }

        public string GetAlias()
        {
            return Alias;
        }
        public void SetAlias(string alias)
        {
            this.Alias = alias;
        }
    }

}
