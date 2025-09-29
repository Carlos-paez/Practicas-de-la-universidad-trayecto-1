/*
 * Creado por SharpDevelop.
 * Usuario: Personal
 * Fecha: 26/9/2025
 * Hora: 8:18 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace pilaformulario
{
    public class Pila
    {
        private List<string> elementos;

        public Pila()
        {
            elementos = new List<string>();
        }

        /// <summary>
        /// Agrega un elemento a la pila solo si no existe previamente.
        /// </summary>
        /// <param name="dato">Elemento a agregar.</param>
        /// <returns>true si se agregó; false si ya existía.</returns>
        public bool Push(string dato)
        {
            // Validación: no permitir elementos duplicados
            if (elementos.Contains(dato))
            {
                return false; // Ya existe, no se agrega
            }

            elementos.Add(dato);
            return true; // Agregado exitosamente
        }

        /// <summary>
        /// Elimina y devuelve el elemento en el tope de la pila.
        /// </summary>
        /// <returns>El elemento eliminado, o null si la pila está vacía.</returns>
        public string Pop()
        {
            if (elementos.Count == 0)
                return null;

            string ultimo = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return ultimo;
        }

        /// <summary>
        /// Devuelve el elemento en el tope de la pila sin eliminarlo.
        /// </summary>
        /// <returns>El elemento en el tope, o null si la pila está vacía.</returns>
        public string Peek()
        {
            return elementos.Count > 0 ? elementos[elementos.Count - 1] : null;
        }

        /// <summary>
        /// Devuelve una copia de los elementos actuales de la pila.
        /// </summary>
        public List<string> ObtenerElementos()
        {
            return new List<string>(elementos);
        }

        /// <summary>
        /// Indica si la pila está vacía.
        /// </summary>
        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }
    }
}