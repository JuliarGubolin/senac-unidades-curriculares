using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Firebase.Database.Query;

namespace Unibikers.App.Services
{

    public class PasseioFirebaseService : FirebaseService
    {
        public async Task IncluiPasseioAsync(Passeio Passeio)
        {
            await firebaseDatabase
                  .Child("Passeios")
                  .PostAsync(Passeio);
        }

        public async Task AlteraPasseioAsync(Passeio Passeio)
        {
            var PasseioFirebase = (await firebaseDatabase
                  .Child("Passeios")
                  .OnceAsync<Passeio>())
                  .Where(a => a.Object.IdPasseio == Passeio.IdPasseio)
                  .FirstOrDefault();
            await firebaseDatabase
                  .Child("Passeios")
                  .Child(PasseioFirebase.Key)
                  .PutAsync(Passeio);
        }

        public async Task ExcluiPasseioAsync(Guid idPasseio)
        {
            var PasseioFirebase = (await firebaseDatabase
                  .Child("Passeios")
                  .OnceAsync<Passeio>())
                  .Where(a => a.Object.IdPasseio == idPasseio)
                  .FirstOrDefault();
            await firebaseDatabase
                    .Child("Passeios")
                    .Child(PasseioFirebase.Key)
                    .DeleteAsync();
        }

        public async Task<List<Passeio>> ListaPasseiosAsync()
        {
            return (await firebaseDatabase
                  .Child("Passeios")
                  .OnceAsync<Passeio>())
                  .Select(item => new Passeio
                  {
                      IdPasseio = item.Object.IdPasseio,
                      Partida = item.Object.Partida,
                      Chegada = item.Object.Chegada,
                      DataPasseio = item.Object.DataPasseio,
                      HoraPaseeio = item.Object.HoraPaseeio
                  })
                  .ToList();
        }

        public async Task<Passeio> ObtemPasseioAsync(Guid IdPasseio)
        {
            var Passeios = await ListaPasseiosAsync();
            await firebaseDatabase
                  .Child("Passeios")
                  .OnceAsync<Passeio>();
            return Passeios
                    .Where(e => e.IdPasseio == IdPasseio)
                    .FirstOrDefault();
        }

        public async Task<bool> ExistePasseioAsync(Guid passeio)
        {
            var Passeios = await ListaPasseiosAsync();
            await firebaseDatabase
                  .Child("Passeios")
                  .OnceAsync<Passeio>();
            var Passeio = Passeios
                    .Where(e => e.IdPasseio == passeio)
                    .FirstOrDefault();
            if (Passeio != null)
            {
                return true;
            }
            return false;
        }
    }

}
