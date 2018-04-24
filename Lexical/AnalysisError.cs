using System;

public class AnalysisError : Exception
{
    private int position;

    public AnalysisError(string msg, int position): base(msg)
    {
        
        this.position = position;
    }

    public AnalysisError(string msg):base(msg)
    {
        
        this.position = -1;
    }

    public int getPosition()
    {
        return position;
    }

    public string toString()
    {
        return base.ToString() + ", @ "+position;
    }
}
