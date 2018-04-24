using SGBD_CP.Metadados.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Tipos
{
    [Serializable]
    public class TipoInteger : Tipo, ITipo<int>
    {
        private int tamanhoMaximoInt;
        public TipoInteger()
        {
            this.tamanhoMaximoInt = int.MaxValue;
        }

       

     public   int  tamanhoMaximo
        {
            get
            {
               return int.MaxValue;
            }
            set { tamanhoMaximoInt = int.MaxValue; }
        }

       

     public Type Tipo
        {
            get
            {
                return typeof(int);
            }
        }


        public override object Valor
        {
            get { return base.Valor; }
            set
            {
                if ((int)value > int.MaxValue && (int)value<int.MinValue)
                {
                    throw new SemanticError("Valor máximo para esta variável excedido");
                }
                else { base.Valor = value; }
            }
        }

        public  int valorPadrao
        {
            get
            {
                return default(int);
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        #region Base Classe
        public override int tamanho()
        {
          return  this.tamanhoMaximoInt;
        }

        public override Type TipoAtb()
        {
            return Tipo;
        }

        public override string ToString()
        {
            return $"integer";
        }

        public override T ValorPadrao<T>()
        {
            if (typeof(T).Equals(typeof(int)))
                return default(T);
            else
            {
                throw new ArgumentException();
            }
        }
        #endregion

    }
}
