using SGBD_CP.Metadados;
using SGBD_CP.Metadados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action15 : IAction
    {
        private static List<IObserverDescribe> observadores = new List<IObserverDescribe>();

        public static void addObservador(IObserverDescribe ob)
        {
            observadores.Add(ob);
        }

        public void notificaObservadores(string []nomes, string []tipos, string []restricoes)
        {
            foreach (var item in observadores)
            {
                item.PreencherDataGridDescribe(nomes,tipos,restricoes);
            }
        }
        public void execute(Token token)
        {
            if (Semantico.GetInstance().DataBase.ExisteTabela(token.Lexeme))
            {
                Tabela t = Semantico.GetInstance().DataBase.RecuperarTabelaPorNome(token.Lexeme);

                var nomes = (from e in t.Atributos select e.NomeAtributo).ToArray();
                var tipo = (from e in t.Atributos select e.TipoAtributo.ToString()).ToArray();
                var restricoes = (from e in t.Atributos select e.Restricoes()).ToArray();
                notificaObservadores(nomes,tipo,restricoes);
            }

            else
                throw new SemanticError("Tabela não encontrada base de dados", token.Position);
        }
    }
}
