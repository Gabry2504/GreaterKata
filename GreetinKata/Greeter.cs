namespace GreetingKata;
public class Greeter
{
    public string Greet(string name)
    {
        if (string.IsNullOrEmpty(name))
            return "Hello, my friend.";
        if (name.ToUpper() == name)
            return $"HELLO {name}!";
        return $"Hello, {name}.";
    }
}