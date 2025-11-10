namespace lib.Startup;

/// <summary>
/// Object indicating a property is supplied as part of the application startup.
/// </summary>
public class StartupArgumentInfo
{
    public StartupArgumentInfo(string argName, Type argType, string argDescription, bool required)
    {
        ArgName = argName;
        ArgType = argType;
        ArgDescription = argDescription;
        IsRequired = required;
    }
    
    /// <summary>
    /// Gets the argument name that is input at startup. This usually is prepended by single or double dashes. e.g. --argName
    /// </summary>
    public string ArgName { get; private set; }

    /// <summary>
    /// Gets the type that the argument value is to be converted to.
    /// </summary>
    public Type ArgType { get; private set; }

    /// <summary>
    /// Gets the argument description. 
    /// </summary>
    public string ArgDescription { get; private set; }

    /// <summary>
    /// Gets whether the argument is required. If set to true, MissingStartupArgumentException will be thrown if a value is not supplied.
    /// </summary>
    public bool IsRequired { get; private set; }
}