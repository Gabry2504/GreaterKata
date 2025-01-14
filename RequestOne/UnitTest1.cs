namespace GreetingKata.Tests;
public class GreeterTests
{
    [Fact]
    public void Greet_WhenCalledWithName_ReturnsGreetingWithName()
    {
        var greeter = new Greeter();
        string result = greeter.Greet("Bob");
        Assert.Equal("Hello, Bob.", result);
    }
}
