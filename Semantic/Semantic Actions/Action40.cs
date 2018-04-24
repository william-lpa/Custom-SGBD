using SGBD_CP.Semântico.Ações_Semânticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action40 : IAction
    {
        private static int ordemInsercao = 1;
        public void execute(Token token)
        {
            Semantico.GetInstance().DataBase.AtributoTemporario = Semantico.GetInstance().DataBase.TabelaTemporaria.RecuperarAtributoPorNome(token.Lexeme);

            if (Semantico.GetInstance().DataBase.AtributoTemporario != null)// encontrou
            {
                Semantico.GetInstance().DataBase.AtributoTemporario.OrdemInsercao = ordemInsercao++;
            }
            else
                throw new SemanticError($"campo {token.Lexeme} informado no insert não foi encontrado na tabela", token.Position);
        }
    }
}
