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
        usuarios[] clientes;
        administradores[] administrators;

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
                int i = 0;

                // Verifica clientes

                    if (this.clientes[i].GetNombre() == clients && this.clientes[i].GetPassword() == clave)
                    {
                        logueado = true;
                        nombre_logueado = this.clientes[i].GetNombre();
                        tipo_logueado = "Cliente";

						MessageBox.Show("Bienvenido " + nombre_logueado + " (" + tipo_logueado + ")", "LOGUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

					else if(this.clientes[i].GetNombre() != clients && this.clientes[i].GetPassword() != clave)
                    {
						MessageBox.Show("Credenciales de usuario estandar incorrectas", "¿Quién eres?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				

                // Si no está en clientes, verifica administrador
                if (!logueado)
                {
                   
                        if (this.administrators[i].GetNombre() == clients && this.administrators[i].GetPassword() == clave)
                        {
                            logueado = true;
                            nombre_logueado = this.administrators[i].GetNombre();
                            tipo_logueado = "Administrador";

							MessageBox.Show("Bienvenido " + nombre_logueado + " (" + tipo_logueado + ")", "LOGUEADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							Form2 admin_options = new Form2(this.clientes, this.administrators);
							admin_options.Show();

                        }

						else
						{
							MessageBox.Show("Credenciales incorrectas", "¿Quién eres?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					
                }

				i++;

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
