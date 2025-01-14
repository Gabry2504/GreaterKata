using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest5
{
    [Fact]
    public void Greet_WhenCalledWithThreeNames_ReturnsGreetingWithOxfordComma()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Amy", "Brian", "Charlotte" });
        Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
    }
    [Fact]
    public void Greet_WhenCalledWithMoreThanThreeNames_ReturnsFormattedGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Amy", "Brian", "Charlotte", "David" });
        Assert.Equal("Hello, Amy, Brian, Charlotte, and David.", result);
    }
}