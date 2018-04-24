using SGBD_CP.Metadados;
using SGBD_CP.Metadados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action02 : IAction { 
        public void execute(Token token)
        {
            try
            {
                if (!Semantico.GetInstance().DataBase.ExisteTabela(token.Lexeme))
                    Semantico.GetInstance().DataBase.TabelaTemporaria = new Tabela(token.Lexeme, Semantico.GetInstance().DataBase.Nome);
                else
                    throw new SemanticError("Tabela já existe nesta base de dados", token.Position);
            }
            catch (NullReferenceException)
            {
                throw new SemanticError("Certifique que existe uma conexão ativa para realizar a transaction com a database", token.Position);
            }
        }

      
    }
}
