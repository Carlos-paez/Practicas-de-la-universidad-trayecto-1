/*
 * Created by SharpDevelop.
 * User: cpaez
 * Date: 9/9/2025
 * Time: 12:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practicas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.Pestañas = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pass = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.otro = new System.Windows.Forms.RadioButton();
			this.mujer = new System.Windows.Forms.RadioButton();
			this.hombre = new System.Windows.Forms.RadioButton();
			this.Nacimineto = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.Cedula = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.LastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.admin_pass = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.Level = new System.Windows.Forms.ComboBox();
			this.alias = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.admin_otro = new System.Windows.Forms.RadioButton();
			this.admin_mujer = new System.Windows.Forms.RadioButton();
			this.admin_hombre = new System.Windows.Forms.RadioButton();
			this.admin_fecha = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.admin_ci = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.admin_apellido = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.adminName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.Pestañas.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(57, 336);
			this.panel1.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 126);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 13);
			this.label13.TabIndex = 1;
			this.label13.Text = "Login";
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.Location = new System.Drawing.Point(11, 89);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(42, 34);
			this.button6.TabIndex = 0;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
			this.panel2.Controls.Add(this.label14);
			this.panel2.Location = new System.Drawing.Point(55, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(515, 43);
			this.panel2.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(195, 8);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(94, 20);
			this.label14.TabIndex = 0;
			this.label14.Text = "Bienvenid@";
			// 
			// Pestañas
			// 
			this.Pestañas.Controls.Add(this.tabPage1);
			this.Pestañas.Controls.Add(this.tabPage2);
			this.Pestañas.Location = new System.Drawing.Point(64, 50);
			this.Pestañas.Name = "Pestañas";
			this.Pestañas.SelectedIndex = 0;
			this.Pestañas.Size = new System.Drawing.Size(506, 287);
			this.Pestañas.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(498, 261);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Usuario Estandar";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkGray;
			this.panel3.Controls.Add(this.pass);
			this.panel3.Controls.Add(this.label15);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.otro);
			this.panel3.Controls.Add(this.mujer);
			this.panel3.Controls.Add(this.hombre);
			this.panel3.Controls.Add(this.Nacimineto);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.Cedula);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.LastName);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.Name);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(6, 6);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(484, 223);
			this.panel3.TabIndex = 7;
			// 
			// pass
			// 
			this.pass.Location = new System.Drawing.Point(26, 181);
			this.pass.Name = "pass";
			this.pass.Size = new System.Drawing.Size(133, 20);
			this.pass.TabIndex = 29;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(43, 165);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(115, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "Contraseña de Usuario";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(333, 90);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Genero";
			// 
			// otro
			// 
			this.otro.AutoSize = true;
			this.otro.Location = new System.Drawing.Point(325, 170);
			this.otro.Name = "otro";
			this.otro.Size = new System.Drawing.Size(50, 17);
			this.otro.TabIndex = 26;
			this.otro.TabStop = true;
			this.otro.Text = "Otros";
			this.otro.UseVisualStyleBackColor = true;
			// 
			// mujer
			// 
			this.mujer.AutoSize = true;
			this.mujer.Location = new System.Drawing.Point(325, 138);
			this.mujer.Name = "mujer";
			this.mujer.Size = new System.Drawing.Size(51, 17);
			this.mujer.TabIndex = 25;
			this.mujer.TabStop = true;
			this.mujer.Text = "Mujer";
			this.mujer.UseVisualStyleBackColor = true;
			// 
			// hombre
			// 
			this.hombre.AutoSize = true;
			this.hombre.Location = new System.Drawing.Point(325, 106);
			this.hombre.Name = "hombre";
			this.hombre.Size = new System.Drawing.Size(62, 17);
			this.hombre.TabIndex = 24;
			this.hombre.TabStop = true;
			this.hombre.Text = "Hombre";
			this.hombre.UseVisualStyleBackColor = true;
			// 
			// Nacimineto
			// 
			this.Nacimineto.Location = new System.Drawing.Point(244, 39);
			this.Nacimineto.Name = "Nacimineto";
			this.Nacimineto.Size = new System.Drawing.Size(213, 20);
			this.Nacimineto.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(296, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Fecha de Nacimiento ";
			// 
			// Cedula
			// 
			this.Cedula.Location = new System.Drawing.Point(26, 126);
			this.Cedula.Name = "Cedula";
			this.Cedula.Size = new System.Drawing.Size(133, 20);
			this.Cedula.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(85, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "CI";
			// 
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(25, 78);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(133, 20);
			this.LastName.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Apellido";
			// 
			// Name
			// 
			this.Name.Location = new System.Drawing.Point(25, 39);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(133, 20);
			this.Name.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(74, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Nombre";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(24, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 26);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cerrar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(391, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 26);
			this.button1.TabIndex = 5;
			this.button1.Text = "Enviar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel4);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(498, 261);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Usuario Administrador";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkGray;
			this.panel4.Controls.Add(this.admin_pass);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.Level);
			this.panel4.Controls.Add(this.alias);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.admin_otro);
			this.panel4.Controls.Add(this.admin_mujer);
			this.panel4.Controls.Add(this.admin_hombre);
			this.panel4.Controls.Add(this.admin_fecha);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.admin_ci);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.admin_apellido);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.adminName);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Location = new System.Drawing.Point(7, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(484, 223);
			this.panel4.TabIndex = 10;
			// 
			// admin_pass
			// 
			this.admin_pass.Location = new System.Drawing.Point(20, 187);
			this.admin_pass.Name = "admin_pass";
			this.admin_pass.Size = new System.Drawing.Size(133, 20);
			this.admin_pass.TabIndex = 33;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(28, 171);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(115, 13);
			this.label16.TabIndex = 32;
			this.label16.Text = "Contraseña de Usuario";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(320, 148);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 13);
			this.label12.TabIndex = 31;
			this.label12.Text = "Nivel de permisos";
			// 
			// Level
			// 
			this.Level.FormattingEnabled = true;
			this.Level.Items.AddRange(new object[] {
            "Elicios ",
            "Olimpo",
            "Valhala"});
			this.Level.Location = new System.Drawing.Point(299, 162);
			this.Level.Name = "Level";
			this.Level.Size = new System.Drawing.Size(133, 21);
			this.Level.TabIndex = 30;
			// 
			// alias
			// 
			this.alias.Location = new System.Drawing.Point(18, 143);
			this.alias.Name = "alias";
			this.alias.Size = new System.Drawing.Size(135, 20);
			this.alias.TabIndex = 29;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(72, 127);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 13);
			this.label11.TabIndex = 28;
			this.label11.Text = "Alias";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(319, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 20);
			this.label6.TabIndex = 27;
			this.label6.Text = "Genero";
			// 
			// admin_otro
			// 
			this.admin_otro.AutoSize = true;
			this.admin_otro.Location = new System.Drawing.Point(287, 102);
			this.admin_otro.Name = "admin_otro";
			this.admin_otro.Size = new System.Drawing.Size(50, 17);
			this.admin_otro.TabIndex = 26;
			this.admin_otro.TabStop = true;
			this.admin_otro.Text = "Otros";
			this.admin_otro.UseVisualStyleBackColor = true;
			// 
			// admin_mujer
			// 
			this.admin_mujer.AutoSize = true;
			this.admin_mujer.Location = new System.Drawing.Point(369, 79);
			this.admin_mujer.Name = "admin_mujer";
			this.admin_mujer.Size = new System.Drawing.Size(51, 17);
			this.admin_mujer.TabIndex = 25;
			this.admin_mujer.TabStop = true;
			this.admin_mujer.Text = "Mujer";
			this.admin_mujer.UseVisualStyleBackColor = true;
			// 
			// admin_hombre
			// 
			this.admin_hombre.AutoSize = true;
			this.admin_hombre.Location = new System.Drawing.Point(287, 79);
			this.admin_hombre.Name = "admin_hombre";
			this.admin_hombre.Size = new System.Drawing.Size(62, 17);
			this.admin_hombre.TabIndex = 24;
			this.admin_hombre.TabStop = true;
			this.admin_hombre.Text = "Hombre";
			this.admin_hombre.UseVisualStyleBackColor = true;
			// 
			// admin_fecha
			// 
			this.admin_fecha.Location = new System.Drawing.Point(256, 25);
			this.admin_fecha.Name = "admin_fecha";
			this.admin_fecha.Size = new System.Drawing.Size(213, 20);
			this.admin_fecha.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(308, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Fecha de Nacimiento ";
			// 
			// admin_ci
			// 
			this.admin_ci.Location = new System.Drawing.Point(18, 104);
			this.admin_ci.Name = "admin_ci";
			this.admin_ci.Size = new System.Drawing.Size(135, 20);
			this.admin_ci.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(72, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(17, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "CI";
			// 
			// admin_apellido
			// 
			this.admin_apellido.Location = new System.Drawing.Point(20, 64);
			this.admin_apellido.Name = "admin_apellido";
			this.admin_apellido.Size = new System.Drawing.Size(133, 20);
			this.admin_apellido.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(57, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Apellido";
			// 
			// adminName
			// 
			this.adminName.Location = new System.Drawing.Point(20, 25);
			this.adminName.Name = "adminName";
			this.adminName.Size = new System.Drawing.Size(133, 20);
			this.adminName.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(57, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 16;
			this.label10.Text = "Nombre";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(25, 230);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(71, 26);
			this.button3.TabIndex = 9;
			this.button3.Text = "Cerrar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(392, 230);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 26);
			this.button4.TabIndex = 8;
			this.button4.Text = "Enviar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 336);
			this.Controls.Add(this.Pestañas);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Text = "practicas";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.Pestañas.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton otro;
        private System.Windows.Forms.RadioButton mujer;
        private System.Windows.Forms.RadioButton hombre;
        private System.Windows.Forms.DateTimePicker Nacimineto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton admin_otro;
        private System.Windows.Forms.RadioButton admin_mujer;
        private System.Windows.Forms.RadioButton admin_hombre;
        private System.Windows.Forms.DateTimePicker admin_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox admin_ci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox admin_apellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.TextBox alias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.Label label16;
    }
}
