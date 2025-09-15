using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicas
{
    public partial class Form1 : Form
    {
		public Form1(usuarios[] users, administradores[] admins)
        {
            InitializeComponent();
            var clientes = users;
            var administrators = admins;
		}

        private void button1_Click(object sender, EventArgs e)

		{
            string clients = username.Text;
            string clave = password.Text;
        }
    }
}
