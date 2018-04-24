using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Tipos
{
    [Serializable]
    public abstract class Tipo
    {
        public Tipo()
        {
        }
            public abstract Type TipoAtb();

            public abstract T ValorPadrao<T>();

            public abstract int tamanho();

            public override abstract string ToString();

            public virtual object Valor { get; set; }

    }
           
    }
    

