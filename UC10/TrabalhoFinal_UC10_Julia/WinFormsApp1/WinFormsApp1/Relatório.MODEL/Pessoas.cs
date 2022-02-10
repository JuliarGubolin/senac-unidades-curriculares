﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatório.MODEL
{
    public class Pessoas
    {
        #region Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string DataNasc { get; set; }
        #endregion
        #region Constructor Padrão
        public Pessoas()
        {

        }
        #endregion
    }
}
