﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");

            Console.WriteLine("\nEnter the first name");
            string firstName = Console.ReadLine();
            while (!Regex.IsMatch(firstName, @"^[A-Z][a-z]{3,}$"))
            {
                Console.WriteLine("Invalid First Name");
                Console.WriteLine("Re-enter First Name");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Valid First Name");
            

            Console.WriteLine("\nEnter the last name");
            string lastName = Console.ReadLine();
            while (!Regex.IsMatch(lastName, @"^[A-Z][a-z]{3,}$"))
            {
                Console.WriteLine("Invalid Last Name");
                Console.WriteLine("Re-enter Last Name");
                lastName = Console.ReadLine();
                
            }
            Console.WriteLine("Valid Last Name");

            Console.WriteLine("\nEnter the Email");
            string emailId = Console.ReadLine();
            Regex reEmail = new Regex(@"^([a-z0-9][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z])?\.?){1,2}([a-z]{2})?)$");
            while (!reEmail.IsMatch(emailId))
            {
                Console.WriteLine("Invalid Email Id");
                Console.WriteLine("Re-enter Email Id");
                emailId = Console.ReadLine();
            }
            Console.WriteLine("Valid Email");
        }
    }
}
