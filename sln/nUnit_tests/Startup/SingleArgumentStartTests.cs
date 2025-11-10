using lib.Startup;

namespace nUnit_tests.Startup;

[TestFixture]
public class SingleArgumentStartTests
{
    private SimpleStartupArguments mSimpleStartupArguments = new  SimpleStartupArguments();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestStartupArgumentInfoReturnsSingle()
    {
        
    }

    [Test]
    public void TestStartupArgumentAttributeRegistered()
    {
        Assert.That(mSimpleStartupArguments.StartupArgumentInfoAttributes.Count, Is.EqualTo(1));

        var argAttr = mSimpleStartupArguments.StartupArgumentInfoAttributes.First();
        
        Assert.That(argAttr.ArgName, Is.EqualTo("--applicationName"));
        Assert.That(argAttr.ArgType, Is.EqualTo(typeof(string)));
        Assert.That(argAttr.ArgDescription, Is.EqualTo("Application name"));
        Assert.That(argAttr.IsRequired, Is.True);
    }
    
    [Test]
    public void TestValidArgumentParsed()
    {
        String[] args = new[] { "--applicationName", "Test Suite" };
        
        mSimpleStartupArguments.ParseFromArgsArray(args);
        
        Assert.That(mSimpleStartupArguments.StartupArgumentInfoAttributes.Count, Is.EqualTo(1));
        Assert.That(mSimpleStartupArguments.ApplicationName, Is.EqualTo("Test Suite"));
    }
    
    [Test]
    public void TestMissingRequiredArgumentThrows()
    {    
        Assert.Throws<MissingStartupArgumentException>(() =>
        {
            mSimpleStartupArguments.ParseFromArgsArray([], true);
        });
    }

    private class SimpleStartupArguments : lib.Startup.StartupArguments
    {
        [lib.Startup.StartupArgumentInfo(argName: "--applicationName", argType: typeof(string), 
            argDescription: "Application name", required: true)]
        public string ApplicationName { get; private set; }
    }
}