using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Interfaces
{
    interface IObserverDescribe
    {
        void PreencherDataGridDescribe(params string[][] colunas);
    }
}
