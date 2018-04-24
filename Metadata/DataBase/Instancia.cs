using SGBD_CP.Metadados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBD_CP.Serializar;

namespace SGBD_CP.Metadados.Instância_Banco
{
    [Serializable]
   public class Instancia: IObserverSetDataBase, ISerializable
    {
        private string nomeInstancia;
        List<BaseDeDados> bases;
        private static Instancia instanciaBanco;

        public static Instancia GetInstance()
        {
            if (instanciaBanco == null)
            {
                instanciaBanco = new Instancia("localhost");
            }

            return instanciaBanco;
        }

        internal List<BaseDeDados> DataBases
        {
            get
            {
                return bases;
            }

            set
            {
                bases = value;
            }
        }     

        private Instancia(string nomeInstancia)
        {
            this.nomeInstancia = nomeInstancia;
            bases = new List<BaseDeDados>();
        }

        public BaseDeDados addDataBase(string database)
        {
            var _base = new BaseDeDados(database);
            bases.Add(_base);
            return _base;
        }

        public bool ExisteDataBase(string nomeDataBase)
        {
            return bases.Exists(x => x.Nome == nomeDataBase);
        }       

        public void update(BaseDeDados Base)
        {
            var baseAtiva = (from e in DataBases where Base.Equals(Base) select e).First();
            baseAtiva.ConexaoAtiva = true;            
        }

        #region Persistencia
        
        public void deserializar(object dado)
        {

            Instancia reg = dado as Instancia;
            if (reg != null)
            {
                instanciaBanco = reg;
            }
        }

        public string nomeArquivo
        {
            get
            {
                return this.nomeInstancia;
            }
        }

        #endregion
    }
}
