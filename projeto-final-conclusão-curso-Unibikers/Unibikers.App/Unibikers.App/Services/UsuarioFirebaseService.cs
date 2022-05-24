using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unibikers.App.Models;
using Firebase.Database.Query;

namespace Unibikers.App.Services
{
    public class UsuarioFirebaseService : FirebaseService
    {
        public async Task IncluiUsuarioAsync(Usuario usuario)
        {
            await firebaseDatabase
              .Child("Usuarios")
              .PostAsync(usuario);
        }

        public async Task AlteraUsuarioAsync(Usuario usuario)
        {
            var usuarioFirebase = (await firebaseDatabase
                       .Child("Usuarios")
                       .OnceAsync<Usuario>())
                       .Where(a => a.Object.IdUsuario == usuario.IdUsuario)
                       .FirstOrDefault();
            await firebaseDatabase
              .Child("Usuarios")
              .Child(usuarioFirebase.Key)
              .PutAsync(usuario);

        }

        public async Task ExcluiUsuarioAsync(Guid idUsuario)
        {
            var usuarioFirebase = (await firebaseDatabase
              .Child("Usuarios")
              .OnceAsync<Usuario>())
              .Where(a => a.Object.IdUsuario == idUsuario)
              .FirstOrDefault();
            await firebaseDatabase
                .Child("Usuarios")
                .Child(usuarioFirebase.Key)
                .DeleteAsync();
        }

        public async Task<List<Usuario>> ListaUsuariosAsync()
        {
            return (await firebaseDatabase
              .Child("Usuarios")
              .OnceAsync<Usuario>())
              .Select(item => new Usuario
              {
                  IdUsuario = item.Object.IdUsuario,
                  Nome = item.Object.Nome,
                  DataNascimento = item.Object.DataNascimento,
                  Email = item.Object.Email,
                  Senha = item.Object.Senha,
                  Perfil = item.Object.Perfil                  
              })
              .ToList();
        }

        public async Task<Usuario> ObtemUsuarioAsync(Guid idUsuario)
        {
            var usuarios = await ListaUsuariosAsync();
            await firebaseDatabase
              .Child("Usuarios")
              .OnceAsync<Usuario>();
            return usuarios
                .Where(e => e.IdUsuario == idUsuario)
                .FirstOrDefault();
        }

        public async Task<Usuario> AutenticaUsuarioAsync(string email, string senha)
        {
            var usuarios = await ListaUsuariosAsync();
            await firebaseDatabase
              .Child("Usuarios")
              .OnceAsync<Usuario>();
            return usuarios
                .Where(e => e.Email == email && e.Senha == senha)
                .FirstOrDefault();
        }

        public async Task<bool> ExisteUsuarioAsync(string email)
        {
            var usuarios = await ListaUsuariosAsync();
            await firebaseDatabase
              .Child("Usuarios")
              .OnceAsync<Usuario>();
            var usuario = usuarios
                .Where(e => e.Email == email)
                .FirstOrDefault();
            if (usuario != null)
            {
                return true;
            }
            return false;
        }
    }
}
