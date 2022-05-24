using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TurmasMasterView : ContentPage
    {
        public TurmasMasterView()
        {
            InitializeComponent();
        }

        private async void CriarTurma_Clicked(object sender, EventArgs e)
        {
            bool resposta;
            resposta = await DisplayAlert("Nova Turma", "Deseja-se criar uma nova turma?", "Sim", "Cancelar");

            if (resposta)
            {
                //Pegar o usuario > seu id > passar por parametro para a proxima tela

                var idUsuario = App.IdUsuario;
                TurmasCadastroView turmasCadastroView = new TurmasCadastroView(idUsuario);
                await this.Navigation.PushAsync(turmasCadastroView);

                //Fazer com que apos a pessoa confirmar sua participação, a Turma seja adicionada a categoria "Minhas Turmas"
            }
        }

        private async void BtnMinhasTurmas_Clicked(object sender, EventArgs e)
        {
            var idUsuario = App.IdUsuario;
            TurmasUsuario turmasUsuario = new TurmasUsuario(idUsuario);
            turmasUsuario.Title = "Minhas Turmas";
            await this.Navigation.PushAsync(turmasUsuario);
        }

        private async void BtnExplorarTurmas_Clicked(object sender, EventArgs e)
        {
            TurmasExplorar turmasExplorar = new TurmasExplorar();
            turmasExplorar.Title = "Explorar Turmas";
            await this.Navigation.PushAsync(turmasExplorar);
        }        
    }
}