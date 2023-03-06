using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = cop.Text;
            int pesos = Int32.Parse(valor);
            double dolar = 4788.63;
            double convertion = pesos * dolar;
            string con = Convert.ToString(convertion);
            MessageBox.Show(string.Concat(valor, " dolares son igual a: ", con, " pesos colombianos."));
            Form3 fibo = new Form3();
            fibo.Show();
            this.Hide();
        }
    }
}
