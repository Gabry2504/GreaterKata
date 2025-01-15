namespace GreetingKata;
public class SingleNameHandler : GreetingHandler
{
    public override string Handle(object name)
    {
        if (name is string singleName)
            return $"Hello, {singleName}.";
        return base.Handle(name);
    }
}