namespace GreetingKata;
public class ShoutedNameHandler : GreetingHandler
{
    public override string Handle(object name)
    {
        if (name is string singleName && singleName.ToUpper() == singleName)
            return $"HELLO {singleName}!";
        return base.Handle(name);
    }
}