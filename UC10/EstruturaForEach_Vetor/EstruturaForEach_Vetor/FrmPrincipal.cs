using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaForEach_Vetor
{
    public partial class FrmTurismo : Form
    {
        public FrmTurismo()
        {
            InitializeComponent();
        }
        //Inicializar o vetor com 5 posições
        string[] local = new string[5];
        //Inicializar variável do contador
        int n;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Inicia o contador para posicionamento do índice
            for (n = 0; n < local.Length; n++)
            {
                //Testar se a posição está vazia
                if (local[n] == null)
                {
                    //Testar se o textBox foi preenchido 
                    if(txtVisitar.Text != "")
                    {
                        //Vetor recebe o conteúdo do textBox 
                        local[n] = txtVisitar.Text;
                        //Limpa o textBox e joga o foco nele novamente
                        txtVisitar.Text = "";
                        //Colocar o foco no textBox
                        txtVisitar.Focus();
                        //Interrompe o contador 
                        break;
                    }
                    else
                    {
                        //textBox não está preenchido, mostra uma mensagem
                        MessageBox.Show("Preencha o local preferido.","",MessageBoxButtons.OK);
                        txtVisitar.Focus();
                        //Interrompe o contador
                        break;

                    }
                }
            }
            //Testar se já foi preenchido o vetor inteiro
            if (n == local.Length)
            {
                MessageBox.Show("Já foram adicionados 5 locais.","Aviso", MessageBoxButtons.OK);
                txtVisitar.Text = "";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Testa se a primeira posição está vazia
            if (local[0] == null)
            {
                //Mostra a mensagem de lista vazia
                MessageBox.Show("Sua lista está vazia, adicione um elemento", "Aviso", MessageBoxButtons.OK);
                txtVisitar.Focus();
            }
            else
            {
                //Percorre todas as posições do vetor
                //Atribuindo a variável o seu conteúdo
                foreach (string m in local)
                {
                    //Desabilitar o botão mostrar
                    btnMostrar.Enabled = false;
                    //Tratamento de erros exceções
                    //Se ocorrer erro dentro do try, passa o controle para o catch
                    try
                    {
                        ltbLocais.Items.Add(m);
                    }
                    //Se houve um erro, entra dentro do bloco catch

                    catch (ArgumentNullException)
                    {
                        //Tratamento de erro que programador deve desenvolver
                        //No caso, deve mostrar uma msg
                        MessageBox.Show("Sua lista está incompleta.", "Aviso", MessageBoxButtons.OK);
                        //Limpar a listBox 
                        ltbLocais.Items.Clear();
                        txtVisitar.Focus();
                        //Habilitar o botão mostrar
                        btnMostrar.Enabled = true;
                        //Interromper o foreach
                        break;
                    }
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar/zerar o vetor
            for (n = 0; n < local.Length; n++)
            {
                local[n] = null;
            }
            //Limpar listBox
            ltbLocais.Items.Clear();
            //Zerar o contador
            n = 0;
            //Mostrar mensagem
            MessageBox.Show("O vetor e a lista foram limpos", "AVISO", MessageBoxButtons.OK);
            txtVisitar.Focus();
            btnMostrar.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
