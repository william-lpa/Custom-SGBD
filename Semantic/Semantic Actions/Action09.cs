using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action09 : IAction
    {
        public void execute(Token token)
        {
            var atr = Semantico.GetInstance().DataBase.TabelaReferenciada.RecuperarAtributoPorNome(token.Lexeme);

            if (atr != null)// encontrou
            {
                
                Semantico.GetInstance().DataBase.RestricaoTemporaria.AtributoReferenciado = atr;
                Semantico.GetInstance().DataBase.RestricaoTemporaria.TabelaReferenciada = atr.Pai;
            }

            else
                throw new SemanticError("campo informado como chave primária não foi declarada como atributo", token.Position);
        }
    }
}
