using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relembrando_POO.Domínio
{
    public class Agendamento
    {
        //Propriedades
        private DateTime Data { get; set; }
        public TimeSpan Horario { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        //public bool Concluido { get; set; }
        //Método Construtor
        public Agendamento(DateTime data, TimeSpan tempo, Paciente pac, Medico med)
        {
            this.Data = data;
            this.Horario = tempo;
            this.paciente = pac;
            this.medico = med;
        }
        public Agendamento()
        {
            
        }
        //Métodos Auxiliares
        public Paciente CadastraPaciente(string nome, string rg, bool tc, string sus)
        {
            paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Rg = rg;
            paciente.TemConvenio = tc;
            paciente.Sus = sus;
            return paciente;
        }
        public Medico CadastraMedico(string nome, string CRM, string especialidade, bool part, bool sus, bool conv)
        {
            medico = new Medico();
            medico.Nome = nome;
            medico.CRM = CRM;
            medico.Especialidade = especialidade;
            medico.AtendeParticular = part;
            medico.AtendeConvenios = conv;
            medico.AtendeSUS = sus;
            return medico;
        }
        public String infosAgendamento()
        {
            return $"\nAGENDAMENTO\nData: {Data}\nHora: {Horario} ";
        }
    }
}
