using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaMascotas
{
    public partial class Servicio : Form
    {
        private string name, mascota;
        private double precio, descuento;
        
        public Servicio()
        {
            InitializeComponent();
        }
        private string definirEstrato()
        {
            string estrato = "";

            if (estrato1.Checked)
            {
                estrato = "Estrato 1";
            }
            if (estrato2.Checked)
            {
                estrato = "Estrato 2";
            }
            if (estrato3.Checked)
            {
                estrato = "Estrato 3";
            }
            if (estrato4.Checked)
            {
                estrato = "Estrato 4";
            }
            if (estrato5.Checked)
            {
                estrato = "Estrato 5";
            }
            if (estrato6.Checked)
            {
                estrato = "Estrato 6";
            }
            return estrato;
        }
        
        private bool validarTextos()
        {
            if (textNameOwner.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del propietario");
                return false;
            }
            if (textNameMascot.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la mascota");
                return false;
            }
            if (!Service1.Checked && !Service2.Checked && !Service3.Checked)
            {
                MessageBox.Show("Debe seleccionar algun servicio");
                return false;
            }
            if (!estrato1.Checked && !estrato2.Checked && !estrato3.Checked && !estrato4.Checked && !estrato5.Checked && !estrato6.Checked)
            {
                MessageBox.Show("Debe seleccionar algun estrato");
                return false;
            }
            return true;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textNameOwner_TextChanged(object sender, EventArgs e)
        {
            name = textNameOwner.Text;
        }

        private void textNameMascot_TextChanged(object sender, EventArgs e)
        {
            mascota = textNameMascot.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Service2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mensajeOk = MessageBox.Show("Quieres salir?");
            if(mensajeOk == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (validarTextos())
            {
                // precio de servicio 
                if(Service1.Checked)
                {
                    precio = 45.000;
                }
                if (Service2.Checked)
                {
                    precio = 80.000;
                }
                if (Service3.Checked)
                {
                    precio = 100.000;
                }
                // descuento por estrato
                if (estrato1.Checked || estrato2.Checked)
                {
                    descuento = 15;
                }
                if (estrato3.Checked || estrato4.Checked)
                {
                    descuento = 10;
                }
                if (estrato5.Checked || estrato6.Checked)
                {
                    descuento = 5;
                }
                precio = precio - (precio * descuento / 100);
                panel1.Visible = true;
                nameofowner.Text = name;
                nameofpet.Text = mascota;
                estratofield.Text = definirEstrato();
                preciofield.Text = precio.ToString()+".000";

                //MessageBox.Show("Melo to bien");
            }
        }
    }
}
