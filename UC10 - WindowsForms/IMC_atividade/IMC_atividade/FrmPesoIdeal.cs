using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_atividade
{
    public partial class FrmCalculoPesoIdeal : Form
    {
        //Criar variável pública do tipo radiobutton e configurar para não deixar o controle selecionado.
        RadioButton rbnSelecionado = null;

        public FrmCalculoPesoIdeal()
        {
            InitializeComponent();
            //Deseleciona os botões
            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;

        }
        //Função caso o botão Masculino seja selecionado/modificado
        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            //Instancia a variável tipo objeto rbt e recebe o evento de seleção
            //RadioButton rbt = (RdioButton) sender
            //Pega a seleção e coloca na variável
            rbnSelecionado = (RadioButton)sender;

            //Verifica se está selecionado, para executar a função: SetPesoIdeal
            //Quando passar pela desseleção dos botões
            if (rbnSelecionado.Checked)
            {
                //Recebe o evento 
                //rbn Selecionado = rbt
                //chama a função
                SetPesoIdeal();

            }
        }

        private void rbtFeminino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;

            if (rbt.Checked)
            {
                rbnSelecionado = rbt;
            }

            SetPesoIdeal();
        }

        //Função para calcular o peso ideal de acordo com a altura
        private void SetPesoIdeal()
        {
            //Tratamento de erros em blocos, manipulador de excessões
            //para não deixar o app fechar
            try
            {
                //Inicializar as variáveis de ambiente
                //recebe o valor digitado convertido
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoideal;

                //Verifica se a opção Masculino foi selecionada
                if (rbnSelecionado.Text.Equals("Masculino"))
                {
                    //Variável recebe o cálculo do peso ideal masculino
                    pesoideal = (72.7*altura) - 58;
                }
                else
                {
                    //Variável  recebe o cálculo do peso ideal Feminino
                    pesoideal = (62.1 * altura) - 44.7;

                }
                //Etiqueta recebe e mostra o peso ideal
                //N: formatação automática
                lblPeso.Text = pesoideal.ToString("N");
            }
            catch(Exception e)
            {
                //Caso tenha dado algum erro, mostra a mensagem
                MessageBox.Show("Selecione o sexo e informe a altura corretamente.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Deseleciona os botões e limpa p textBox
                rbtFeminino.Checked = false;
                rbtMasculino.Checked = false;
                lblPeso.Text = "";
                txtAltura.Text = "";
            }
        }
    }
}
