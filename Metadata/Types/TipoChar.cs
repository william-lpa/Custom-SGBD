using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Tipos
{
    [Serializable]
    class TipoChar:Tipo, ITipo<string>
    {
        private int tamanhoMaximoString;

        public TipoChar(int numCaracteres)
        {
            if(numCaracteres<51)
            this.tamanhoMaximo = numCaracteres;
            else
            {
                throw new SemanticError("Numero máximo de caracterese para esta variável excedido");
            }
        }
        public int tamanhoMaximo
        {
            get
            {
                return this.tamanhoMaximoString;
            }

            set
            {
                this.tamanhoMaximoString = value;
            }
        }

        public Type Tipo
        {
            get
            {
                return typeof(string);
            }
        }

        public string valorPadrao
        {
            get
            {
                return default(string);
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        #region Classe Base
        public override int tamanho()
        {
            return tamanhoMaximo;
        }

        public override object Valor
        { get { return base.Valor; }
            set {if (value.ToString().Length > 51)
                {
                    throw new SemanticError("Numero máximo de caracterese para esta variável excedido");
                }
                else { base.Valor = value; }
                    }
        }

        public override Type TipoAtb()
        {
            return Tipo;
        }

        public override string ToString()
        {
            return $"char({tamanho()})";
        }

        public override T ValorPadrao<T>()
        {
            if (typeof(T).Equals(typeof(string)))
                return default(T);
            else
            {
                throw new  ArgumentException();
            }
        }
        #endregion
    }
}
