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
            string user = email.Text.Trim();
            string date = pass.Text.Trim();

            Dictionary<string, int> levels = nivel.Text;


            Users theuser = new Users(user, date, );

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Ingrese un dato valido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mypila.push(user))
            {
                email.Clear();
                email.Focus();

                pass.Clear();
                pass.Focus();

                MessageBox.Show($"El Usuario '{user}' fue creado con exito", "Creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
