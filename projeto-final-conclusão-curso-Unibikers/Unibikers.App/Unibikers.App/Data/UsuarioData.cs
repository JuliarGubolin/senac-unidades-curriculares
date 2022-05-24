using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Unibikers.App.Models;


namespace Unibikers.App.Data
{
    public class UsuarioData
    {
        readonly SQLiteAsyncConnection database;
        public UsuarioData(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Usuario>().
            Wait();
        }
        #region Padrao (CRUD)



        public Task<List<Usuario>> ListaUsuariosAsync()
        {
            //Obtem todos os usuarios da tabela
            return database.Table<Usuario>().ToListAsync();
        }



        public Task<Usuario> ObtemUsuarioAsync(Guid id)
        {
            //Obtem um usuario pelo Id.
            return database.Table<Usuario>()
            .Where(i => i.IdUsuario == id)
            .FirstOrDefaultAsync();
        }
        public async Task<Guid> SalvaUsuarioAsync(Usuario usuario)
        {
            //Verifica se existe um Id do tipo Guid
            if (usuario.IdUsuario != Guid.Empty)
            {
                //Atualiza
                await database.UpdateAsync(usuario);
                return usuario.IdUsuario;
            }
            else
            {
                //Cadastra
                usuario.IdUsuario = Guid.NewGuid();
                await database.InsertAsync(usuario);
                return usuario.IdUsuario;
            }
        }
        #endregion

        #region Especifico (Regras de negocio)

        public async Task<Guid> AutenticaUsuarioAsync(string email, string senha)
        {
            //Obtem um usuario pelo Id.
            var usuario = await database.Table<Usuario>()
            .Where(i => i.Email == email && i.Senha == senha)
            .FirstOrDefaultAsync();
            if (usuario != null)
            {
                return usuario.IdUsuario;
            }
            return Guid.Empty;
        }
        public async Task<bool> ExisteUsuarioAsync(string email)
        {
            //Obtem um usuario pelo Id.
            var usuario = await database.Table<Usuario>()
            .Where(i => i.Email == email)
            .FirstOrDefaultAsync();
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
        #endregion



    }
}