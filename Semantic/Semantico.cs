
using SGBD_CP.Metadados;
using SGBD_CP.Metadados.Instância_Banco;
using SGBD_CP.Semântico.Ações_Semânticas;
using System;

namespace SGBD_CP.Semântico
{
    public class Semantico : _Constants
    {
        private static Semantico instance;
        private String nomeArq;
        public BaseDeDados DataBase { get; set; }
        
        public Instancia InstanciaBanco { get; set; }
        public Semantico()
        {
            InstanciaBanco = Instancia.GetInstance();
        } 
        public void executeAction(int action, Token token)
        {
            IAction acao = null;
            switch (action)
            {
                case 0:
                    acao = new Action00();
                    break;
                case 1:
                    acao = new Action01();
                    break;
                case 2:
                    acao = new Action02();
                    break;
                case 3:
                    acao = new Action03();
                    break;
                case 4:
                    acao = new Action04();
                    break;
                case 5:
                    acao = new Action05();
                    break;
                case 6:
                    acao = new Action06();
                    break;
                case 7:
                    acao = new Action07();
                    break;
                case 8:
                    acao = new Action08();
                    break;
                case 9:
                    acao = new Action09();
                    break;
                case 10:
                    acao = new Action10();
                    break;
                case 11:
                    acao = new Action11();
                    break;
                case 12:
                    acao = new Action12();
                    break;
                case 13:
                    acao = new Action13();
                    break;
                case 14:
                    acao = new Action14();
                    break;
                case 15:
                    acao = new Action15();
                    break;
                case 16:
                    acao = new Action16();
                    break;
                case 17:
                    acao = new Action17();
                    break;
                case 18:
                    acao = new Action18();
                    break;
                case 19:
                    acao = new Action19();
                    break;
                case 20:
                    acao = new Action20();
                    break;
                case 21:
                    acao = new Action21();
                    break;
                case 22:
                    acao = new Action22();
                    break;
                case 23:
                    acao = new Action23();
                    break;
                case 24:
                    acao = new Action24();
                    break;
                case 25:
                    acao = new Action25();
                    break;
                case 26:
                    acao = new Action26();
                    break;
                case 27:
                    acao = new Action27();
                    break;
                case 28:
                    acao = new Action28();
                    break;
                case 29:
                    acao = new Action29();
                    break;
                case 30:
                    acao = new Action30();
                    break;
                case 31:
                    acao = new Action31();
                    break;
                case 32:
                    acao = new Action32();
                    break;
                case 33:
                    acao = new Action33();
                    break;
                case 34:
                    acao = new Action34();
                    break;
                case 35:
                    acao = new Action35();
                    break;
                case 36:
                    acao = new Action36();
                    break;
                case 37:
                    acao = new Action37();
                    break;
                case 38:
                    acao = new Action38();
                    break;
                case 39:
                    acao = new Action39();
                    break;
                case 40:
                    acao = new Action40();
                    break;
                case 41:
                    acao = new Action41();
                    break;

            }
            acao.execute(token);
            Console.WriteLine("Ação #" + action + ", Token: " + token);
        }

        internal static void GetLimpa()
        {
            instance = null;
        }

        public static Semantico GetInstance()
        {
            if (instance == null)
                instance = new Semantico();
            return instance;
        }
        public String NomeArq
        {
            get { return nomeArq; }
            set { nomeArq = value; }
        }
    }
}
