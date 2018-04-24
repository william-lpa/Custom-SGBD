using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action38 : IAction
    {
        public void execute(Token token)
        {
            var atr = Semantico.GetInstance().DataBase.AtributoTemporario;
            atr.AddRestricao(Semantico.GetInstance().DataBase.RestricaoTemporaria);
        }
    }
}
