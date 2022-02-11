using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relembrando_POO.Domínio
{
    public class Paciente
    {
        //Atributo
        string nome;
        //Propriedade
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get; set; }
        public bool TemConvenio { get; set; }
        public string Convenio { get; set; }
        public string NumConvenio { get; set; }
        public string Sus { get; set; }

        //Método construtor
        public Paciente()
        {
            TemConvenio = false;
        }

        //Métodos auxiliares
        public void CadastrarConvenio(string planoSaude, string numeroCarteirinha)
        {
            Convenio = planoSaude;
            NumConvenio = numeroCarteirinha;
        }

        public string ExibirDados(){
            if (TemConvenio)
            {
                return $"\nNome do convênio: {Convenio}\nNúmero do convênio: {NumConvenio}.";
            }
            else
            {
                return $"\nSUS: {Sus}.";
            }
            
        }
    }
}
