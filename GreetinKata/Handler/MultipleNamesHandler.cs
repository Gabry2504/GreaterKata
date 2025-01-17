﻿namespace GreetingKata;
public class MultipleNamesHandler : GreetingHandler
{
    public override string Handle(object name)
    {
        if (name is string[] names)
        {
            var allNames = names.SelectMany(n =>
                n.StartsWith("\"") && n.EndsWith("\"")
                    ? new[] { n.Trim('\"') }
                    : n.Split(", ")
            ).ToArray();
            var normalNames = allNames.Where(n => !(n.ToUpper() == n && !n.Contains(","))).ToArray();
            var shoutedNames = allNames.Where(n => n.ToUpper() == n && !n.Contains(",")).ToArray();
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
        return base.Handle(name);
    }
}