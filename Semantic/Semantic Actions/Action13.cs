using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action13 : IAction
    {
        public void execute(Token token)
        {
            if (Semantico.GetInstance().DataBase.ExisteTabela(token.Lexeme))
                Semantico.GetInstance().DataBase.RemoveTabela(token.Lexeme);
            else
                throw new SemanticError("Tabela informada não existe nesta base de dados", token.Position);
        }
    }
}
