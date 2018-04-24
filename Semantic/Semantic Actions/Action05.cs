using SGBD_CP.Metadados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action05 : IAction
    {
        public void execute(Token token)
        {
            if(!Semantico.GetInstance().DataBase.TabelaTemporaria.ExisteColuna(token.Lexeme))
                  Semantico.GetInstance().DataBase.AtributoTemporario = new Atributo
                       (token.Lexeme,Semantico.GetInstance().DataBase.TabelaTemporaria);
            else
                throw new SemanticError("Coluna já foi informada anteriormente", token.Position);
        }
    }
}
