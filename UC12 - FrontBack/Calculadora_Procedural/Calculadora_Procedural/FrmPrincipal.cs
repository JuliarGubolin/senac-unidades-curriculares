using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_OrientadaAObjetos
{
    public partial class FrmPrincipal : Form
    {
        double numero, resultadooperacao;
        bool checaNumero;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var numero1 = obterNumero1(txtNum1.Text);
            var numero2 = obterNumero2(txtNum2.Text);
            switch (cbxOperacao.Text)
            {
                case "Adição":
                    var resultadooperacao = somarNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                case "Subtração":
                    resultadooperacao = subtrairNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                case "Multiplicação":
                    resultadooperacao = multiplicarNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                case "Divisão":
                    resultadooperacao = dividirNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                default:
                    MessageBox.Show("Operação é inválida");
                    break;
            }
        }
        private void cbxOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var numero1 = obterNumero1(txtNum1.Text);
            var numero2 = obterNumero2(txtNum2.Text);
            switch (cbxOperacao.Text)
            {
                case "Adição":
                    var resultadooperacao = somarNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                case "Subtração":
                    resultadooperacao = subtrairNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                case "Multiplicação":
                    resultadooperacao = multiplicarNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                case "Divisão":
                    resultadooperacao = dividirNumeros(numero1, numero2);
                    exibirResultado(cbxOperacao.Text, resultadooperacao);
                    break;
                default:
                    MessageBox.Show("Operação é inválida");
                    break;
            }
        }
        private double obterNumero1(string num1)
        {
            //Verificação na conversão de dados
            checaNumero = double.TryParse(num1, out numero);
            if (checaNumero == false)
            {
                MessageBox.Show("Informe um número válido no campo 1", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                return numero;
            }
        }
        private double obterNumero2(string num2)
        {
            //Verificação na conversão de dados
            checaNumero = double.TryParse(num2, out numero);
            if (checaNumero == false)
            {
                MessageBox.Show("Informe um número válido no campo 1", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                return numero;
            }
        }
        private double somarNumeros(double num1, double num2)
        {
            resultadooperacao = num1 + num2;
            return resultadooperacao;
        }
        private double subtrairNumeros(double num1, double num2)
        {
            resultadooperacao = num1 - num2;
            return resultadooperacao;
        }
        private double multiplicarNumeros(double num1, double num2)
        {
            resultadooperacao = num1 * num2;
            return resultadooperacao;
        }
        private double dividirNumeros(double num1, double num2)
        {
            resultadooperacao = num1 / num2;
            return resultadooperacao;
        }
        private void exibirResultado(string operacao, double result)
        {
            //saída 
           MessageBox.Show($"O resultado da operação {operacao} é {result}.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
