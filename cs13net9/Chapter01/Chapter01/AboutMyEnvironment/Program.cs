namespace AboutMyEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory + " directory.");
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine("Namespace: {0}", typeof(Program).Namespace ?? "<null>");
        }
    }
}
