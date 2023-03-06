using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string termino = txtFibo.Text;
            int fibonacci = Int32.Parse(termino);

            int f0 = 0;
            int f1 = 1;

            for (int i = 0; i < fibonacci; i++)
            {
                int temp = f0;
                f0 = f1;

                f1 = temp + f0;

            }

            MessageBox.Show(string.Concat("El valor de la sucesion de fibonacci para el termino: ", termino, " es igual a: ", Convert.ToSingle(f0)));

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string temp;
        }
    }
}
