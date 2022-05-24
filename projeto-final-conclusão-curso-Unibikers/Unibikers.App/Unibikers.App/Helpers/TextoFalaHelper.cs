using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Unibikers.App.Helpers
{
    public static class TextoFalaHelper
    {
        public static async Task FalarTextoAsync(string texto, float volume, float velocidade)
        {
            var localidade = await TextToSpeech.GetLocalesAsync();
            var localidadeAtual = localidade.FirstOrDefault();
            var configuracao = new SpeechOptions()
            {
                Volume = volume,
                Pitch = velocidade,
                Locale = localidadeAtual
            };
            await TextToSpeech.SpeakAsync(texto, configuracao);
        }

        public static async Task FalarTextoPorVirgulaAsync(string texto, float volume, float velocidade)
        {
            var localidade = await TextToSpeech.GetLocalesAsync();
            var localidadeAtual = localidade.FirstOrDefault();
            var configuracao = new SpeechOptions()
            {
                Volume = volume,
                Pitch = velocidade,
                Locale = localidadeAtual
            };
            string[] textos = texto.Split(',');
            foreach (var frase in textos)
            {
                await TextToSpeech.SpeakAsync(frase, configuracao);
            }
        }

    }
}
