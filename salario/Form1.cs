using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario(txtnome.Text, float.Parse(txtsalario.Text),float.Parse(txtdescontos.Text),float.Parse(texadd.Text));
            txtliquido.Text = Convert.ToString(func.calcular(float.Parse(txtsalario.Text), float.Parse(txtdescontos.Text), float.Parse(texadd.Text)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
