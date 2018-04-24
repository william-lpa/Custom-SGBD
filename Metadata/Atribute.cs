using SGBD_CP.Metadados.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados
{
    [Serializable]
    public class Atributo
    {
        private string nomeAtributo;
        private int numSeqTabela;
        private int tamanhoAtributoBytes;
        private int precisao;
        private DateTime dataCriacao;
        private Tabela pai;
        private List<Indice> indices;        
        private List<Restricao> restricoes;
        private Tipo tipoAtributo;
        private int ordemInsercao;

        public string ValorString
        {
            get
            {
                if (!this.tipoAtributo.TipoAtb().Equals(typeof(int)))
                {
                    return tipoAtributo.Valor as string ?? "";
                }
                throw new ArgumentException("Tipos incompatíveis");
            }

        }

        public int  ValorInteiro
        {
         get
            {
                if (this.tipoAtributo.TipoAtb().Equals(typeof(int)))
                {
                    return (int)tipoAtributo.Valor;
                }
                throw new ArgumentException("Tipos incompatíveis");
            }
        }

        public Tipo TipoAtributo
        {
            get
            {
                return tipoAtributo;
            }

            set
            {
                tipoAtributo = value;
                if (tipoAtributo.TipoAtb().Equals(typeof(int)))
                {
                    tamanhoAtributoBytes = 4;
                }
                else
                    tamanhoAtributoBytes = tipoAtributo.tamanho() * sizeof(char);
            }
        }

        public string NomeAtributo
        {
            get
            {
                return nomeAtributo;
            }

            set
            {
                nomeAtributo = value;
            }
        }

        public Tabela Pai
        {
            get
            {
                return pai;
            }

            set
            {
                pai = value;
            }
        }

        public int TamanhoAtributoBytes
        {
            get
            {
                return tamanhoAtributoBytes;
            }

            
        }

        public int OrdemInsercao
        {
            get
            {
                return ordemInsercao;
            }

            set
            {
                ordemInsercao = value;
            }
        }

        public string Restricoes()
        {
            string retorno = "";
            bool maisDeUma = false;
            foreach ( var restricao in restricoes)
            {
                if (maisDeUma)
                    retorno += "/";
                retorno += restricao.ToString();

                maisDeUma = true;
            }

            return retorno;
        }

        public void AddRestricao(Restricao r)
        {
            this.restricoes.Add(r);
            
        }

        public Atributo(string nomeAtributo,Tabela pai)
        {
            this.nomeAtributo = nomeAtributo;
            this.dataCriacao = DateTime.Now;
            Pai = pai;
            restricoes = new List<Restricao>();
            this.numSeqTabela = pai.NumeroCampos;
            pai.NumeroCampos++;
            //if (tipo == "char")
            //{
            //    tipoAtributo = new TipoChar(50);
            //}
            
        }

        public Atributo(string nomeAtributo,string tipo, int tamanhoAtributo,Tabela pai) : this(nomeAtributo,pai)
        {
            this.tamanhoAtributoBytes = tamanhoAtributo;
        }

    }
}
