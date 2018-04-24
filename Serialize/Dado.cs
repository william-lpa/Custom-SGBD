using SGBD_CP.Metadados;
using SGBD_CP.Metadados.Tipos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD_CP.Serializar
{
public class Dado
{
      public Tabela tabela { get; set; }
      public Dictionary<Tipo,object> atributos;
      private long tamanhoRegistro;
        private int quantidadeString;
        private const string diretorio = "Data";
        public Dado(Tabela t)
        {
            this.atributos = new Dictionary<Tipo, object>();
            
            this.tabela = t;
            var atributos=t.Atributos;
            atributos.ForEach(atr =>
            {
                tamanhoRegistro += atr.TamanhoAtributoBytes;
                this.atributos.Add(atr.TipoAtributo, atr.TipoAtributo.Valor);
                if (atr.TipoAtributo.TipoAtb().Equals(typeof(string)))
                    quantidadeString++;
            });
        }

        public void InsereDado()
        {
            DirectoryInfo d = Directory.CreateDirectory(diretorio  + $"\\{tabela.NomeBase}"); //pegar o nome da base e grar uma pasta
            string nomeArquivo= d.FullName + $"\\{tabela.NomeTabela}.dat";
            FileStream fs;
            fs = File.Open(nomeArquivo, FileMode.OpenOrCreate);
            fs.Position = fs.Length;

            BinaryWriter bw = new BinaryWriter(fs);            
            
            var extraBytes = quantidadeString * 4;
            int posicaoAtual = 0;
            byte[] registro = new byte[tamanhoRegistro + extraBytes];
            //cria um array de bytes com o tamanho total mais a quantidade de campos != de int *4
            foreach (KeyValuePair<Tipo, object> item in atributos)
            {
                //insere sempre na ultima posição "limpa" do array de bytes com o tamanho maximo do reg
                // caso alguma coluna da tabela n foi informado um valor, deixar esse espaço que seria ocupado pelo arquivo em "branco"
                if (item.Key.TipoAtb().Equals(typeof(int)))
                {
                    // insere 4 bytes no array com o valor de item.Value
                    var bytes = BitConverter.GetBytes((int)item.Value);
                    Array.Copy(bytes,0, registro, posicaoAtual,bytes.Length);
                    posicaoAtual += 4;
                }
                else
                { // char ou string
                    // insere 4 bytes no array com a quantidade de bytes utilizados por item.value
                    //insere os bytes de item.value
                    string valor = item.Value.ToString();
                    int quantidadeBytes = valor.Length * 2;
                    var bytesint = BitConverter.GetBytes(quantidadeBytes);
                    char[] Charbytes = valor.ToCharArray();
                    byte[] bytes= new byte[0];
                    foreach (var c in Charbytes)
                    {
                        bytes = bytes.Concat(BitConverter.GetBytes(c)).ToArray();
                    }
                    byte[] bytesTotais = bytesint.Concat(bytes).ToArray();
                    var testeeee = Encoding.ASCII.GetString(bytes);
                    Array.Copy(bytesTotais, 0, registro, posicaoAtual, bytesTotais.Length);
                    posicaoAtual += (4 + (item.Key.tamanho()*2));

                    // incrementa a posicao utilizada no array total :
                    // inteiro com a info de qtde de bytes do texto + tamanho maximo em bytee q o campo pode ter
                }
                
             }
            bw.Write(registro);//grava o array total do registro no final do arquivo.
            bw.Dispose();
        }
}

}
