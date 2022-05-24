using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;

namespace Unibikers.App.Services
{
    public class TurmaFirebaseService : FirebaseService
    {

        //Serviço banco de dados FireBase

        //inserir
        public async Task IncluiTurmaAsync(Turma turma)
        {
            try
            {
                await firebaseDatabase.Child("Turmas").PostAsync(turma);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        //Alterar
        public async Task AlteraTurmaAsync(Turma turma)
        {
            //Pegue o objeto (Turma referente ao seu id)
            var turmaFirebase = (await firebaseDatabase.Child("Turmas").OnceAsync<Turma>()).Where(e => e.Object.IdTurma == turma.IdTurma).FirstOrDefault();

            //Espere o banco retornar
            await firebaseDatabase.Child("Turmas").Child(turmaFirebase.Key).PutAsync(turma);
        }

        //Ecluir
        public async Task ExcluiTurmaAsync(Guid idTurma)
        {
            //Pegue o objeto (Turma referente ao seu id)
            var turmaFirebase = (await firebaseDatabase.Child("Turmas").OnceAsync<Turma>()).Where(a => a.Object.IdTurma == idTurma).FirstOrDefault();

            //Espere o banco retornar
            await firebaseDatabase.Child("Turmas").Child(turmaFirebase.Key).DeleteAsync();
        }


        //Listar Turma Sem Filtros
        public async Task<List<Turma>> ListaTurmaAsync()
        {
            //Retorne X objetos em uma lista - Onde Ao selecionar o cada item, preenche seus valores

            try
            {
                //captura a tabela turma do firebase
                var turmas = (await firebaseDatabase
                .Child("Turmas")
                .OnceAsync<Turma>())
                .Select(item => new Turma
                {
                    IdTurma = item.Object.IdTurma,
                    IdPessoa = item.Object.IdPessoa,
                    NomeTurma = item.Object.NomeTurma,
                    DescricaoTurma = item.Object.NomeTurma
                })
                .ToList();

                return turmas;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

        }

        //Obter turmas de um usuario especifico
        //Listar Turma Com filtro
        public async Task<List<Turma>> ListaTurmaAsync(Guid idUsuario)
        {

            try
            {
                //captura a tabela turma do firebase
                var turmas = (await firebaseDatabase
                .Child("Turmas")
                .OnceAsync<Turma>())
                .Select(item => new Turma
                {
                    IdTurma = item.Object.IdTurma,
                    IdPessoa = item.Object.IdPessoa,
                    NomeTurma = item.Object.NomeTurma,
                    DescricaoTurma = item.Object.NomeTurma
                })
                .Where(e => e.IdPessoa == idUsuario)
                .ToList();

                return turmas;              

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

        }

        //Listar Turma Com filtro Contrario
        public async Task<List<Turma>> ListaTurmaExplorarAsync(Guid idUsuario)
        {

            try
            {
                //captura a tabela turma do firebase
                var turmas = (await firebaseDatabase
                .Child("Turmas")
                .OnceAsync<Turma>())
                .Select(item => new Turma
                {
                    IdTurma = item.Object.IdTurma,
                    IdPessoa = item.Object.IdPessoa,
                    NomeTurma = item.Object.NomeTurma,
                    DescricaoTurma = item.Object.NomeTurma
                })
                .Where(e => e.IdPessoa != idUsuario)
                .ToList();

                return turmas;

            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }

        }






        //Obtem uma turma especifica
        public async Task<Turma> ObtemTurmaAsync(Guid idTurma)
        {
            //Armazeno a lista em uma variavel
            var turmas = await ListaTurmaAsync();

            //Retorne do banco de dados o objeto, filtrado via id
            await firebaseDatabase.Child("Turmas").OnceAsync<Turma>();

            return turmas.Where(e => e.IdTurma == idTurma).FirstOrDefault();
        }

        public async Task<Turma> ObtemTurmaEspecificaAsync(Guid idUsuario)
        {
            //Armazeno a lista em uma variavel
            var turmas = await ListaTurmaAsync();

            //Retorne do banco de dados o objeto, filtrado via id
            await firebaseDatabase.Child("Turmas").OnceAsync<Turma>();

            return turmas.Where(e => e.IdPessoa == idUsuario).FirstOrDefault();
        }

    }
}
