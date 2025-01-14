namespace GreetingKata;

class Program
{
    static void Main(string[] args)
    {
        var greeter = new Greeter();
        Console.WriteLine(greeter.Greet(null));
    }
}