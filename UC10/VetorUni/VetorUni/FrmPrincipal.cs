using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetorUni
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Inicializar o vetor para 100 posições
        public int[] lista = new int[100];

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Carregar na posição 0 do índice do vetor o valor digitado no textBox
            lista[0] = Convert.ToInt32(txtNumero.Text);
            //Inicializa o componente ProgressBar
            pgbPreenche.Minimum = 0;
            pgbPreenche.Maximum = 100;
            pgbPreenche.Value = 0;

            //Inicia o somatório a partir do índice 1 até a posição anterior ao tamanho do vetor
            //Não podemos ir até 100 pois os índices do vetor vão de 0 até 99
            for (int i=1; i< lista.Length; i++)
            {
                //carregar na posição i (índice) a soma da posição anterior + o valor textBox
                lista[i] = lista[i - 1] + Convert.ToInt32(txtNumero.Text);
                //Incrementa a progressBar 
                pgbPreenche.Value++;


            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Inicializa o progressBar
            pgbPreenche.Minimum = 0;
            pgbPreenche.Maximum = 100;
            pgbPreenche.Value = 0;

            //Iniciar a contagem 
            for (int i=0; i < lista.Length;i++)
            {
                //Carregar na listBox as informações armazenadas no valor
                //a partir da posição 0
                lstList.Items.Add(lista[i]);

                //Incrementar a progressBar
                pgbPreenche.Value++;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar textBox, listBox, progressBar
            txtNumero.Text = "";
            lstList.Items.Clear();
            pgbPreenche.Value = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
