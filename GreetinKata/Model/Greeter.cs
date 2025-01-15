namespace GreetingKata;
public class Greeter
{
    private readonly GreetingHandler _handler;
    public Greeter()
    {
        _handler = new NullOrEmptyNameHandler();
        _handler
            .SetNext(new ShoutedNameHandler())
            .SetNext(new SingleNameHandler())
            .SetNext(new MultipleNamesHandler());
    }
    public string Greet(object name)
    {
        return _handler.Handle(name);
    }
}