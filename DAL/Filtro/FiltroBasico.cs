using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Filtro
{
    public class FiltroBasico
    {
        public FiltroBasico()
        {

        }

        public String codigo { get; set; }
        public String descricao { get; set; }
        public String dtini { get; set; }
        public String dtfim { get; set; }
        public String ativo { get; set; }
    }
}
