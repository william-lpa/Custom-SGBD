using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action20 : IAction
    {
        private static int ordemInsercao = 1;
        private enum Tipos { Integer = 3 , CharString=4, Null=37 };
        public void execute(Token token)
        {
            try
            {
                var atributo = Semantico.GetInstance().DataBase.TabelaTemporaria.RecuperarAtributoOrdemInsercao(ordemInsercao);

                if (Semantico.GetInstance().DataBase.AtributoTemporario != null)// encontrou
                {
                    Tipos tipo = (Tipos)token.Id;

                    switch (tipo)
                    {
                        case Tipos.Integer:
                            if (atributo.TipoAtributo.TipoAtb().Equals(typeof(int)))
                                {
                                    atributo.TipoAtributo.Valor = token.Lexeme;
                                   break;
                                }
                            goto default;
                        case Tipos.CharString:
                                if (atributo.TipoAtributo.TipoAtb().Equals(typeof(string)))
                                {
                                    atributo.TipoAtributo.Valor = token.Lexeme.Replace("'","");
                                    break;
                                }
                            goto default;
                        case Tipos.Null:
                            break;
                        default:
                            throw new SemanticError($"o valor {token.Lexeme} possui inconsistências de atribuição de tipo", token.Position);
                     }
                    ordemInsercao++;                    
                }
                else
                    throw new SemanticError($"o valor {token.Lexeme} informado no insert não possui campo correspondente informado anteriormente", token.Position);
            }
            catch (InvalidCastException)
            {
                throw new SemanticError($"o valor {token.Lexeme} informado no insert não foi identificado como um valor válido de atribuição", token.Position);
            }

        }
    }
}
