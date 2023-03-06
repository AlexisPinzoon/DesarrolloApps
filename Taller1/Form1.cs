namespace Taller1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string user = TxtName.Text;
            string pass = TxtPass.Text;
            if (user == "Admin" && pass == "admin123")
            {
                MessageBox.Show("Bienvenido");
                Form2 conversion = new Form2();
                conversion.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

        }
    }
}