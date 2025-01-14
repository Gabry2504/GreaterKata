using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest3
{
    [Fact]
    public void Greet_WhenNameIsUppercase_ReturnsShoutedGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet("JERRY");
        Assert.Equal("HELLO JERRY!", result);
    }
    [Fact]
    public void Greet_WhenNameIsLowercaseOrMixed_ReturnsNormalGreeting()
    {
        var greeter = new Greeter();
        string resultLowercase = greeter.Greet("jerry");
        string resultMixed = greeter.Greet("Jerry");
        Assert.Equal("Hello, jerry.", resultLowercase);
        Assert.Equal("Hello, Jerry.", resultMixed);
    }
}