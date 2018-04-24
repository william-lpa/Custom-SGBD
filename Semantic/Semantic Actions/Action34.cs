using SGBD_CP.Metadados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action34 : IAction
    {
        public void execute(Token token)
        {
            //var atr = Semantico.GetInstance().DataBase.TabelaTemporaria.UltimoAtributoAdicionado();
            
            Semantico.GetInstance().DataBase.RestricaoTemporaria = new Restricao();
        }
    }
}
