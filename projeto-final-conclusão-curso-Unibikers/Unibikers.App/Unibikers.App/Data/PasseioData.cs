using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Unibikers.App.Models;
using Xamarin.Essentials;

namespace Unibikers.App.Data
{
    public class PasseioData
    {
        readonly SQLiteAsyncConnection database;

        public PasseioData(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Passeio>().
                Wait();
        }

        #region Padrao (CRUD)

        public Task<List<Passeio>> ListaPasseioAsync()
        {
            //Obtem todos os usuarios da tabela
            return database.Table<Passeio>().ToListAsync();
        }

        public Task<Passeio> ObtemPasseioAsync(Guid id)
        {
            //Obtem um usuario pelo Id.
            return database.Table<Passeio>()
                            .Where(i => i.IdPasseio == id)
                            .FirstOrDefaultAsync();
        }

        public async Task<Guid> SalvaPasseioAsync(Passeio passeio)
        {
            //Verifica se existe um Id do tipo Guid
            if (passeio.IdPasseio != Guid.Empty)
            {
                //Atualiza
                await database.UpdateAsync(passeio);
                return passeio.IdPasseio;
            }
            else
            {
                //Cadastra
                passeio.IdPasseio = Guid.NewGuid();
                await database.InsertAsync(passeio);
                return passeio.IdPasseio;
            }

        }

        public Task<int> ExcluiPasseioAsync(Passeio passeio)
        {
            //Exclui usuario
            return database.DeleteAsync(passeio);
        }

        #endregion

        
    }


}
