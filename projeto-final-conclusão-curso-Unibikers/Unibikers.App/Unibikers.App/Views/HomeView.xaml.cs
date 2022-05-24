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
using Xamarin.Essentials;
using Unibikers.App.Data;
using System.Net.Http;
using Unibikers.App.Views;


namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        private Passeio _passeio;
        PasseioFirebaseService _passeioFirebaseService;
        private Pessoa _pessoa;
        private Turma _turma;
        PessoaFirebaseService _pessoaFirebaseService;
        
        public HomeView()
        {
            InitializeComponent();
            _passeio = new Passeio();
            _pessoa = new Pessoa();
            _turma = new Turma();
            IniciaPessoa();
            //this.BindingContext = _passeio;
        }       

        private async void IniciaPessoa()
        {
            //Busca os dados pessoais
            //_pessoa = await App.PessoaData.ObtemPessoaAsync(App.IdUsuario);
            _pessoaFirebaseService = new PessoaFirebaseService();
            var pessoa = await _pessoaFirebaseService.ObtemPessoaAsync(App.IdUsuario);
            //Verifica se usuário tem cadastro pessoal
            //if (_pessoa == null)
            //{
             //   var lol=0;
                //await this.Navigation.PushAsync(new PessoaCadastroView());
            //}
            if (pessoa == null)
            {
                var lol = 0;
                await this.Navigation.PushAsync(new PessoaCadastroView());
            }
        }
        public enum NavigationMode
        {
            NavigationMode,Biciclying

        }
        public async void btnRota_Clicked(object sender, System.EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                string partida = txtPatrida.Text;
                string chegada = txtChegada.Text;
                await Launcher.OpenAsync(new Uri($"http://maps.google.com/?daddr=" + chegada + "&saddr=" + partida));

            }            
        }

        private async void btnCompPasseio_Clicked(object sender, EventArgs e)
        {

            _passeio.IdUsuario = App.IdUsuario;
            _passeio.IdTurma = App.IdUsuario;
            _passeio.Partida = txtPatrida.Text;
            _passeio.Chegada = txtChegada.Text;
            _passeio.HoraPaseeio = txtHorario.Time;
            _passeio.DataPasseio = txtData.Date;
            var IdPasseio = await App.PasseioData.SalvaPasseioAsync(_passeio);
            EnviaPasseio(_passeio);
            await DisplayAlert("Sucesso!", "O Cadastro de Passeio Comprartilhado com sucesso", "OK");
            TurmasExplorar turmasExplorar = new TurmasExplorar();
            await this.Navigation.PushAsync(turmasExplorar);
        }


        private async void EnviaPasseio(Passeio passeio)
        {                     
            _passeioFirebaseService = new PasseioFirebaseService();
            await _passeioFirebaseService.IncluiPasseioAsync(passeio);
        }
    }
}