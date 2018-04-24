using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Tipos
{
    [Serializable]
    class TipoString : Tipo, ITipo<string>
    {
        private int tamanhoMaximoString;

        public TipoString(int numCaracteres)
        {
            if (numCaracteres < 256)
                this.tamanhoMaximo = numCaracteres;
            else
                throw new SemanticError("Numero máximo de caracterese para esta variável excedido");
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

        #region Base Classe
        public override int tamanho()
        {
            return this.tamanhoMaximo;
        }

        public override Type TipoAtb()
        {
            return Tipo;
        }

        public override object Valor
        {
            get { return base.Valor; }
            set
            {
                if (value.ToString().Length > 256)
                {
                    throw new SemanticError("Numero máximo de caracterese para esta variável excedido");
                }
                else { base.Valor = value; }
            }
        }

        public override string ToString()
        {
            return $"varchar({tamanho()})";
        }

        public override T ValorPadrao<T>()
        {
            if (typeof(T).Equals(typeof(string)))
                return default(T);
            else
            {
                throw new ArgumentException();
            }
        }
        #endregion  
    }
}
