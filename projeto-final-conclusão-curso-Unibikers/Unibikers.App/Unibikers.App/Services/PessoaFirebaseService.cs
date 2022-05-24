using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Firebase.Database.Query;

namespace Unibikers.App.Services
{
    public class PessoaFirebaseService : FirebaseService
    {
        public async Task IncluiPessoaAsync(Pessoa pessoa)
        {
            await firebaseDatabase
              .Child("Pessoas")
              .PostAsync(pessoa);
        }

        public async Task AlteraPessoaAsync(Pessoa pessoa)
        {
            var pessoaFirebase = (await firebaseDatabase
              .Child("Pessoas")
              .OnceAsync<Pessoa>())
              .Where(a => a.Object.IdPessoa == pessoa.IdPessoa)
              .FirstOrDefault();
            await firebaseDatabase
              .Child("Pessoas")
              .Child(pessoaFirebase.Key)
              .PutAsync(pessoa);
        }

        public async Task ExcluiPessoaAsync(Guid idPessoa)
        {
            var pessoaFirebase = (await firebaseDatabase
              .Child("Pessoas")
              .OnceAsync<Pessoa>())
              .Where(a => a.Object.IdPessoa == idPessoa)
              .FirstOrDefault();
            await firebaseDatabase
                .Child("Pessoas")
                .Child(pessoaFirebase.Key)
                .DeleteAsync();
        }

        public async Task<List<Pessoa>> ListaPessoasAsync()
        {
            return (await firebaseDatabase
              .Child("Pessoas")
              .OnceAsync<Pessoa>())
              .Select(item => new Pessoa
              {
                  IdPessoa = item.Object.IdPessoa,
                  IdUsuario = item.Object.IdUsuario,
                  Logradouro = item.Object.Logradouro,
                  CEP = item.Object.CEP,
                  Bairro = item.Object.Bairro,
                  Numero = item.Object.Numero,
                  Sexo = item.Object.Sexo
              })
              .ToList();
        }

        public async Task<Pessoa> ObtemPessoaAsync(Guid idUsuario)
        {
            var pessoas = await ListaPessoasAsync();
            await firebaseDatabase
              .Child("Pessoas")
              .OnceAsync<Pessoa>();
            return pessoas
                .Where(e => e.IdUsuario == idUsuario)
                .FirstOrDefault();
        }

        public async Task<bool> ExistePessoaAsync(string logradouro)
        {
            var pessoas = await ListaPessoasAsync();
            await firebaseDatabase
              .Child("Pessoas")
              .OnceAsync<Pessoa>();
            var pessoa = pessoas
                .Where(e => e.Logradouro == logradouro)
                .FirstOrDefault();
            if (pessoa != null)
            {
                return true;
            }
            return false;
        }

        /*public static implicit operator PessoaFirebaseService(PasseioFirebaseService v)
        {
            throw new NotImplementedException();
        }*/
    }
}
