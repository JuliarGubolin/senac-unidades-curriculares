using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterViewDetail : TabbedPage
    {
        private Usuario _usuario;
        public MasterViewDetail()
        {
            InitializeComponent();
            IniciaUsuario();
            IniciaTabMenu();
        }

        private async void IniciaUsuario()
        {
            _usuario = new Usuario();
            var idUsuario = App.IdUsuario;
            var usuario = await App.UsuarioData.ObtemUsuarioAsync(idUsuario);
            _usuario = usuario;
            BindingContext = _usuario;
        }

        private void IniciaTabMenu()
        {
            //Cria as tabs
            var tabView0 = new HomeView()
            {
                Title = "Passeio",
                IconImageSource = "outline_home_white_36.png"
            };
            var tabView1 = new UsuarioConsultaView()
            {
                Title = "Lista",
                IconImageSource = "person.png"
            };
            var tabViewTurmas = new TurmasMasterView()
            {
                Title = "Turmas",
                IconImageSource = "group.png"
            };

            var tabView3 = new PerfilPessoaView()
            {
                Title = "Perfil",
                IconImageSource = "outline_account_circle_black_24.png"
            };
            //Adiciona as tabas
            Children.Add(tabView0);
            Children.Add(tabView1);
            Children.Add(tabViewTurmas);
            Children.Add(tabView3);
        }
    }
}