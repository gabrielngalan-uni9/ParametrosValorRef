using System;
using System.Windows.Forms;

namespace ParametrosValorRef
{
    public partial class Form1 : Form
    {
        void PorValor(double varA, double varB)
        {
            //altera o valor das variáveis locais que são passadas por valor
            //não altera os valores das variáveis originais (declaradas no botão Por Valor)
            //essas alterações são válidas somente dentro deste escopo

            varA = varA * 2;
            varB = varB * 5;
        }

        void PorReferencia(ref double varA, ref double varB)
        {
            //altera o valor das variáveis que são passadas por referência
            //altera os valores das variáveis originais (declaradas no botão Por Referencia)

            varA = varA * 2;
            varB = varB * 5;
        }

        void LimparControles()
        {
            //limpa os textos dos controles
            txtResA.Clear();
            txtResB.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            double varA, varB;

            //Entrada de Dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //Chamar o procedimento PorValor passando os parâmetros
            //É passada uma cópia das chaves
            PorValor(varA, varB);

            //Limpar os Controles
            LimparControles();

            //Saída de Dados para verificar que não houve alteração no valor da
            //variável original
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            double varA, varB;

            //Entrada de Dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //Chamar o procedimento PorValor passando os parâmetros
            //É passada uma cópia das chaves
            PorReferencia(ref varA, ref varB);

            //Limpar os Controles
            LimparControles();

            //Saída de Dados para verificar que não houve alteração no valor da
            //variável original
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }
    }
}
