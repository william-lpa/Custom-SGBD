using SGBD_CP.Metadados;
using SGBD_CP.Metadados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action16 : IAction,ISubjectSetDataBase
    {
        private static List<IObserverSetDataBase> observadores= new List<IObserverSetDataBase>();

        public static void addObservador(IObserverSetDataBase ob)
        {
            observadores.Add(ob);
        }

        public void execute(Token token)
        {
            var nomebase = (from e in Semantico.GetInstance().InstanciaBanco.DataBases where token.Lexeme.Equals(e.Nome) select e).FirstOrDefault();

            if (nomebase != null)
            { //base encontrada
                notificaObservadores(nomebase);
            }
            else
            {
                throw new SemanticError("DataBase ainda não foi criada!", token.Position);
            }
        }

        public void notificaObservadores(BaseDeDados nomeBase)
        {
            foreach (var item in observadores)
            {
                item.update(nomeBase);
            }
        }

        public static void removeObservador(IObserverSetDataBase ob)
        {
            observadores.Remove(ob);
        }
    }
}
