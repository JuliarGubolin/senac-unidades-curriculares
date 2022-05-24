using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Unibikers.App.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterViewMenu : ContentPage
    {
        //Atributos
        private Usuario _usuario;
        UsuarioFirebaseService _usuarioFirebaseService;

        public MasterViewMenu()
        {
            InitializeComponent();
            AtivaUsuario();            
        }

        private async void AtivaUsuario()
        {
            _usuario = new Usuario();
            var idUsuario = App.IdUsuario;
            var usuario = await App.UsuarioData.ObtemUsuarioAsync(idUsuario);

            _usuario = usuario;
            BindingContext = _usuario;
        }

        private async void EnviaUsuario(Usuario usuario)
        {
            _usuarioFirebaseService = new UsuarioFirebaseService();
            await _usuarioFirebaseService.AlteraUsuarioAsync(usuario);
        }

        //Aparecendo
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (_usuario != null)
            {
                EnviaUsuario(_usuario);
            }
      
        }

        //Desaparecendo
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

       
    }
}