namespace GreetingKata;
public class NullOrEmptyNameHandler : GreetingHandler
{
    public override string Handle(object name)
    {
        if (name == null || string.IsNullOrEmpty(name.ToString()))
            return "Hello, my friend.";
        return base.Handle(name);
    }
}