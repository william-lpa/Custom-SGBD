using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action37 : IAction
    {
        public void execute(Token token)
        {
            var atr = Semantico.GetInstance().DataBase.AtributoTemporario;                        
            atr.AddRestricao(Semantico.GetInstance().DataBase.RestricaoTemporaria);

            Semantico.GetInstance().DataBase.AtributoTemporario = Semantico.GetInstance().DataBase.TabelaTemporaria.RecuperarAtributoPorNome(token.Lexeme);
            atr = Semantico.GetInstance().DataBase.AtributoTemporario;
            if (atr != null)// encontrou
            {
                Semantico.GetInstance().DataBase.RestricaoTemporaria.TipoRestricao = 'P'; //primary

                Semantico.GetInstance().DataBase.RestricaoTemporaria.Atributo = atr;
                Semantico.GetInstance().DataBase.RestricaoTemporaria.Tabela = atr.Pai;
            }

            else
                throw new SemanticError("campo informado como chave primária não foi declarada como atributo", token.Position);
            
        }
    }
}
