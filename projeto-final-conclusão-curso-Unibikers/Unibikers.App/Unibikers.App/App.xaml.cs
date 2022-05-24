using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Unibikers.App.Views;
using Unibikers.App.Data;
using System.IO;

namespace Unibikers.App
{
    public partial class App : Application
    {
        //Usuario autenticado
        public static Guid IdUsuario { get; set; }

        //Configuracao do Banco de Dados SQLite
        //Tabela Usuarios
        static UsuarioData usuarioData;
        static PessoaData pessoaData;
        //internal static object IdPasseio;
        static TurmaData turmaData;
        static PasseioData passeioData;

        public static UsuarioData UsuarioData
        {
            get
            {
                if (usuarioData == null)
                {
                    usuarioData = new UsuarioData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UnibikesBD.db3"));
                }
                return usuarioData;
            }
        }
        public static TurmaData TurmaData
        {
            get
            {
                if (turmaData == null)
                {
                    turmaData = new TurmaData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UnibikesBD.db3"));
                }
                return turmaData;
            }
        }







        //Não sei se é assim mas é isso ai :)
        public static PessoaData PessoaData
        {
            get
            {
                if (pessoaData == null)
                {
                    pessoaData = new PessoaData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UnibikesBD.db3"));
                }
                return pessoaData;
            }
        }

        public static PasseioData PasseioData
        {
            get
            {
                if (passeioData == null)
                {
                    passeioData = new PasseioData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UnibikesBD.db3"));
                }
                return passeioData;
            }
        }
        

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new LoginView());
            //MainPage = new MasterView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
