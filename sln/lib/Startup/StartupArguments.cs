using System.Reflection;

namespace lib.Startup;

/// <summary>
/// Abstract representation the startup arguments for the application.
/// This needs to be subclassed with additional properties for the application.
/// </summary>
public abstract class StartupArguments
{
    public StartupArguments()
    {

    }
    
    /// <summary>
    /// Parses arguments from a string array.
    /// </summary>
    /// <param name="args">String array of arguments, usually from the command line.</param>
    /// <param name="throwIfMissingArgument">Indicate whether to throw an exception if an expected argument name is missing.</param>
    /// <exception cref="MissingStartupArgumentException">Thrown with a list of missing argument names.</exception>
    public void ParseFromArgsArray(string[] args, bool throwIfUnknownSupplied = true)
    {
        
    }
}