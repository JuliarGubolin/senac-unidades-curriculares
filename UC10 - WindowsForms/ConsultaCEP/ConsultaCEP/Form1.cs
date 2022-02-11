using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Biblioteca para mexer com web
using System.Net.Http;

namespace ConsultaCEP
{
    public partial class FrmInicio : Form
    {
        
        public FrmInicio()
        {
            InitializeComponent();
        }

        private async void btnCEP_Click(object sender, EventArgs e)
        {
            try
            {
                var cep = txtCEP.Text;
                string tam, cep_1="", logradouro="", bairro="", complemento="",localidade="", uf="", ibge="", gia="", ddd="", siafi="";
                int t, j=0;
                if (!string.IsNullOrEmpty(cep))
                {
                    //Httpcliente = conector da internet
                    HttpClient clienteHttp = new HttpClient();
                    //await: espera o dado voltar
                    HttpResponseMessage mensagem = await clienteHttp.GetAsync("https://viacep.com.br/ws/"+cep+"/piped/");
                    mensagem.EnsureSuccessStatusCode();
                    lblResultado.Text = await mensagem.Content.ReadAsStringAsync();
                    tam = lblResultado.Text;
                    t = tam.Length;
                    for(int i = 0; i < t; i++)
                    {
                        if (j == 0)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    cep_1 = cep_1 + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if(j == 1)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    logradouro = logradouro + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 2)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    complemento = complemento + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 3)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    bairro = bairro + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 4)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    localidade = localidade + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 5)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    uf = uf + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 6)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    ibge = ibge + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 7)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    gia = gia + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 8)
                        {
                            if (tam[i] == ':')
                            {
                                i++;
                                while (tam[i] != '|')
                                {
                                    ddd = ddd + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                        else if (j == 9)
                        {

                            if (tam[i] == ':')
                            {
                                i++;
                                while (i < tam.Length)
                                {
                                    siafi = siafi + string.Concat(tam[i]);
                                    i++;
                                }
                                j++;
                            }
                        }
                    }
                    lblResultado.Visible = true;
                    lblResultado.Text = "Seu endereco é: ";
                    rtbEndereco.Text = "CEP: " + cep_1 + "\nLogradouro: " + logradouro + "\nBairro: "+bairro+
                        "\nComplemento: "+complemento+"\nLocalidade: "+localidade+"\nUF: "+uf+"\nIBGE: "+ibge+"\nGia: "+gia+"\nDDD: "+ddd+"\nSiafi: "+siafi;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            
        }
    }
}
