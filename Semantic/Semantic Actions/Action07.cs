using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action07 : IAction
    {
        public void execute(Token token)
        {
            Semantico.GetInstance().DataBase.AtributoTemporario = Semantico.GetInstance().DataBase.TabelaTemporaria.RecuperarAtributoPorNome(token.Lexeme);
            var atr = Semantico.GetInstance().DataBase.AtributoTemporario;
            if (atr != null)// encontrou
            {
                Semantico.GetInstance().DataBase.RestricaoTemporaria.TipoRestricao ='P'; //primary

                Semantico.GetInstance().DataBase.RestricaoTemporaria.Atributo = atr;
                Semantico.GetInstance().DataBase.RestricaoTemporaria.Tabela= atr.Pai;
            }

            else
                throw new SemanticError("campo informado na restrição não foi declarada como atributo", token.Position);
        }
    }
}
