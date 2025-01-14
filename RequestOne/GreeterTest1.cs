using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest1
{
    [Fact]
    public void Greet_WhenCalledWithName_ReturnsGreetingWithName()
    {
        var greeter = new Greeter();
        string result = greeter.Greet("Bob");
        Assert.Equal("Hello, Bob.", result);
    }
}