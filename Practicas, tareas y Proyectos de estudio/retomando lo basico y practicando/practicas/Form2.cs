﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Windows.Forms;

namespace practicas
{
	public partial class Form2 : Form
    {

		private usuarios[] users;
		private administradores[] admins;
		string all_usuarios;

		public Form2(usuarios[] users, administradores[] admins)
        {
            InitializeComponent();
			this.users = users;
			this.admins = admins;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			foreach (usuarios usuario in users)
			{

				MessageBox.Show(usuario.ToString());

			}
        }
    }
}
