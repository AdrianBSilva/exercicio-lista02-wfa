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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            if(comboBox1.SelectedItem.ToString() == "Somar")
            {
                MessageBox.Show("A soma dos valores é: " + (numero1 + numero2));
            }
            else if (comboBox1.SelectedItem.ToString() == "Subtrair")
            {
                MessageBox.Show("A subtração dos valores é: " + (numero1 - numero2));
            }
            else if (comboBox1.SelectedItem.ToString() == "Dividir")
            {
                MessageBox.Show("A divisão dos valores é: " + (numero1 / numero2));
            }
            else if (comboBox1.SelectedItem.ToString() == "Multiplicar")
            {
                MessageBox.Show("A multiplicação dos valores é: " + (numero1 * numero2));
            }
            
        }
    }
}
