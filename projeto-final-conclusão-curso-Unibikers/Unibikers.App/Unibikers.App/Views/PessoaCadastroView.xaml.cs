using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Unibikers.App.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Unibikers.App.Data;
using System.Net.Http;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PessoaCadastroView : ContentPage
    {
        private Pessoa _pessoa;
        PessoaFirebaseService _pessoaFirebaseService;

        public PessoaCadastroView()
        {
            InitializeComponent();
            _pessoa = new Pessoa();
            //IniciaPessoa(App.IdUsuario);
            txtBairro.IsEnabled = false;
            txtLogradouro.IsEnabled = false;
            txtNumero.IsEnabled = false;
        }

        #region Botão Salvar
        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //if (_pessoa == null)
                //{
                //    _pessoa = new Pessoa();
                //}
                _pessoa.IdUsuario = App.IdUsuario;
                _pessoa.CEP = txtCEP.Text;
                _pessoa.Logradouro = txtLogradouro.Text;
                _pessoa.Numero = Convert.ToInt32(txtNumero.Text);
                _pessoa.Bairro = txtBairro.Text;
                _pessoa.Sexo = txtSexo.SelectedIndex.ToString();
                var idPessoa = await App.PessoaData.SalvaPessoaAsync(_pessoa);
                EnviaPessoa(_pessoa);
                App.Current.MainPage = new MasterView();
            }
            catch(Exception erro)
            {
                await DisplayAlert("Atenção", erro.Message, "Fechar");
            }
            
        }
        #endregion
        private async void EnviaPessoa(Pessoa pessoa)
        {
            _pessoaFirebaseService = new PessoaFirebaseService();
            await _pessoaFirebaseService.IncluiPessoaAsync(pessoa);
        }

        #region Calculo CEP
        private async void btnCEP_Clicked(object sender, EventArgs e)
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
                txtLogradouro.IsEnabled = true;
                txtBairro.Text = bairro;
                txtLogradouro.Text = logradouro;
                txtNumero.IsEnabled = true;
            }
            catch
            {
                await DisplayAlert("Atenção", "Erro: CEP inválido! Digite novamente.", "Fechar");
            }

        }
        #endregion

        //private async void IniciaPessoa(Guid id)
        //{
        //    var pessoa = await App.PessoaData.ObtemPessoaAsync(id);
        //    if(pessoa != null)
        //    {
        //        await DisplayAlert("Atenção", "Você já inseriu um endereço!", "OK");
        //    }
            
        //}
    }

}