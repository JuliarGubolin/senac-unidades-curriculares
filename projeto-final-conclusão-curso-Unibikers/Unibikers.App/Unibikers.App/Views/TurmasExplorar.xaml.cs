using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class TurmasExplorar : ContentPage
    {
        public TurmasExplorar()
        {
            InitializeComponent();
            //Inicializa a lista            
            _listaTurmas = new ObservableCollection<Turma>();
        }
                

        //Lista com os dados que irao sofrer atualizacao com o uso do aplicativo
        ObservableCollection<Turma> _listaTurmas;       

        public async void AtualizarListaTurmas()
        {
            try
            {
                //EVENTO
                aiCarregando.IsRunning = true;
                lvTurmas.IsRefreshing = true;

                //Capturo o id do usuario
                var idUsuario = App.IdUsuario;

                //Conecta no firebase e na tabela de turma
                TurmaFirebaseService turmaFirebase = new TurmaFirebaseService();

                //Busco a turma passando o id do usuario via parametro para consulta
                var turmasUsuario = await turmaFirebase.ListaTurmaExplorarAsync(idUsuario);

                //Verifica se encontrou a turma
                if (turmasUsuario != null)
                {
                    //Preenche a lista dinamica ObservableCollection
                    foreach (var item in turmasUsuario)
                    {
                        _listaTurmas.Add(item);
                    }

                    //Preenche os dados da ListView
                    lvTurmas.ItemsSource = _listaTurmas;

                    //Desabelite os eventos
                    aiCarregando.IsRunning = false;
                    lvTurmas.IsRefreshing = false;

                }                             

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Atualiza a lista de turmas do usuario
            AtualizarListaTurmas();
        }

        private void lvTurmas_Refreshing(object sender, EventArgs e)
        {
            AtualizarListaTurmas();
        }

        private void lvTurmas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            this.DisplayAlert(
                "Participar de uma Nova Turma",
                "Vejamos, parece que você se intessou em uma nova turma, que ótimo!!",
                "Participar",
                "Retornar");

            //Adicionar a nova tabela de relacionamento
            
        }
    }
}