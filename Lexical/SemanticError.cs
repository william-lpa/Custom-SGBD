using System;

public class SemanticError : AnalysisError
{
    public SemanticError(String msg, int position): base(msg, position)
	 {
        
    }

    public SemanticError(String msg): base(msg)
    {
     
    }
}
