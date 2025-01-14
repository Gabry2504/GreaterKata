using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest4
{
    [Fact]
    public void Greet_WhenCalledWithTwoNames_ReturnsGreetingWithBothNames()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Jill", "Jane" });
        Assert.Equal("Hello, Jill and Jane.", result);
    }
}