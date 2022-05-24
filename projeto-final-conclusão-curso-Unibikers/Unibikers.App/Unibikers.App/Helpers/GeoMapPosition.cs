using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Xamarin.Essentials;




namespace Unibikers.App.Helpers
{
    class GeoMapPosition
    {
        public static async Task<Location> ObterLocalizacaoAsync()
        {
            GeolocationRequest geolocalizacao = new GeolocationRequest(GeolocationAccuracy.Medium);
            Location localizacao = await Geolocation.GetLocationAsync(geolocalizacao);
            return localizacao;
        }

        public static async Task<Location> ObterLocalizacaoValidaAsync()
        {
            Location localizacao = await Geolocation.GetLastKnownLocationAsync();
            return localizacao;
        }

        public static double CalcularDistancia(Location origem, Location destino)
        {
            double kilometros = Location.CalculateDistance(origem, destino, DistanceUnits.Kilometers);
            return kilometros;
        }


    }
    
    class Geocoding 
    {
        private Passeio _passeio;
        public async Task<Location> ObterLocalizacaoPorEnderecoAsync(string endereco)
        {
            _passeio = new Passeio();
            var enderecos = await Geocoding.ObterLocalizacaoAsync(endereco);

            IEnumerable<Location> localizacoes = await Geocoding.ObterLocalizacaoAsync(endereco);
            Location localizacao = localizacoes?.FirstOrDefault();
            return localizacao;
        }

        private static Task<IEnumerable<Location>> ObterLocalizacaoAsync(string endereco)
        {
            throw new NotImplementedException();
        }

        //public static async Task<Placemark> ObterEnderecoPorLocalizacaoAsync(double latitude, double longitude)
        //{
        //    _passeio = new Passeio();
        //    var enderecos = await Geocoding.ObterEnderecoPorLocalizacaoAsync(latitude, longitude);
        //    var endereco = enderecos?.FirstOrDefault();
        //    return endereco;
        //}

       

    }
}
