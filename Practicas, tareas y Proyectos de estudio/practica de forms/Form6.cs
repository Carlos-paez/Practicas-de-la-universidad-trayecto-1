using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_de_forms
{
    public partial class Form6 : Form
    {
        public Form6(DateTime fecha_nacimiento, DateTime fecha_actual)
        {
            InitializeComponent();
            int edad = fecha_actual.Year - fecha_nacimiento.Year;
            fecha.Text = edad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
