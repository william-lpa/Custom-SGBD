using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados
{
    [Serializable]
    public class Tabela
    {
        private string nomeTabela;
        private DateTime dataCriacao;
        private List<Atributo> atributos;
        public string NomeBase { get; set; }
        public int NumeroCampos { get; set; }

        public string NomeTabela
        {
            get
            {
                return nomeTabela;
            }

            set
            {
                nomeTabela = value;
            }
        }

        public DateTime DataCriacao
        {
            get
            {
                return dataCriacao;
            }

            set
            {
                dataCriacao = value;
            }
        }

        public List<Atributo> Atributos
        {
            get
            {
                return atributos;
            }

            set
            {
                atributos = value;
            }
        }

        public Atributo RecuperarAtributoPorNome(string nome)
        {
            return this.atributos.Find(atr => atr.NomeAtributo == nome);
        }

        public Atributo RecuperarAtributoOrdemInsercao(int ordem)
        {
            return this.atributos.Find(atr => atr.OrdemInsercao == ordem);
        }

        public void AddAtributo(Atributo atributo)
        {
            this.atributos.Add(atributo);
        }
        public Atributo UltimoAtributoAdicionado()
        {
            return this.atributos.Last<Atributo>();
        }
        public Tabela(string nomeTabela, string nomeBase)
        {
            this.nomeTabela = nomeTabela;
            this.dataCriacao = DateTime.Now;
            atributos = new List<Atributo>();
            this.NomeBase = nomeBase;

        }

        public bool ExisteColuna(string nomeColuna)
        {
            return atributos.Exists(x => x.NomeAtributo == nomeColuna);
        }
    }
}
