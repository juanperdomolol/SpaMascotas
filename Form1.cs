namespace SpaMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textPassword.Text == "123")
            {
                Servicio servicio = new Servicio();
                servicio.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}