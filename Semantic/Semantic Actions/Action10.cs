﻿using SGBD_CP.Metadados.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    class Action10 : IAction
    {
        public void execute(Token token)
        {
            Semantico.GetInstance().DataBase.AtributoTemporario.TipoAtributo = new TipoInteger();
            var atr = Semantico.GetInstance().DataBase.AtributoTemporario;
            Semantico.GetInstance().DataBase.TabelaTemporaria.AddAtributo(atr);
            Semantico.GetInstance().DataBase.AtributoTemporario=null;
        }
    }
}
