using System;
using System.Collections.Generic;
using System.Text;

namespace Unibikers.App.Models
{
    public class Usuario
    {
        //Propriedades        
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }        
        public Perfil Perfil { get; set; }

        //Metodo construtor
        public Usuario()
        {
            //Identificacao
            //IdUsuario = Guid.NewGuid();
            Perfil = Perfil.Membro;

        }
        //Metodo auxiliar para calcular a idade a partir do valor da data de nascimento
        public int ObterIdade()
        {
            var datanasc = this.DataNascimento;
            var data = datanasc.Split('/');
            DateTime hoje = DateTime.Today;

            var dataHoje = hoje.ToString("dd/MM/yyyy").Split('/');

            int anoNasc = int.Parse(data[2]);
            int anoAtual = int.Parse(dataHoje[2]);
           
            int ano = anoAtual - anoNasc;
            if (int.Parse(dataHoje[1]) >= int.Parse(data[1]))
            {
                if (int.Parse(dataHoje[0]) >= int.Parse(data[0]))
                {
                    ano = ano + 1;
                }
            }
            else
            {
                ano = ano - 1;
            }
            return ano;
        }
    }

    public enum Perfil
    {
        Administrador,
        Membro
    }
}
