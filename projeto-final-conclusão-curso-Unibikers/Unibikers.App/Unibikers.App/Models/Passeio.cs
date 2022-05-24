using System;
using System.Collections.Generic;
using System.Text;

namespace Unibikers.App.Models
{
    public class Passeio
    {
        public Guid IdPasseio { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdTurma { get; set; }
        public string Partida { get; set; }
        public string Chegada { get; set; }        
        public DateTime DataPasseio { get; set; }
        public TimeSpan HoraPaseeio { get; set; }        
    }
}