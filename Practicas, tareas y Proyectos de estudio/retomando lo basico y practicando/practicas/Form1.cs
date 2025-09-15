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
		private usuarios[] clientes;
		private administradores[] administrators;

		public Form1(usuarios[] users, administradores[] admins)
        {
            InitializeComponent();
           this.clientes = users;
           this.administrators = admins;
		}

        private void button1_Click(object sender, EventArgs e)

        {

            string clients = username.Text;
            string clave = password.Text;
            char logueado = 'N';
            int id_logueado = -1;

            for (int i = 0; i < this.clientes.Length; i++)
            {
                if (this.clientes[i].GetNombre() == clients && this.clientes[i].GetPassword() == clave)
                {
                    logueado = 'Y';
                    id_logueado = i;
                    break;
                }
            }

            if (logueado == 'Y')
            {
                MessageBox.Show("Bienvenido " + this.clientes[id_logueado].GetNombre(), "LOGUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Quien eres?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
            
        
    }
}
