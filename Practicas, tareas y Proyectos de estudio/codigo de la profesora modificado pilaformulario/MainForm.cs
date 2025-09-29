﻿/*
 * Creado por SharpDevelop.
 * Usuario: Personal
 * Fecha: 26/9/2025
 * Hora: 8:18 p. m.
 *
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pilaformulario
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private Pila miPila = new Pila();

        public MainForm()
        {		
            InitializeComponent();
        }

        void Button1Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(dato))
            {
                label1.Text = "Ingrese un dato válido.";
                return;
            }

            // Intentar agregar el elemento (evita duplicados)
            if (miPila.Push(dato))
            {
                ActualizarLista();
                label1.Text = $"Elemento '{dato}' agregado.";
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                label1.Text = $"El elemento '{dato}' ya existe en la pila.";
            }
        }

        void Button2Click(object sender, EventArgs e)
        {
            if (!miPila.EstaVacia())
            {
                string eliminado = miPila.Pop();
                ActualizarLista();
                label1.Text = $"Elemento eliminado: '{eliminado}'";
            }
            else
            {
                label1.Text = "La pila está vacía.";
            }
        }

        void ActualizarLista()
        {
            listBox1.Items.Clear();
            // Mostrar elementos en orden de inserción (el último agregado = tope = último en la lista visual)
            foreach (var item in miPila.ObtenerElementos())
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tope = miPila.Peek();
            if (tope != null)
            {
                label1.Text = $"Tope de la pila: '{tope}'";
            }
            else
            {
                label1.Text = "La pila está vacía.";
            }
        }
    }
}