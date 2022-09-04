namespace SpaMascotas
{
    partial class Servicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameMascot = new System.Windows.Forms.TextBox();
            this.textNameOwner = new System.Windows.Forms.TextBox();
            this.Service2 = new System.Windows.Forms.RadioButton();
            this.estrato1 = new System.Windows.Forms.RadioButton();
            this.estrato2 = new System.Windows.Forms.RadioButton();
            this.Service1 = new System.Windows.Forms.RadioButton();
            this.Service3 = new System.Windows.Forms.RadioButton();
            this.estrato6 = new System.Windows.Forms.RadioButton();
            this.estrato5 = new System.Windows.Forms.RadioButton();
            this.estrato4 = new System.Windows.Forms.RadioButton();
            this.estrato3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameofowner = new System.Windows.Forms.Label();
            this.nameofpet = new System.Windows.Forms.Label();
            this.estratofield = new System.Windows.Forms.Label();
            this.preciofield = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del propietario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Mascota";
            // 
            // textNameMascot
            // 
            this.textNameMascot.Location = new System.Drawing.Point(294, 48);
            this.textNameMascot.Name = "textNameMascot";
            this.textNameMascot.PlaceholderText = "Ingrese el nombre";
            this.textNameMascot.Size = new System.Drawing.Size(131, 23);
            this.textNameMascot.TabIndex = 3;
            this.textNameMascot.TextChanged += new System.EventHandler(this.textNameMascot_TextChanged);
            // 
            // textNameOwner
            // 
            this.textNameOwner.BackColor = System.Drawing.SystemColors.Window;
            this.textNameOwner.Cursor = System.Windows.Forms.Cursors.No;
            this.textNameOwner.Location = new System.Drawing.Point(100, 48);
            this.textNameOwner.Name = "textNameOwner";
            this.textNameOwner.PlaceholderText = "Ingrese el nombre";
            this.textNameOwner.Size = new System.Drawing.Size(131, 23);
            this.textNameOwner.TabIndex = 4;
            this.textNameOwner.UseWaitCursor = true;
            this.textNameOwner.TextChanged += new System.EventHandler(this.textNameOwner_TextChanged);
            // 
            // Service2
            // 
            this.Service2.AutoSize = true;
            this.Service2.Location = new System.Drawing.Point(6, 47);
            this.Service2.Name = "Service2";
            this.Service2.Size = new System.Drawing.Size(213, 19);
            this.Service2.TabIndex = 6;
            this.Service2.TabStop = true;
            this.Service2.Text = "Baño, corte y vacuna antigarrapatas";
            this.Service2.UseVisualStyleBackColor = true;
            this.Service2.CheckedChanged += new System.EventHandler(this.Service2_CheckedChanged);
            // 
            // estrato1
            // 
            this.estrato1.AutoSize = true;
            this.estrato1.Location = new System.Drawing.Point(6, 22);
            this.estrato1.Name = "estrato1";
            this.estrato1.Size = new System.Drawing.Size(70, 19);
            this.estrato1.TabIndex = 7;
            this.estrato1.TabStop = true;
            this.estrato1.Text = "Estrato 1";
            this.estrato1.UseVisualStyleBackColor = true;
            // 
            // estrato2
            // 
            this.estrato2.AutoSize = true;
            this.estrato2.Location = new System.Drawing.Point(6, 47);
            this.estrato2.Name = "estrato2";
            this.estrato2.Size = new System.Drawing.Size(70, 19);
            this.estrato2.TabIndex = 8;
            this.estrato2.TabStop = true;
            this.estrato2.Text = "Estrato 2";
            this.estrato2.UseVisualStyleBackColor = true;
            this.estrato2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Service1
            // 
            this.Service1.AutoSize = true;
            this.Service1.Location = new System.Drawing.Point(6, 22);
            this.Service1.Name = "Service1";
            this.Service1.Size = new System.Drawing.Size(91, 19);
            this.Service1.TabIndex = 9;
            this.Service1.TabStop = true;
            this.Service1.Text = "Baño y corte";
            this.Service1.UseVisualStyleBackColor = true;
            // 
            // Service3
            // 
            this.Service3.AutoSize = true;
            this.Service3.Location = new System.Drawing.Point(6, 72);
            this.Service3.Name = "Service3";
            this.Service3.Size = new System.Drawing.Size(293, 19);
            this.Service3.TabIndex = 10;
            this.Service3.TabStop = true;
            this.Service3.Text = "Baño, corte, Vacunas antigarrapatas y Antiparásitos";
            this.Service3.UseVisualStyleBackColor = true;
            this.Service3.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // estrato6
            // 
            this.estrato6.AutoSize = true;
            this.estrato6.Location = new System.Drawing.Point(158, 52);
            this.estrato6.Name = "estrato6";
            this.estrato6.Size = new System.Drawing.Size(70, 19);
            this.estrato6.TabIndex = 12;
            this.estrato6.TabStop = true;
            this.estrato6.Text = "Estrato 6";
            this.estrato6.UseVisualStyleBackColor = true;
            this.estrato6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // estrato5
            // 
            this.estrato5.AutoSize = true;
            this.estrato5.Location = new System.Drawing.Point(158, 22);
            this.estrato5.Name = "estrato5";
            this.estrato5.Size = new System.Drawing.Size(70, 19);
            this.estrato5.TabIndex = 13;
            this.estrato5.TabStop = true;
            this.estrato5.Text = "Estrato 5";
            this.estrato5.UseVisualStyleBackColor = true;
            // 
            // estrato4
            // 
            this.estrato4.AutoSize = true;
            this.estrato4.Location = new System.Drawing.Point(82, 50);
            this.estrato4.Name = "estrato4";
            this.estrato4.Size = new System.Drawing.Size(70, 19);
            this.estrato4.TabIndex = 14;
            this.estrato4.TabStop = true;
            this.estrato4.Text = "Estrato 4";
            this.estrato4.UseVisualStyleBackColor = true;
            // 
            // estrato3
            // 
            this.estrato3.AutoSize = true;
            this.estrato3.Location = new System.Drawing.Point(82, 22);
            this.estrato3.Name = "estrato3";
            this.estrato3.Size = new System.Drawing.Size(70, 19);
            this.estrato3.TabIndex = 15;
            this.estrato3.TabStop = true;
            this.estrato3.Text = "Estrato 3";
            this.estrato3.UseVisualStyleBackColor = true;
            this.estrato3.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Totalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Service1);
            this.groupBox1.Controls.Add(this.Service2);
            this.groupBox1.Controls.Add(this.Service3);
            this.groupBox1.Location = new System.Drawing.Point(100, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios Disponibles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estrato1);
            this.groupBox2.Controls.Add(this.estrato2);
            this.groupBox2.Controls.Add(this.estrato3);
            this.groupBox2.Controls.Add(this.estrato6);
            this.groupBox2.Controls.Add(this.estrato5);
            this.groupBox2.Controls.Add(this.estrato4);
            this.groupBox2.Location = new System.Drawing.Point(100, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estrato";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameofowner);
            this.panel1.Controls.Add(this.nameofpet);
            this.panel1.Controls.Add(this.estratofield);
            this.panel1.Controls.Add(this.preciofield);
            this.panel1.Location = new System.Drawing.Point(203, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 310);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(325, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(228, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estrato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre del propietario";
            // 
            // nameofowner
            // 
            this.nameofowner.AutoSize = true;
            this.nameofowner.Location = new System.Drawing.Point(169, 30);
            this.nameofowner.Name = "nameofowner";
            this.nameofowner.Size = new System.Drawing.Size(16, 15);
            this.nameofowner.TabIndex = 4;
            this.nameofowner.Text = "je";
            // 
            // nameofpet
            // 
            this.nameofpet.AutoSize = true;
            this.nameofpet.Location = new System.Drawing.Point(169, 71);
            this.nameofpet.Name = "nameofpet";
            this.nameofpet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameofpet.Size = new System.Drawing.Size(20, 15);
            this.nameofpet.TabIndex = 3;
            this.nameofpet.Text = "na";
            // 
            // estratofield
            // 
            this.estratofield.AutoSize = true;
            this.estratofield.Location = new System.Drawing.Point(169, 125);
            this.estratofield.Name = "estratofield";
            this.estratofield.Size = new System.Drawing.Size(14, 15);
            this.estratofield.TabIndex = 2;
            this.estratofield.Text = "n";
            this.estratofield.Click += new System.EventHandler(this.label4_Click);
            // 
            // preciofield
            // 
            this.preciofield.AutoSize = true;
            this.preciofield.Location = new System.Drawing.Point(163, 178);
            this.preciofield.Name = "preciofield";
            this.preciofield.Size = new System.Drawing.Size(131, 15);
            this.preciofield.TabIndex = 1;
            this.preciofield.Text = "Nombre del propietario";
            this.preciofield.Click += new System.EventHandler(this.label2_Click);
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNameOwner);
            this.Controls.Add(this.textNameMascot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Servicio";
            this.Text = "Servicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textNameMascot;
        private TextBox textNameOwner;
        private RadioButton Service2;
        private RadioButton estrato1;
        private RadioButton estrato2;
        private RadioButton Service1;
        private RadioButton Service3;
        private RadioButton estrato6;
        private RadioButton estrato5;
        private RadioButton estrato4;
        private RadioButton estrato3;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label nameofowner;
        private Label nameofpet;
        private Label estratofield;
        private Label preciofield;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button button3;
        private Button button2;
        public Panel panel1;
    }
}