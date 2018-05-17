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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Exercicio01_Click(object sender, EventArgs e)
        {
            Exercicio01e02 exercicio01e02 = new Exercicio01e02();
            exercicio01e02.Show();
        }

        private void Exercicio02_Click(object sender, EventArgs e)
        {
            Exercicio03 exercicio03= new Exercicio03();
            exercicio03.Show();
        }

        private void Exercicio04_Click(object sender, EventArgs e)
        {
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Show();
        }

    }
}
