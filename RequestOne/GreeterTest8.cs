using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest8
{
    [Fact]
    public void Greet_WhenNameHasEscapedCommas_ReturnsCorrectGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Bob", "\"Charlie, Dianne\"" });
        Assert.Equal("Hello, Bob and Charlie, Dianne.", result);
    }
    [Fact]
    public void Greet_WhenMixedWithEscapedAndUnescapedCommas_ReturnsCorrectGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Bob", "\"Charlie, Dianne\"", "Amy, Brian" });
        Assert.Equal("Hello, Bob, Charlie, Dianne, Amy, and Brian.", result);
    }
    [Fact]
    public void Greet_WhenEscapedCommaNameIsShouted_ReturnsCorrectShoutedGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "\"JERRY, BRIAN\"" });
        Assert.Equal("Hello, JERRY, BRIAN.", result);
    }
}