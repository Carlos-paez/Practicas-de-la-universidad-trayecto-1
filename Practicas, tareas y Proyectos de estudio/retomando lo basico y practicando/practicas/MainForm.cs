using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practicas
{

    public partial class MainForm : Form
    {
        //Declaración de variables
        string Nombre = "";
        string Apellido = "";
        string CI;
        string Genero = "";
        DateTime Fecha = DateTime.Now;
        DateTime FechaNacimiento;
        string Permisos = "";
        string Alias = "";
        string Clave = "";
        int id_user = 0;

        //Declaración de el arreglo
        usuarios[] users = new usuarios[10];
        administradores[] admins = new  administradores[3];

        public MainForm()
        {
            InitializeComponent();
        }

        //Boton de "Cerrar"
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Boton de "Cerrar"
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton de enviar usuarios
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Bucle para registrar multiples usuarios
                for (int i = 0; i < users.Length; i++)
                {

                    //Asignación de variables
                    Nombre = Name.Text;
                    Apellido = LastName.Text;
                    CI = Cedula.Text;
                    FechaNacimiento = DateTime.Parse(Nacimineto.Text);
                    Clave = pass.Text;


                    //Condicional para determinar el genero
                    if (hombre.Checked = true)
                    {
                        Genero = "Hombre";
                    }
                    else if (mujer.Checked = true)
                    {
                        Genero = "Mujer";
                    }
                    else
                    {
                        Genero = "Otro";
                    }

                    //Creación del objeto y asignación al arreglo
                    if (Nombre != null && Apellido != null && CI != null && FechaNacimiento != null && Genero != null && Clave != null)
                    {
                        usuarios user = new usuarios(Nombre, Apellido, CI, Genero, FechaNacimiento, Clave);
                        users[i] = user;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "Invalido");
                    }

                    //Limpieza de los campos 
                    Name.Clear();
                    LastName.Clear();
                    Cedula.Clear();
                    pass.Clear();

					id_user++;
				}
            }

            catch (ArgumentException fe) {
                MessageBox.Show("Argumento Invalido" + fe.Message, "Invalido",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException es)
            {
                MessageBox.Show("Formato Invalido" + es.Message, "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de ejecución" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Boton de enviar administradores
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < admins.Length; i++)
                {

                    //Asignación de variables
                    Nombre = adminName.Text;
                    Apellido = admin_apellido.Text;
                    CI = admin_ci.Text;
                    FechaNacimiento = DateTime.Parse(admin_fecha.Text);
                    Permisos = Level.Text;
                    Alias = alias.Text;
                    Clave = admin_pass.Text;



                    //Condicional para determinar el genero
                    if (admin_hombre.Checked = true)
                    {
                        Genero = "Hombre";
                    }
                    else if (admin_mujer.Checked = true)
                    {
                        Genero = "Mujer";
                    }
                    else
                    {
                        Genero = "Otro";
                    }


                    //Creación del objeto y asignación al arreglo
                    if (Nombre != null && Apellido != null && CI != null && FechaNacimiento != null && Genero != null && Permisos != null && Alias != null && Clave != null && Level != null)
                    {
                        administradores admin = new administradores(Nombre, Apellido, CI, Genero, FechaNacimiento, Permisos, Alias, Clave);
                        admins[i] = admin;
                    }

                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "Invalido");
                    }

                    //Limpieza de los campos 
                    adminName.Clear();
                    admin_apellido.Clear();
                    admin_ci.Clear();
                    alias.Clear();
                    admin_pass.Clear();
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

        //Boton Login
        private void button6_Click(object sender, EventArgs e)
        {

            Form1 login = new Form1(this.users, this.admins);
            login.Show();
        }
    }
}
