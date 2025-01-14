namespace GreetingKata;
public class Greeter
{
    public string Greet(object name)
    {
        if (name == null || string.IsNullOrEmpty(name.ToString()))
            return "Hello, my friend.";
        if (name is string singleName)
        {
            if (singleName.ToUpper() == singleName)
                return $"HELLO {singleName}!";
            return $"Hello, {singleName}.";
        }
        if (name is string[] names)
        {
            if (names.Length == 2)
                return $"Hello, {names[0]} and {names[1]}.";
            if (names.Length > 2)
            {
                var allButLast = string.Join(", ", names[..^1]);
                return $"Hello, {allButLast}, and {names[^1]}.";
            }
        }
        return "Hello.";
    }
}