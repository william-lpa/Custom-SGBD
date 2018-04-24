public class LexicalError : AnalysisError
{
    private string lexeme;
    public LexicalError(string msg, int position, string lexeme):base(msg, position)
    {
        if ((!msg.Equals("constante string n�o finalizada") && !msg.Equals("bloco de comentario n�o finalizado")))
        {
            this.lexeme = lexeme;
        }
        else { this.lexeme = ""; }

    }

    public LexicalError(string msg):base(msg)
    {
        
    }
}
