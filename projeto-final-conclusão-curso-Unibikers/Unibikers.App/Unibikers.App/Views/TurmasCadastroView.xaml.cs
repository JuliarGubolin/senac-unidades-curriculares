using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Unibikers.App.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TurmasCadastroView : ContentPage
    {
        //Instancio Turma local e no firebase
        private Turma _turma;
        TurmaFirebaseService _turmaFirebase;

        public TurmasCadastroView()
        {
            InitializeComponent();
        }

        //Construtor
        public TurmasCadastroView(Guid idUsuario)
        {
            InitializeComponent();

           
            //Verefica se o usuario é valido
            if (idUsuario == Guid.Empty)
            {
                this.DisplayAlert("Erro de Criação",
                    "Não foi possivel criar uma turma devido a não conter um usuario logado",
                    "Retonar");
                this.Navigation.PopAsync();

            }

            //incializa uma nova turma, atribuindo o id do criador
            _turma = new Turma();
            _turma.IdPessoa = idUsuario;

            //Construir turma
            this.BindingContext = _turma;

        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void btnCriarTurma_Clicked(object sender, EventArgs e)
        {
            var nomeTurma = EtNomeTurma.Text;
            var descricaoTurma = EtDescricaoTurma.Text;

            CriarTurma(nomeTurma, descricaoTurma);

            this.Navigation.PopAsync();

        }

        public async void CriarTurma(string nomeTurma, string descricaoTurma)
        {
            // Validação dos campos
            var checagem = CamposObrigatorios(nomeTurma, descricaoTurma);

            if (checagem)
            {
                InserirTurma();
            }
            else
            {
                await this.DisplayAlert("Campos Obrigatórios",
                    "Preenche os campos obrigatórios para continuar", 
                    "Retornar");
            }

        }

        public bool CamposObrigatorios(string nomeTurma, string descricaoTurma)
        {
            if (nomeTurma != null && descricaoTurma != null)
            {
                return true;
            }
            else
            {
                EtDescricaoTurma.Text = null;
                EtNomeTurma.Text = null;
                return false;
            }

        }

        public async void InserirTurma()
        {
            try
            {
                //Salvamento Banco de Dados Local
                if (_turma.IdPessoa != Guid.Empty)
                {
                    var resultado = await App.TurmaData.InserirTurmaAsync(_turma);

                    //Conferindo se a turma foi inserida
                    if (resultado)
                    {

                        //Inicializo o Firebase
                        _turmaFirebase = new TurmaFirebaseService();

                        //Adicionando a Turma no Firebase
                        await _turmaFirebase.IncluiTurmaAsync(_turma);
                        await DisplayAlert("Sucesso", "Cadastro efetuado com sucesso", "Continuar");

                    }
                    else
                    {
                        await DisplayAlert("Erro", "Ocorreu um erro de criação", "Retornar");
                        await this.Navigation.PopAsync();
                    }

                }


                return;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

        }



    }
}