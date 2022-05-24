using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Data;
using Unibikers.App.Models;
using Unibikers.App.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        //Atributos (escopo global da classe)       
        UsuarioFirebaseService _usuarioFirebaseService;

        public LoginView()
        {
            InitializeComponent();
            //Inicializa os recursos

        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var usuarioCadastroView = new UsuarioCadastroView(email);
            this.Navigation.PushAsync(usuarioCadastroView);
        }

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var senha = txtSenha.Text;
            _usuarioFirebaseService = new UsuarioFirebaseService();
            var usuario = await _usuarioFirebaseService.AutenticaUsuarioAsync(email, senha);
            //verificacao login padrao
            if (usuario != null)
            {
                //vai para MasterView()
                App.IdUsuario = usuario.IdUsuario;
                App.Current.MainPage = new MasterView();
            }
            else
            {
                await DisplayAlert("Atenção", "E-mail ou senha inválidos!", "Fechar");
            }
        }        
    }
}