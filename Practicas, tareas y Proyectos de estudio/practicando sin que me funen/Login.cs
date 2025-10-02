using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practicando_sin_que_me_funen
{
    public partial class Login : Form
    {
        private Pila mypila = new Pila();

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = email.Text.Trim();
                string clave = pass.Text.Trim();
                string nivel = "";

                if (admin.Checked == true)
                {
                    nivel = "Administrador";
                }

                if (estand.Checked == true)
                {
                    nivel = "Estandar";
                }


                Users user = new Users(name, clave, nivel);


                if (human.Checked == true)
                {
                    if (string.IsNullOrEmpty(user.GetNombre()))
                    {
                        MessageBox.Show("Ingrese un dato valido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (mypila.push(user.GetNombre()))
                    {
                        email.Clear();
                        email.Focus();

                        pass.Clear();
                        pass.Focus();

                        MessageBox.Show($"El Usuario '{user.GetNombre()}' fue creado con exito", "Creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("Por favor confirme que no es un robot", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                viewUsers viewUsers = new viewUsers();
                viewUsers.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
