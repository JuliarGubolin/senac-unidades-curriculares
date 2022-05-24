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
    public partial class PerfilPessoaView : ContentPage
    {
        private Usuario _usuario;
        //PessoaFirebaseService _pessoaFirebaseService;
        public PerfilPessoaView()
        {
            InitializeComponent();
            IniciaUsuario();
        }
        private async void IniciaUsuario()
        {
            _usuario = new Usuario();
            var idUsuario = App.IdUsuario;
            var usuario = await App.UsuarioData.ObtemUsuarioAsync(idUsuario);
            _usuario = usuario;
            var idade = _usuario.ObterIdade();
            //var datan = _usuario.DataNascimento.ToShortDateString();
            txtIdade.Text = _usuario.DataNascimento;
            lblIdade.Text = idade.ToString() + " anos";
            BindingContext = _usuario;
        }

        private async void btnEditarPessoa_Clicked(object sender, EventArgs e)
        {
            //Verifica se usuário tem cadastro pessoal
            var pessoa = await App.PessoaData.ObtemPessoaAsync(App.IdUsuario);
            //_pessoaFirebaseService = new PessoaFirebaseService();
            //var pessoa = _pessoaFirebaseService.ObtemPessoaAsync(App.IdUsuario);

            if (pessoa != null)
            {
                await DisplayAlert("Atenção", "Você já inseriu um endereço!", "OK");
            }
            else
            {
                await this.Navigation.PushAsync(new PessoaCadastroView());
            }
            
        }
    }
}