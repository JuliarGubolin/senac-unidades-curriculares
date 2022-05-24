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
    public partial class UsuarioCadastroView : ContentPage
    {
        //private string _email;
        private Usuario _usuario;
        UsuarioFirebaseService _usuarioFirebaseService;


        //Metodo construtor
        //Inicializacao
        public UsuarioCadastroView(string email)
        {
            InitializeComponent();
            //CarregarDados(email);
            //Inicializa o objeto
            _usuario = new Usuario();
            _usuario.Email = email;
            this.BindingContext = _usuario;
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {

            //Voltar para a primeira pagina de navegacao
            //this.Navigation.PopToRootAsync();
            var usuarios = await App.UsuarioData.ListaUsuariosAsync();
            foreach (var usuario in usuarios)
            {
                _usuario = usuario;
            }

            //Voltar para a pagina anterior
            await this.Navigation.PopAsync();

        }

        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {
            if(txtSenha.Text == txtSenhaConfirma.Text)
            {
                //Salva o usuario no banco de dados
                _usuario.DataNascimento = txtDataNascimento.Text;
                var idUsuario = await App.UsuarioData.SalvaUsuarioAsync(_usuario);
                EnviaUsuario(_usuario);
                //Faz o login do usuario
                App.IdUsuario = idUsuario;
                App.Current.MainPage = new MasterView();
            }
            else
            {
                await DisplayAlert("Atenção", "Senhas não são iguais!", "OK");
            }
            
        }

        private async void EnviaUsuario(Usuario usuario)
        {
            _usuarioFirebaseService = new UsuarioFirebaseService();
            await _usuarioFirebaseService.IncluiUsuarioAsync(usuario);
        }

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    if (_usuario != null)
        //    {
        //        EnviaUsuario(_usuario);
        //    }
        //}
    }
}