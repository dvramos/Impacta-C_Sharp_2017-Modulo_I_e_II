using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01
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

        private void somarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resposta = numero1 + numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void subtrairButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resposta = numero1 - numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void multiplicarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resposta = numero1 * numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void dividirButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            double resposta = Convert.ToDouble(numero1) / numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }
    }
}
