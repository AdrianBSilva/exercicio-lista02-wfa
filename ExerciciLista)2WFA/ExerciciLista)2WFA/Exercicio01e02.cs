using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciLista_2WFA
{
    public partial class Exercicio01e02 : Form
    {
        public Exercicio01e02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);

            if (numero == 0)
            {
                MessageBox.Show("O número é neutro");
            }
            else if (numero > 0)
            {
                MessageBox.Show("O número é positivo");
            }
            else
            {
                MessageBox.Show("O número é negativo");
            }
            
        }

 
      
    }
}
