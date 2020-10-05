using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");

            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            if (Regex.IsMatch(firstName, @"^[A-Z][a-z]{3,}$"))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
