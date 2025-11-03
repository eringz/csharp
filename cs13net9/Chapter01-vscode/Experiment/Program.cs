namespace Experiment;

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        if (isValidEmail(email))
        {
            Console.WriteLine("Email address is valid!");
        }
        else
        {
            Console.WriteLine("Email address is not valid!!!!");
        }

    }

    static bool isValidEmail(string email)
    {
        Console.WriteLine(email);
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        // string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
    }
}