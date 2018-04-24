using SGBD_CP.Metadados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action36: IAction, ISubjectNewTable
    {
        private static List<IObserverNewTable> observadores = new List<IObserverNewTable>();
    
        public void execute(Token token)
        {
            Semantico.GetInstance().DataBase.AddTabela(Semantico.GetInstance().DataBase.TabelaTemporaria);
        }

        public void notificaObservadores(string Base)
        {
            foreach (var item in observadores)
            {
                item.update(Base);
            }
        }

        public static void removeObservador(IObserverNewTable ob)
        {
            observadores.Remove(ob);
        }
        public static void addObservador(IObserverNewTable ob)
        {
            observadores.Add(ob);
        }
    }
}
