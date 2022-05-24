using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Unibikers.App.Helpers;

namespace Unibikers.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioWebpageView : ContentPage
    {
        public UsuarioWebpageView(Guid idUsuario)
        {          
            InitializeComponent();
            string url = $"https://www.google.com.br/{idUsuario}";
            wvPagina.Source = url;
            FalaUrlAsync(url);
        }

        private async void FalaUrlAsync(string url)
        {
            await TextoFalaHelper.FalarTextoAsync(url, 1.0f, 1.0f);
        }
    }
}