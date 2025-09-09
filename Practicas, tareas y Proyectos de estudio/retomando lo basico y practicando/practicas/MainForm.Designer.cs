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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 336);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Location = new System.Drawing.Point(55, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 43);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(445, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(89, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
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
            this.panel3.Location = new System.Drawing.Point(89, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 238);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Genero";
            // 
            // otro
            // 
            this.otro.AutoSize = true;
            this.otro.Location = new System.Drawing.Point(305, 183);
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
            this.mujer.Location = new System.Drawing.Point(305, 151);
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
            this.hombre.Location = new System.Drawing.Point(305, 119);
            this.hombre.Name = "hombre";
            this.hombre.Size = new System.Drawing.Size(62, 17);
            this.hombre.TabIndex = 24;
            this.hombre.TabStop = true;
            this.hombre.Text = "Hombre";
            this.hombre.UseVisualStyleBackColor = true;
            // 
            // Nacimineto
            // 
            this.Nacimineto.Location = new System.Drawing.Point(224, 52);
            this.Nacimineto.Name = "Nacimineto";
            this.Nacimineto.Size = new System.Drawing.Size(213, 20);
            this.Nacimineto.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de Nacimiento ";
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(13, 183);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(133, 20);
            this.Cedula.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "CI";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(13, 121);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(133, 20);
            this.LastName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(13, 55);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(133, 20);
            this.Name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 336);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Text = "practicas";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

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
    }
}
