using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relembrando_POO.Domínio
{
    public class Medico
    {
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public bool AtendeSUS { get; set; }
        public bool AtendeConvenios { get; set; }
        public bool AtendeParticular { get; set; }
        public Medico()
        {
            AtendeSUS = true;
            AtendeConvenios = true;
            AtendeParticular = false;
        }

        public string ExibirDados()
        {
            return $"\nMÉDICO\nNome: {Nome}\nCRM: {CRM}\nEspecialidade: {Especialidade}\nAtendimentos\nSus: {AtendeSUS}\nConvênio" +
                $": {AtendeConvenios}\nParticular: {AtendeParticular}";
        }
    }
    
}
