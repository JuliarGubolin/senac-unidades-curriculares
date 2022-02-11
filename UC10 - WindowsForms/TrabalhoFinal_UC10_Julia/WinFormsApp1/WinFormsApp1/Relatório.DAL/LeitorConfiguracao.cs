using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatório.DAL
{
    public class LeitorConfiguracao
    {
        public string LerConexao()
        {
            string resultado = "";

            //Ler a string de conexão
            resultado = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return resultado;
        }
    }
}
