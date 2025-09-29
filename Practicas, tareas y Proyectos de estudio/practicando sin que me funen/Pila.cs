using System;
using System.Collections.Generic;

namespace practicando_sin_que_me_funen
{
    public class Pila
    {
        private List<string> items;

        public Pila()
        {
            items = new List<string>();
        }

        // Método push
        public void push(string dato)
        {
            items.Add(dato);
        }

        // Método pop
        public string pop()
        {
            if (items.Count == 0)
                return null;

            string ultimo = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return ultimo;
        }
    }
}
