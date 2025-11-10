namespace lib.Startup;

public class MissingStartupArgumentException : Exception
{
    private IEnumerable<string> mMissingArgs = new List<string>();
    
    public MissingStartupArgumentException()
    {
        
    }
}