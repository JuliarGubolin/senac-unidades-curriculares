using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Unibikers.App.Models;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Unibikers.App.Data
{
    public class TurmaData
    {
        //Serviço Banco de dados sql server(local)
        readonly SQLiteAsyncConnection _database;

        //Construtor da classe
        public TurmaData(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Turma>().Wait();
        }

        #region CRUD PADRAO

        #region Insert / Update

        public async Task<bool> InserirTurmaAsync(Turma turma)
        {
            try
            {
                if (turma.IdTurma != Guid.Empty)  // Atualiza
                {

                    await _database.UpdateAsync(turma);
                    return true;
                }
                else //Cadastra
                {
                    turma.IdTurma = Guid.NewGuid();
                    await _database.InsertAsync(turma);
                    return true;
                }

            }
            catch (Exception erro)
            {
                Debug.WriteLine(erro.Message);
                 return false;
            }
           

           

        }

        #endregion

        #region Delete

        public Task<int> DeleteTurmaAsync(Turma turma)
        {
            //Exclui turma
            return _database.DeleteAsync(turma);
        }

        #endregion

        #region List

        public Task<List<Turma>> ListTurmaAsync()
        {
            //Obtem todos as turmas da tabela
            return _database.Table<Turma>().ToListAsync();
        }

        #endregion

        #region Buscar Registro

        public Task<Turma> ObtemTurmaAsync(Guid id)
        {
            //Obtem uma Turma pelo Id.
            return _database.Table<Turma>()
                            .Where(e => e.IdTurma == id)
                            .FirstOrDefaultAsync();
        }



        #endregion




        #endregion

    }
}
