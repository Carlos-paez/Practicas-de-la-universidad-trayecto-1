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
    public partial class Form2 : Form
    {
        public Form2(string usuario, string contraseña)
        {
            InitializeComponent();
            ver1.Text = usuario;
            ver2.Text = contraseña;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
