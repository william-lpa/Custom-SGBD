using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Semântico.Ações_Semânticas
{
    interface IAction
        {
            void execute(Token token);
        }
    
}
