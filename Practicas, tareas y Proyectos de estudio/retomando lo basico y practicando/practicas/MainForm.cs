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

        //Declaración de el arreglo
		usuarios[] users = new usuarios[3];

		public MainForm()
		{
			InitializeComponent();
		}

        //boton de "Enviar"
		void Button1Click(object sender, EventArgs e)
		{

            //Bucle para registrar multiples usuarios
			for (int i = 0; i < users.Length; i++){

                //Asignación de variables
                Nombre = Name.Text;
                Apellido = LastName.Text;
                CI = Cedula.Text;
                FechaNacimiento = DateTime.Parse(Nacimineto.Text);

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
                if (Nombre != null && Apellido != null && CI != null && FechaNacimiento != null && Genero != null)
                {
                    usuarios user = new usuarios(Nombre, Apellido, CI, Genero, FechaNacimiento);
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

            }
        }

        //Boton de "Cerrar"
        private void button2_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}
