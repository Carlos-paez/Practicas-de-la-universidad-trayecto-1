using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicas
{
	public partial class Form2 : Form
    {

		private usuarios[] users;
		private administradores[] admins;

		public Form2(usuarios[] users, administradores[] admins)
        {
            InitializeComponent();
			this.users = users;
			this.admins = admins;
		}
    }
}
