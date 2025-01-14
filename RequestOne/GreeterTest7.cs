using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest7
{
    [Fact]
    public void Greet_WhenNamesContainComma_SplitsAndReturnsCorrectGreeting()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Bob", "Charlie, Dianne" });
        Assert.Equal("Hello, Bob, Charlie, and Dianne.", result);
    }
    [Fact]
    public void Greet_WhenCommaIsInShoutedName_SplitsAndShoutsCorrectly()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(new[] { "Bob", "JERRY, BRIAN" });
        Assert.Equal("Hello, Bob. AND HELLO JERRY AND BRIAN!", result);
    }
}