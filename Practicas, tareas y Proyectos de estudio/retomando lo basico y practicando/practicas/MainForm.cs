using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//variables
		string Nombre = "";
		string Apellido = "";
		string CI;
		string Genero = "";
		DateTime Fecha = DateTime.Now;
		DateTime FechaNacimiento;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{

			Nombre = Name.Text;
			Apellido = LastName.Text;
			CI = Cedula.Text;
			FechaNacimiento = DateTime.Parse(Nacimineto.Text);



		}

        private void button2_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}
