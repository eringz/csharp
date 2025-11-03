namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace ?? "<null>");
        Console.WriteLine(format: "Value is {0}.", arg0: 19.8);

    }
}
