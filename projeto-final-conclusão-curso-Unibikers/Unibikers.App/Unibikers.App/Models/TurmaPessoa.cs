using System;
using System.Collections.Generic;
using System.Text;

namespace Unibikers.App.Models
{
    public class TurmaPessoa
    {
        //Tabela de Relacionamento referente a tabela Turma com Pessoa ( N -> N)

        //Id da Turma
        public Guid IdTurma { get; set; }
        //Id Do Usuario Criador da Turma
        public Guid IdUsuario { get; set; }
        //Delegação do usuario
        public TipoUsuario tipoUsuario { get; set; }


        //Construtores

        public enum TipoUsuario
        {
           Membro,
           Administrador
        }

        public TurmaPessoa()
        {
            tipoUsuario = TipoUsuario.Membro;
        }
            
    }
       
}
