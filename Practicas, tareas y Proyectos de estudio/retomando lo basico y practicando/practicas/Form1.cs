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

/*namespace practicas
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

			try
			{
				string clients = username.Text;
				string clave = password.Text;
				char logueado = 'N';
				int id_logueado = -1;

				for (int i = 0; i < this.clientes.Length; i++)
				{
					if (this.clientes[i].GetNombre() == clients && this.clientes[i].GetPassword() == clave || this.administrators[i].GetNombre() == clients && this.administrators[i].GetPassword() == clave)
					{
						logueado = 'Y';
						id_logueado = i;
						break;
					}

				}

				if (logueado == 'Y')
				{
					MessageBox.Show("Bienvenido " + this.clientes[id_logueado].GetNombre(), "LOGUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Form2 admin_options = new Form2(this.clientes, this.administrators);
					admin_options.Show();
				}
				else
				{
					MessageBox.Show("Credenciales incorrectas", "Quien eres?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}

			catch (ArgumentException fe)
			{
				MessageBox.Show("Argumento Invalido" + fe.Message, "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (FormatException es)
			{
				MessageBox.Show("Formato Invalido" + es.Message, "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error de ejecución" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
            
        
    }
}*/



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
			try
			{
				string clients = username.Text;
				string clave = password.Text;
				bool logueado = false;
				string nombre_logueado = "";
				string tipo_logueado = "";

				// Verifica clientes
				for (int i = 0; i < this.clientes.Length; i++)
				{
					if (this.clientes[i].GetNombre() == clients && this.clientes[i].GetPassword() == clave)
					{
						logueado = true;
						nombre_logueado = this.clientes[i].GetNombre();
						tipo_logueado = "Cliente";
						break;
					}
				}

				// Si no está en clientes, verifica administrador
				if (!logueado)
				{
					for (int i = 0; i < this.administrators.Length; i++)
					{
						if (this.administrators[i].GetNombre() == clients && this.administrators[i].GetPassword() == clave)
						{
							logueado = true;
							nombre_logueado = this.administrators[i].GetNombre();
							tipo_logueado = "Administrador";
							break;
						}
					}
				}

				if (logueado)
				{
					MessageBox.Show("Bienvenido " + nombre_logueado + " (" + tipo_logueado + ")", "LOGUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Form2 admin_options = new Form2(this.clientes, this.administrators);
					admin_options.Show();
				}
				else
				{
					MessageBox.Show("Credenciales incorrectas", "¿Quién eres?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (ArgumentException fe)
			{
				MessageBox.Show("Argumento Invalido: " + fe.Message, "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (FormatException es)
			{
				MessageBox.Show("Formato Invalido: " + es.Message, "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error de ejecución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

