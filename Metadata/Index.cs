using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados
{
    struct Indice
    {
        public Tabela Tabela { get; set; }
        public Atributo Atributo { get; set; }
        public char tpIndice{ get; set; }
    }
}
