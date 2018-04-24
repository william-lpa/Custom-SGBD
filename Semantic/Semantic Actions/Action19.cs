using SGBD_CP.Serializar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action19 : IAction
    {
        public void execute(Token token)
        {
            try
            {
                Dado d = new Dado(Semantico.GetInstance().DataBase.TabelaTemporaria);
                d.InsereDado();
            }
            catch (Exception)
            {
                throw;
                
            }
            

            
        }
    }
}
