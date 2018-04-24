using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action08 : IAction
    {
        public void execute(Token token)
        {
            Semantico.GetInstance().DataBase.TabelaReferenciada = Semantico.GetInstance().DataBase.RecuperarTabelaPorNome(token.Lexeme);
            var tab = Semantico.GetInstance().DataBase.TabelaReferenciada;
            if (tab != null) { 
                
                Semantico.GetInstance().DataBase.RestricaoTemporaria.TipoRestricao = 'F'; //Gambi Foreign
            }

            else
                throw new SemanticError("Tabela informa na reestrição não existe nesta base de dados", token.Position);
        }
    }
}
