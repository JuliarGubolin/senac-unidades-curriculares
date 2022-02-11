using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AumentoSalário
{
    public partial class FrmReajuste : Form
    {
        public FrmReajuste()
        {
            InitializeComponent();
        }

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double horasTrabalhadas, double valorSalario)
        {
            //Chamada das funções para converter as informações passadas por parâmetro 
            //Determina o coeficiente de reajuse baseado no turno de trabalho
            double valCoeficiente = GetCoeficiente(rbnTurno);
            //Retorna o valor da gratificação extra
            double valGratificacao = GetGratificacao(rbnTurno, horasTrabalhadas);
            //Cálculo do valor do Salário Normal
            double valSalarioNormal = (horasTrabalhadas * valorSalario);
            //Cálculo do reajuste de salário
            double valSalarioGrat = ((horasTrabalhadas * valorSalario) * valorSalario) + (horasTrabalhadas * valorSalario);
            //Retorna o valor do auxílio alimentação baseado no salário bruto e categoria
            double valAuxilioAlimentacao = GetValorAuxilioAlimentacao(rbnCategoria, valSalarioGrat, valorSalario);
            //Retorna o valor do imposto com base no turno de trabalho e categoria
            double valImposto = GetValorImposto(rbnCategoria, valSalarioGrat);
            //Cálculo do salário liquido
            double valSalarioLiquido = (valSalarioGrat + (valGratificacao + valAuxilioAlimentacao)) - valImposto;
            //Apresentar os resultados na listBox
            ApresentarResultados(valCoeficiente, valSalarioNormal, valSalarioGrat, valImposto, valGratificacao, valAuxilioAlimentacao, valSalarioLiquido);
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            //Retorna coeficiented e aumento sobre o salário bruto baseado no horário de trabalho 
            double valCoeficiente = 0;

            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valCoeficiente = 0.05;
                    break;
                case "Vespertino":
                    valCoeficiente = 0.10;
                    break;
                case "Noturno":
                    valCoeficiente = 0.15;
                    break;
            }
            return valCoeficiente;
        }

        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhadas)
        {
            //Gratificação padrão
            double valGratificacao = 100;
            //Verifica se além do horário noturno trabalhou mais que 40 horas 
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhadas > 40)
            {
                //Atualiza o valor da gratificação 
                valGratificacao = 150;
            }
            return valGratificacao;
        }

        private double GetValorImposto(RadioButton rbnCategoria, double valSalarioBruto)
        {
            //Realizar o cálculo do imposto
            double valImposto = 0;

            switch (rbnCategoria.Text)
            {
                case "Estagiario":
                    if(valSalarioBruto < 1250)
                    {
                        valImposto = valSalarioBruto * 0.01;
                    }
                    else
                    {
                        valImposto = valSalarioBruto * 0.02;
                    }
                    break;
                case "Efetivo":
                    if (valSalarioBruto < 2400)
                    {
                        valImposto = valSalarioBruto * 0.01;
                    }
                    else
                    {
                        valImposto = valSalarioBruto * 0.02;
                    }
                    break;
            }
            return valImposto;
        }

        private double GetValorAuxilioAlimentacao(RadioButton rbnCategoria, double valSalarioBruto, double valSalario)
        {
            //Retorna o valor do auxilio
            double valAuxilioAlimentacao = (valSalarioBruto/3)/2;
            if (rbnCategoria.Text.Equals("Estagiário") && (valSalarioBruto < (valSalario/2)))
            {
                valAuxilioAlimentacao = valSalarioBruto / 3;
            }
            return valAuxilioAlimentacao;
        }
        private string GetSituacaoEstagiario(double valSalarioLiquido)
        {
            if (valSalarioLiquido < 1250)
            {
                return "Mal remunerado";
            }
            else if (valSalarioLiquido < 2400)
            {
                return "Normal";
            }
            else
            {
                return "Bem remunerado";
            }
        }
        private void ApresentarResultados(double valCoeficiente, double valSalarioNormal, double valSalarioGrat, double valImposto, double valGratificacao, double valAuxilioAlimentacao, double valSalarioLiquido)
        {
            //Legenda dos resultados obtidos dos calculos e opções
            txtSituacao.Text = GetSituacaoEstagiario(valSalarioLiquido);
            //Carregar os resultados obtidos na listBox
                                                        //Coluna a direita
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:N}", "Coeficiente adicional: ", valCoeficiente));
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário Normal: ", valSalarioNormal));
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário c/ adicional: ", valSalarioGrat));
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Gratificação do Turno: ", valGratificacao));
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do imposto: ", valImposto));
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor auxílio alimentação: ", valAuxilioAlimentacao));
            ltbResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor salário líquido: ", valSalarioLiquido));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Expressão lambda ou link
            //Substitui uma função e/ou um grupo de condicionais
            //Criar um objeto radioButton
            //gpbCategoria.Controls -> obtém a coleção contida dentro do seu container
            //OfType<RadioButton>().SingleOrDefault(r => r.checked) -> Filtra os elementos da coleção
            //Obtém o elemento único selecionado
            //Economiza linhas
            RadioButton rbnTurno = gpbTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gpbCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            if (txtHorasTrab.Text != "" && txtSalario.Text != "")
            {
                //Chamada do método com a passagem de parâmetros
                RealizarProcessamento(rbnTurno, rbnCategoria, Convert.ToDouble(txtHorasTrab.Text), Convert.ToDouble(txtSalario.Text));
            }
            else
            {
                MessageBox.Show("Os campos Salario Hora e Horas trabalhadas não podem ficar vazios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHorasTrab.Text = "";
                txtSalario.Text = "";
                txtSalario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os controles do Form
            txtHorasTrab.Text = "";
            txtSalario.Text = "";
            txtSalario.Focus();
            txtSituacao.Text = "";
            ltbResultado.Items.Clear();
            rdbEfetivo.Checked = rdbCalouro.Checked = rdbMatutino.Checked = rdbNoturno.Checked = rdbVespertino.Checked = false;
        }
    }
}
