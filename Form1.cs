using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGBD_CP.Semântico;
using SGBD_CP.Metadados;
using SGBD_CP.Metadados.Interfaces;
using SGBD_CP.Semântico.Ações_Semânticas;
using SGBD_CP.Serializar;
using SGBD_CP.Metadados.Instância_Banco;

namespace SGBD_CP
{
    public partial class Form1 : Form, IObserverSetDataBase, IObserverNewDataBase, IObserverNewTable, IObserverDescribe
    {
        public string arquivo = "";
        private bool compilado = false;
        private BaseDeDados baseAtiva;
        public Form1()
        {
            InitializeComponent();
            inicializarStatusStrip();
            Action16.addObservador(this);
            Action01.addObservador(this);
            Action15.addObservador(this);
            //Form2.Show();
            TreeNode node1 = new TreeNode("Indices");
            TreeNode node2 = new TreeNode("Tabelas");
            TreeNode node3 = new TreeNode("Triggers");
            TreeNode node4 = new TreeNode("Views");
            TreeNode node5 = new TreeNode("Jobs");

            TreeNode registros = new TreeNode("Estruturas", new TreeNode[] { node1, node2, node3, node4, node5 });
            treeView1.Nodes.Add(registros);


        }

        #region BARRA DE STATUS RODAPE
        public void inicializarStatusStrip()
        {
            limparStatusStrip();
            this.statusStrip1.Items.Add("Não modificado");
        }
        private void limparStatusStrip()
        {
            for (int i = statusStrip1.Items.Count - 1; i > -1; i--)
            {
                statusStrip1.Items.RemoveAt(i);
            }
        }
        private void adicionarTextoStatusStrip(params string[] texto)
        {
            foreach (string palavra in texto)
            {
                statusStrip1.Items.Add(palavra);
            }
        }
        #endregion
        #region TECLA DE ATALHO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            Action acao = null;
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        acao = novoArquivo;
                        break;
                    case Keys.A:
                        acao = abrirArquivos;
                        break;
                    case Keys.S:
                        acao = salvarArquivo;
                        break;
                    case Keys.C:
                        acao = copiarTexto;
                        break;
                    case Keys.V:
                        acao = colarTexto;
                        break;
                    case Keys.X:
                        acao = recortarTexto;
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        acao = equipe;
                        break;
                    case Keys.F8:
                        acao = compilar;
                        break;
                    case Keys.F9:
                        acao = gerarCodigo;
                        break;
                }

            }
            if (acao != null)
            {
                try
                {
                    acao.Invoke();
                    return true;
                }
                catch (Exception err)
                {
                    richTextBox2.AppendText(err.Message + Environment.NewLine);
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }
        #endregion
        #region FUNCOES
        private void gerarCodigo()
        {
            throw new NotImplementedException("Compilação de programa ainda não foi implementada");
        }
        private void compilar()
        {
            if (arquivo == "")
            {
                salvarArquivo();
            }

            richTextBox2.Clear();
            Lexico lexico = new Lexico();
            Sintatico sintatico = new Sintatico();
            Semantico semantico = null;
            semantico = Semantico.GetInstance();

            lexico.setInput(richTextBox1.Text);
            string arq = Path.GetFileNameWithoutExtension(statusStrip1.Items[1].ToString());
            semantico.NomeArq = arq;
            try
            {
                sintatico.parse(lexico, semantico);
                richTextBox2.AppendText("programa compilado com sucesso");
                this.compilado = true;
                Token t = null;
                /*  richTextBox2.AppendText("linha\t\tclasse\t\t\tlexema"+Environment.NewLine);
                 while ( (t = lexico.nextToken()) != null )
                  {
                      richTextBox2.AppendText(t.Position + "\t\t"+ t.getTipoToken() +"\t\t" +t.Lexeme +Environment.NewLine);

                  }*/
            }
            catch (LexicalError e)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText(" Erro na linha " + e.getPosition() + " - " + e.Message + Environment.NewLine);

            }
            catch (SyntaticError e)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText(" Erro na linha " + e.getPosition() + " - " + e.Message + Environment.NewLine);

            }
            catch (SemanticError e)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText(" Erro na linha " + e.getPosition() +" - "+ e.Message + Environment.NewLine);
            }
            catch (Exception e)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText(" Erro não tratado/previsto:  - " + e.Message + Environment.NewLine + e.StackTrace);
            }
        }
        private void copiarTexto()
        {
            richTextBox1.Copy();
        }
        private void recortarTexto()
        {
            richTextBox1.Cut();
        }
        private void colarTexto()
        {
            richTextBox1.Paste();
        }
        public void equipe()
        {
            richTextBox2.Clear();
            richTextBox2.AppendText("Leonard William de Azevedo Pegler" + Environment.NewLine
                                + "Luiz Cézar Coppi" + Environment.NewLine);

        }
        public void novoArquivo()
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            inicializarStatusStrip();
            arquivo = "";

        }
        public void abrirArquivos()
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "txt arquivos|*.txt";
            DialogResult resultado = abrirArquivo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FileInfo file = new FileInfo(abrirArquivo.FileName);
                limparStatusStrip();
                adicionarTextoStatusStrip("Pasta:" + file.Directory, "Arquivo:" + file.Name, "Não modificado");
                this.richTextBox2.Clear();
                this.richTextBox1.Clear();
                carregarArquivo(file.FullName);
                this.arquivo = file.FullName;

            }
        }
        private void carregarArquivo(string arquivo)
        {
            try
            {
                using (StreamReader str = new StreamReader(arquivo))
                {
                    string texto = str.ReadToEnd();
                    this.richTextBox1.AppendText(texto);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\r\nStackTrace:" + err.StackTrace);
            }
        }
        private void salvarArquivo()
        {
            if (arquivo != "")
            {
                salvarArquivoNoDisco();
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt arquivos|*.txt";
            DialogResult resultado = sfd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                arquivo = sfd.FileName;
                salvarArquivoNoDisco();
            }
        }
        private void salvarArquivoNoDisco()
        {
            try
            {
                using (StreamWriter stw = new StreamWriter(arquivo))
                {
                    string texto = richTextBox1.Text;
                    stw.Write(texto);
                    adicionarTextoStatusStrip(arquivo);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\r\nStackTrace:" + err.StackTrace);
            }
        }

        #endregion
        #region BOTOES
        private void btCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                copiarTexto();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            try
            {
                novoArquivo();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }

        }
        private void btAbrir_Click(object sender, EventArgs e)
        {
            try
            {

                abrirArquivos();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }

        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                salvarArquivo();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }
        }
        private void btColar_Click(object sender, EventArgs e)
        {
            try
            {
                colarTexto();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }
        }
        private void btRecortar_Click(object sender, EventArgs e)
        {
            try
            {
                recortarTexto();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }
        }
        private void btCompilar_Click(object sender, EventArgs e)
        {
            try
            {


                salvarArquivo();
                compilar();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }
        }
        private void btGerarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                
             //   gerarCodigo();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }
        }
        private void btEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                equipe();
            }
            catch (Exception err)
            {
                richTextBox2.AppendText(err.Message + Environment.NewLine);
            }

        }


        #endregion



        private void cbDataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baseAtiva != null)
                baseAtiva.ConexaoAtiva = false;
            baseAtiva = cbDataBases.SelectedItem as BaseDeDados;
            //  cbDataBases.Items.Remove(baseAtiva);
            baseAtiva.ConexaoAtiva = true;
            //  cbDataBases.Items.Add(baseAtiva);           
            Semantico.GetInstance().DataBase = baseAtiva;
            var tt = baseAtiva.RecuperarTabelaPorNome("William");
            tt.Atributos[0].TipoAtributo.Valor = "William";
            tt.Atributos[1].TipoAtributo.Valor = 9624;
            Dado d = new Dado(baseAtiva.RecuperarTabelaPorNome("William"));
            d.InsereDado();
        }

        #region Observers
        public void update(BaseDeDados Base)
        {
            if (baseAtiva != null)
                baseAtiva.ConexaoAtiva = false;
            Base.ConexaoAtiva = true;
            baseAtiva = Base;
            cbDataBases.SelectedItem = Base;
            Semantico.GetInstance().DataBase = Base;

        }

        void IObserverNewDataBase.update(string Base)
        {
            var _base = Semantico.GetInstance().InstanciaBanco.addDataBase(Base);
            cbDataBases.Items.Add(_base);
        }


        void IObserverNewTable.update(string Base)
        {

        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia serializar = Instancia.GetInstance();
            Serializar<Instancia> t = new Serializar<Instancia>(serializar);
            t.serializar();
        }
        private void carregarBanco()
        {
            ISerializable deserializar = Instancia.GetInstance();
            Serializar<ISerializable> carregar = new Serializar<ISerializable>(deserializar);
            carregar.deserializar();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            carregarBanco();
            inicializarInterface();

            
            

            Encoding en = Encoding.Unicode;
          
            int tamanhoChar = ((sizeof(char) )*50) +4;
            string palavraChar = "123456";
            string palavraChar2 = "12345678";

            int tamanhoReal = en.GetByteCount(palavraChar);
            int tamanhoReal2 = palavraChar2.Length;
            var qtdeByt = en.GetBytes(palavraChar);

            byte[] teste = new byte[tamanhoChar-4];
            char[] teste2 = new char[tamanhoChar - 4];
            var temp = palavraChar.ToCharArray();
            var temp2 = palavraChar2.ToCharArray();

            Array.Copy(qtdeByt,teste, qtdeByt.Length);
            Array.Copy(temp2, teste2, temp2.Length);
            BinaryWriter bw = new BinaryWriter(File.Create("texte.bin"));
            bw.Write(tamanhoReal);
            bw.Write(teste);
            bw.Write(tamanhoReal2);
            bw.Write(teste2);
            bw.Close(); 

            BinaryReader br = new BinaryReader(File.Open("texte.bin",FileMode.Open));
            int g = br.ReadInt32();
            var f= br.ReadBytes(g);
            var fDescente = en.GetString(f);

        }

        public  void PreencherDataGridDescribe(params string[][] colunas) //jagged array
        {
            //nome,tipo, restricao
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Tipo";
            dataGridView1.Columns[2].Name = "Restrição";

            for (int i = 0; i <colunas[0].Length; i++)
            {
                string[] row = { colunas[0][i], colunas[1][i], colunas[2][i] };
            
                dataGridView1.Rows.Add(row);
            }
            
            

        }

        private void inicializarInterface()
        {
            foreach (var baseDados in Instancia.GetInstance().DataBases)
            {
                cbDataBases.Items.Add(baseDados);
            }           
        }
    }

}

