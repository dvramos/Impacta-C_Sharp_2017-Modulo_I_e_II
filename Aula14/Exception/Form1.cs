using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            { 
                decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
                if (valorCompra < 0)
                {
                    throw new ApplicationException("Não é permitido números negativos");
                }
                if (valorCompra > 10000)
                {
                    throw new ApplicationException("O valor máximo é R$10.000");
                }
                valorCompraLabel.Text = valorCompra.ToString("c");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número muito grande");
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor de Compra Inválido");
            }
        }
    }
}
