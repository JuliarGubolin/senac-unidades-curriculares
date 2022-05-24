using System;
using System.Collections.Generic;
using System.Text;

namespace Unibikers.App.Models
{
    public class Pessoa
    {
        //Propriedades
        public Guid IdPessoa { get; set; }
        public Guid IdUsuario { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Sexo { get; set; }
    }
}
