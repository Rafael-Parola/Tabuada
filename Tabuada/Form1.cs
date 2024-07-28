using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtNumero.Text);
            listTabuada.Items.Clear();
            while (i<= 10)
            {

                
                resultado = i * numero;
                listTabuada.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
                i = i + 1;
                
                /*declaração de variaveis de tipo inteiro 
                 * Conversão para INT
                 * Condição, enquanto i for menor igual a 10 
                 * Varilve resultado realiza o calculo de i multiplicado pelo número digitado
                 * 
                 * listBox adiciona o item e concatena  (numero * i = resultado 
                 * 
                 * incremento 
                 * 
                 * 
                 */
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            listTabuada.Items.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
