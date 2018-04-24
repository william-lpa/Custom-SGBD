using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Metadados.Tipos
{
    public interface ITipo<T>
    {
        Type Tipo{ get; }
        T valorPadrao { get; set; }
        int tamanhoMaximo { get; set; }
    }
}
