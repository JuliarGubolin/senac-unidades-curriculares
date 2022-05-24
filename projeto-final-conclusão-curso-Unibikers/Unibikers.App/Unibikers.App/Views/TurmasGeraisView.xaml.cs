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
    public partial class TurmasGeraisView : TabbedPage
    {
        public TurmasGeraisView()
        {
            InitializeComponent();
        }

        //Construtor Redirecionado da tela de cadastro
        public TurmasGeraisView(Turma turma)
        {
            InitializeComponent();

            if (turma == null)
            {
                this.DisplayAlert("Erro", "Ocorreu um erro de programa, já estamos resolvendo", "Continuar");
                this.Navigation.PopModalAsync();
            }

            this.BindingContext = turma;

            //Criar Metado para listar usuarios cadastrado a esta turma!!!
            
        }
    }
}