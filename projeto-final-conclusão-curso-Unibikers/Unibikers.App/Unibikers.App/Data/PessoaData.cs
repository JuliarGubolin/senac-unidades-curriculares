using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Unibikers.App.Models;

namespace Unibikers.App.Data
{
    public class PessoaData
    {
        readonly SQLiteAsyncConnection database;

        public PessoaData(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Pessoa>().
                Wait();
        }

        #region Padrao (CRUD)

        public Task<List<Pessoa>> ListaPessoaAsync()
        {
            return database.Table<Pessoa>().ToListAsync();
        }

        public Task<Pessoa> ObtemPessoaAsync(Guid id)
        {
            return database.Table<Pessoa>()
                            .Where(i => i.IdUsuario == id)
                            .FirstOrDefaultAsync();
        }

        public async Task<Guid> SalvaPessoaAsync(Pessoa pessoa)
        {
            var id = pessoa.IdPessoa;
            //Verifica se existe um Id do tipo Guid
            if (pessoa.IdPessoa != Guid.Empty)
            {
                //Atualiza
                await database.UpdateAsync(pessoa);
                return pessoa.IdPessoa;
            }
            else
            {
                //Cadastra
                pessoa.IdPessoa = Guid.NewGuid();
                await database.InsertAsync(pessoa);
                return pessoa.IdPessoa;
            }

        }

        #endregion

    }
}
