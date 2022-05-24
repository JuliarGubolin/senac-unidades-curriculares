using System;
using System.Collections.Generic;
using System.Text;

namespace Unibikers.App.Models
{
    public class Turma
    {
        //Tabela Turma

        //ID
        public Guid IdTurma { get; set; }

        //ID do criador da turma
        public Guid IdPessoa { get; set; }

        //Nome
        public string NomeTurma { get; set; }
        //Descricao
        public string DescricaoTurma { get; set; }
       
    }
}
