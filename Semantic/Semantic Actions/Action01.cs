using SGBD_CP.Metadados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGBD_CP.Metadados;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    
    class Action01:IAction, ISubjectNewDataBase
    {
        private static List<IObserverNewDataBase> observadores = new List<IObserverNewDataBase>();
        public void execute(Token token)
        {
            if (!Semantico.GetInstance().InstanciaBanco.ExisteDataBase(token.Lexeme))
            {
                notificaObservadores(token.Lexeme);
                
            }
            else
            {
                throw new SemanticError("DataBase ja existe nesta intância do banco", token.Position);
            }
        }

        public static void removeObservador(IObserverNewDataBase ob)
        {
            observadores.Remove(ob);
        }
        public static void addObservador(IObserverNewDataBase ob)
        {
            observadores.Add(ob);
        }

        public void notificaObservadores(string Base)
        {
            foreach (var item in observadores)
            {
                item.update(Base);
            }
        }
    }
}
