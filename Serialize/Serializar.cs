using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Serializar
{
    class Serializar<T> where T : ISerializable
    {
        private T[] _serializar;
        public Serializar(params T[] objects)
        {
            _serializar = objects;
        }

        public void serializar()
        {
            try
            {
                BinaryFormatter bt = new BinaryFormatter();

                foreach (T t in _serializar)
                {
                    using (Stream fs = File.Create("Metadata\\"+t.nomeArquivo + ".bin"))
                    {
                        bt.Serialize(fs, t);
                    }
                }
            }
            catch (Exception err)
            { //CentralEventos.getInstance.addExcecao(err); }
            }
        }
        public void deserializar()
        {
            try
            {
                foreach (T t in _serializar)
                {
                    using (Stream fs = File.Open("MEtadata\\"+t.nomeArquivo + ".bin", FileMode.Open))
                    {
                        BinaryFormatter bt = new BinaryFormatter();
                        fs.Seek(0, SeekOrigin.Begin);
                        t.deserializar(bt.Deserialize(fs));
                    }
                }
            }
            catch (Exception err)
            { //CentralEventos.getInstance.addExcecao(err); }
            }

        }
    }
    
}
