using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados
{
    [Serializable]
   public class Restricao
    {
        public string IdRestricao { get; set; }
        public char TipoRestricao { get; set; } //P - Pk / F - FK / N - Not null
        public Tabela Tabela { get; set; }
        public Atributo Atributo { get; set; }
        public Tabela TabelaReferenciada { get; set; }
        public Atributo AtributoReferenciado { get; set; }


        public override string ToString()
        {
            if(TipoRestricao =='F')
                return this.TipoRestricao + $" ({TabelaReferenciada.NomeTabela})";
            return this.TipoRestricao.ToString();
        }
    }
}
