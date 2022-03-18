using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PerfilPessoa.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PessoaCad : ContentPage
    {
        public PessoaCad()
        {
            InitializeComponent();
            txtBairro.IsEnabled = false;
            txtEnd.IsEnabled = false;
            txtNum.IsEnabled = false;
        }

        private async void CEP_Clicked(object sender, EventArgs e)
        {
            try
            {
                var cep = txtCEP.Text;
                string tam, cep_1 = "", logradouro = "", bairro = "", complemento = "", localidade = "", uf = "", ibge = "", gia = "", ddd = "", siafi = "";
                int t, j = 0;
                if (!string.IsNullOrEmpty(cep))
                {
                    //Httpcliente = conector da internet
                    HttpClient clienteHttp = new HttpClient();
                    //await: espera o dado voltar
                    HttpResponseMessage mensagem = await clienteHttp.GetAsync("https://viacep.com.br/ws/" + cep + "/piped/");
                    mensagem.EnsureSuccessStatusCode();
                    tam = await mensagem.Content.ReadAsStringAsync();
                    t = tam.Length;
                    for (int i = 0; i < t; i++)
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
                        else if (j == 1)
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
                }
                txtBairro.IsEnabled = true;
                txtEnd.IsEnabled = true;
                txtBairro.Text = bairro;
                txtEnd.Text = logradouro;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}