using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados
{
    [Serializable]
    public class BaseDeDados
    {
        private string nome;
        private DateTime dataCriacao;
        private List<Tabela> tabelas; // nome, tabela
        public Tabela TabelaTemporaria { get; set; }

        


        internal void RemoveTabela(string nomeTabela)
        {
            Tabela T = RecuperarTabelaPorNome(nomeTabela);
            tabelas.Remove(T);
        }

        public Tabela TabelaReferenciada { get; set; }
        public Atributo AtributoTemporario { get; set; }
        public Restricao RestricaoTemporaria { get; set; }
        private ulong tamanhoBase;
        private bool conexaoAtiva;
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
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

        public Tabela RecuperarTabelaPorNome(string nome)
        {
            return this.tabelas.Find(tab => tab.NomeTabela == nome);
        }

        //internal List<Tabela> Tabelas
        //{
        //    get
        //    {
        //        return tabelas;
        //    }

        //    set
        //    {
        //        tabelas = value;
        //    }
        //}

        public ulong TamanhoBase
        {
            get
            {
                return tamanhoBase;
            }

            set
            {
                tamanhoBase = value;
            }
        }

        public bool ConexaoAtiva
        {
            get
            {
                return conexaoAtiva;
            }

            set
            {
                conexaoAtiva = value;
            }
        }

        public BaseDeDados(string nome)
        {
            this.Nome = nome;
            this.DataCriacao = DateTime.Now;
            tabelas = new List<Tabela>();

        }
      

        public void AddTabela(Tabela t)
        {
            this.tabelas.Add(t);
        }
        public bool ExisteTabela(string nomeTabela)
        {
            return tabelas.Exists(x => x.NomeTabela == nomeTabela);
        }

        public override string ToString()
        {
            return nome + "-" + DataCriacao.ToString("dd/MM/yyyy hh:mm:ss"); //+ (conexaoAtiva ? " Ativa" : "");
        }

    }
}
