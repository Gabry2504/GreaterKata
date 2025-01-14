namespace GreetingKata;
public class Greeter
{
    public string Greet(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return "Hello, my friend.";
        }
        return $"Hello, {name}.";
    }
}