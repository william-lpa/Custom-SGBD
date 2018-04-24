using System.IO;
using System.Text;

public class Lexico : _Constants
{
    private int position;
    private string input;
    private int numLinha;
    private int cout = 0;

    public Lexico() : this((""))
    {

    }

    public Lexico(string input)
    {
        setInput(input);
        numLinha = 1;
    }

    public void setInput(string input)
    {
        StringBuilder bfr = new StringBuilder();
        try
        {
            /*int c = input.Read();
            while (c != -1)
            {
                bfr.Append((char)c);
                c = input.Read();
            }*/
            this.input = input;
        }
        catch (IOException e)
        {
            e.StackTrace.ToString();
        }

        setPosition(0);
    }

    public void setPosition(int pos)
    {
        position = pos;
    }

    public Token nextToken()
    {
        if ( ! hasInput() )
            return null;

        int start = position;

        int state = 0;
        int lastState = 0;
        int endState = -1;
        int end = -1;

        while (hasInput())
        {
            lastState = state;
            state = nextState(nextChar(), state);

            if (state < 0)
                break;

            else
            {
                if (tokenForState(state) >= 0)
                {
                    endState = state;
                    end = position;
                }
            }
        }
        if (endState < 0 || (endState != state && tokenForState(lastState) == -2))
            throw new LexicalError(SCANNER_ERROR[lastState], Linha(position), input.Substring(start, position - start));

        position = end;

        int token = tokenForState(endState);

        if (token == 0)
            return nextToken();
        else
        {
            string lexeme = input.Substring(start, end - start);
            token = lookupToken(token, lexeme);
            return new Token(token, lexeme, Linha(start));
        }
    }

    private int nextState(char c, int state)
    {
        int next = SCANNER_TABLE[state,c];
        return next;
    }

    private int tokenForState(int state)
    {
        if (state < 0 || state >= TOKEN_STATE.Length)
            return -1;

        return TOKEN_STATE[state];
    }

    public int lookupToken(int _base, string key)
    {
        int start = SPECIAL_CASES_INDEXES[_base];
        int end   = SPECIAL_CASES_INDEXES[_base+1]-1;

        key = key.ToUpper();

        while (start <= end)
        {
            int half = (start+end)/2;
            int comp = SPECIAL_CASES_KEYS[half].CompareTo(key);

            if (comp == 0)
                return SPECIAL_CASES_VALUES[half];
            else if (comp < 0)
                start = half+1;
            else  //(comp > 0)
                end = half-1;
        }

        return _base;
    }

    private bool hasInput()
    {
        return position < input.Length;
    }

    private char nextChar()
    {
        if (hasInput())
        {
            if (input[position].Equals('\n'))
                numLinha++;

            cout++;
            return input[position++];
        }
        else
            return unchecked((char)-1);
    }

    public int Linha(int posicao)
    {
        var qtd = input.Substring(0, posicao);
        var xx = qtd.Split('\n');
        return xx.Length;
    }

}
