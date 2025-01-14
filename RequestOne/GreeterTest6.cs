using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest6
{
    [Fact]
    public void Greet_WhenCalledWithMixedNames_ReturnsSeparateGreetings()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Amy", "BRIAN", "Charlotte" });
        Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", result);
    }
    [Fact]
    public void Greet_WhenAllNamesAreShouted_ReturnsShoutedGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "BRIAN", "JERRY" });
        Assert.Equal("AND HELLO BRIAN AND JERRY!", result);
    }
    [Fact]
    public void Greet_WhenAllNamesAreNormal_ReturnsNormalGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Amy", "Charlotte" });
        Assert.Equal("Hello, Amy and Charlotte.", result);
    }
}