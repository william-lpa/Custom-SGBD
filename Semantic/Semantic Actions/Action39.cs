using SGBD_CP.Metadados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    public class Action39 : IAction
    {
        public void execute(Token token)
        {
            try
            {
                Semantico.GetInstance().DataBase.TabelaTemporaria = Semantico.GetInstance().DataBase.RecuperarTabelaPorNome(token.Lexeme);
                if (Semantico.GetInstance().DataBase.TabelaTemporaria == null)
                    throw new SemanticError("Tabela não existe nesta base de dados", token.Position);
            }
            catch (NullReferenceException)
            {
                throw new SemanticError("Certifique que existe uma conexão ativa para realizar a transaction com a database", token.Position);
            }
        }
    }
}
