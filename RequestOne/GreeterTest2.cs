using GreetingKata;
namespace GreetingKataTests;
public class GreeterTest2
{
    [Fact]
    public void Greet_WhenNameIsNull_ReturnsGreetingForFriend()
    {
        var greeter = new Greeter();
        string result = greeter.Greet(null);
        Assert.Equal("Hello, my friend.", result);
    }
    [Fact]
    public void Greet_WhenNameIsEmpty_ReturnsGreetingForFriend()
    {
        var greeter = new Greeter();
        string result = greeter.Greet("");
        Assert.Equal("Hello, my friend.", result);
    }
}
