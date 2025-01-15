using GreetingKata.Handler.Interface;
namespace GreetingKata;
public abstract class GreetingHandler : IGreetingHandler
{
    private GreetingHandler _next;
    public GreetingHandler SetNext(GreetingHandler next)
    {
        _next = next;
        return _next;
    }
    public virtual string Handle(object name)
    {
        return _next?.Handle(name);
    }
}