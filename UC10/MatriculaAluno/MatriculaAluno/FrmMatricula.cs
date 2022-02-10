using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
            //Mostrar a data corrente no formato: dd/mm/aa - formato curto (short)
            lblHoje.Text = "Hoje é dia: "+ DateTime.Now.ToShortDateString()+".";
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            //Verificar se o textBox "nome" está vazio
            if (txtNome.Text == String.Empty)
            {
                //Mostrar caixa de mensagem se ficar vazio
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Objeto armazena na variável o resultado do cálculo
                //Data atual menos data de nascimento 
                //TimeSpan representa um intervalo de tempo
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpNascimento.Value;
                //Converter o resultado em anos
                //Days => propriedade do objeto de classe TimeSpan converte o resultado em dias
                int idade = (tsQuantidadeDias.Days/365);
                //Mostra o resultado da idade completa 
                lblIdadeAtual.Text = "Sua idade hoje é: "+ idade+" anos completos.";
                if (idade > 17)
                {
                    lblMostraCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblMostraCategoria.Text = "Juvenil B";
                }
                else if(idade > 10)
                {
                    lblMostraCategoria.Text = "Juvenil A";

                }else if (idade > 7)
                {
                    lblMostraCategoria.Text = "Infantil B";
                }
                else if (idade > 5)
                {
                    lblMostraCategoria.Text = "Infantil A";
                }
                else
                {
                    lblMostraCategoria.Text = "Não existe categoria.";
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
