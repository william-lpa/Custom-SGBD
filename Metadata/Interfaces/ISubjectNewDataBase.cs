﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Interfaces
{
    interface ISubjectNewDataBase
    {
        //void addObservador(IObserverSetDataBase ob);
        //void removeObservador(IObserverSetDataBase ob);

        void notificaObservadores(string Base);
    }
}
