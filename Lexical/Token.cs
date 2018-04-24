using System;

public class Token
{
    private int id;
    private string lexeme;
    private int position;

    public Token(int id, string lexeme, int position)
    {
        this.id = id;
        this.lexeme = lexeme;
        this.position = position;
    }

    public  int Id
    {
        get { return id; }
    }

    public  String Lexeme
    {
        get { return lexeme; }
    }

    public int Position
    {
        get { return position; }
    }

    public String toString()
    {
        return id+" ( "+lexeme+" ) @ "+position;
    }
}
