using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Serializar
{
    interface ISerializable
    {
        string nomeArquivo { get; }
        void deserializar(object dado);
    }
}
