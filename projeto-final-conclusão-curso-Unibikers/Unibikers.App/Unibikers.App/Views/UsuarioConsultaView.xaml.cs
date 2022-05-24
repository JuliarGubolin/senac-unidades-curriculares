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
    public partial class UsuarioConsultaView : ContentPage
    {

        //Lista com os dados que irao sofrer atualizacao com o uso do aplicativo
        ObservableCollection<Usuario> _listaUsuarios;

        public UsuarioConsultaView()
        {
            InitializeComponent();
            //Inicializa a lista
            _listaUsuarios = new ObservableCollection<Usuario>();
        }

        public async void AtualizaListaUsuariosAsync()
        {
            aiCarregando.IsRunning = true;
            lvUsuarios.IsRefreshing = true;
            //Conecta no Firebase e na tabela dos usuarios
            UsuarioFirebaseService usuarioFirebaseService = new UsuarioFirebaseService();
            //Busca todos os usuarios
            var usuarios = await usuarioFirebaseService.ListaUsuariosAsync();
          
            //Preencher a lista dinamica ObservableCollection
            //Vai ler a lista usuarios e adiciona cada usuario na lista dinamica ObservableCollection 
            foreach (var usuario in usuarios)
            {
                _listaUsuarios.Add(usuario);
            }
            //Preenche os dados na listview
            lvUsuarios.ItemsSource = _listaUsuarios;
            aiCarregando.IsRunning = false;
            lvUsuarios.IsRefreshing = false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Atualiza a lista de usuários
            AtualizaListaUsuariosAsync();
        }

        private void btnAtualizar_Clicked(object sender, EventArgs e)
        {
            //Atualiza a lista de usuários
            AtualizaListaUsuariosAsync();
        }

        private void lvUsuarios_Refreshing(object sender, EventArgs e)
        {
            //Atualiza a lista de usuários
            AtualizaListaUsuariosAsync();
        }

        private void Excluir_Clicked(object sender, EventArgs e)
        {
            MenuItem menuitem = sender as MenuItem;
            var id = menuitem.CommandParameter.ToString();
            var idUsuario = Guid.Parse(id);
            DisplayAlert("Atenção", $"O IdUsuario é {id}", "Fechar");
        }

        private void lvUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var usuario = e.SelectedItem as Usuario;
            DisplayAlert("Atenção", $"O IdUsuario é {usuario.IdUsuario.ToString()}", "Fechar");
        }

        private void lvUsuarios_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var usuario = e.Item as Usuario;
            DisplayAlert("Atenção", $"O IdUsuario é {usuario.IdUsuario.ToString()}", "Fechar");
            this.Navigation.PushAsync(new UsuarioWebpageView(usuario.IdUsuario));
        }
    }
}