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
            var normalNames = names.Where(n => n.ToUpper() != n).ToArray();
            var shoutedNames = names.Where(n => n.ToUpper() == n).ToArray();
            string normalGreeting = "";
            if (normalNames.Length == 1)
                normalGreeting = $"Hello, {normalNames[0]}.";
            else if (normalNames.Length == 2)
                normalGreeting = $"Hello, {normalNames[0]} and {normalNames[1]}.";
            else if (normalNames.Length > 2)
            {
                var allButLast = string.Join(", ", normalNames[..^1]);
                normalGreeting = $"Hello, {allButLast}, and {normalNames[^1]}.";
            }
            string shoutedGreeting = "";
            if (shoutedNames.Length > 0)
                shoutedGreeting = $"AND HELLO {string.Join(" AND ", shoutedNames)}!";
            return $"{normalGreeting} {shoutedGreeting}".Trim();
        }
        return "Hello.";
    }
}