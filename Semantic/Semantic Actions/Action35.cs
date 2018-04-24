using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action35 : IAction
    {
        public void execute(Token token)
        {
            var atr = Semantico.GetInstance().DataBase.TabelaTemporaria.UltimoAtributoAdicionado();
            Semantico.GetInstance().DataBase.RestricaoTemporaria.TipoRestricao = 'N';
            Semantico.GetInstance().DataBase.RestricaoTemporaria.Atributo = atr;
            Semantico.GetInstance().DataBase.RestricaoTemporaria.Tabela = atr.Pai;
            atr.AddRestricao(Semantico.GetInstance().DataBase.RestricaoTemporaria);
        }
    }
}
