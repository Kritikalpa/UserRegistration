using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {
        public string firstName, lastName, emailId, phoneNumber, password;

        public void userRegistration()
        {
            Console.WriteLine("\nEnter the first name");
            this.firstName = Console.ReadLine();
            while (!validateFirstName(this.firstName))
            {
                Console.WriteLine("Invalid First Name. Should start with an uppercase and contain minimum 3 characters");
                Console.WriteLine("Re-enter First Name");
                this.firstName = Console.ReadLine();
            }
            Console.WriteLine("Valid First Name");


            Console.WriteLine("\nEnter the last name");
            this.lastName = Console.ReadLine();
            while (!validateLastName(this.lastName))
            {
                Console.WriteLine("Invalid Last Name. Should start with an uppercase and contain minimum 3 characters");
                Console.WriteLine("Re-enter Last Name");
                this.lastName = Console.ReadLine();

            }
            Console.WriteLine("Valid Last Name");

            Console.WriteLine("\nEnter the Email");
            this.emailId = Console.ReadLine();
            while (!validateEmailId(this.emailId))
            {
                Console.WriteLine("Invalid Email Id. Should comply to emailId naming convention");
                Console.WriteLine("Re-enter Email Id");
                this.emailId = Console.ReadLine();
            }
            Console.WriteLine("Valid Email");

            Console.WriteLine("\nEnter the phone number");
            this.phoneNumber = Console.ReadLine();
            while (!validatePhoneNumber(this.phoneNumber))
            {
                Console.WriteLine("Invalid Phone Number. Should countain country code followed by space and 10 digit phone number");
                Console.WriteLine("Re-enter Phone Number");
                this.phoneNumber = Console.ReadLine();

            }
            Console.WriteLine("Valid Phone Number");

            Console.WriteLine("\nCreate a Password");
            this.password = Console.ReadLine();
            while (!validatePassword(this.password))
            {
                Console.WriteLine("Invalid Password format, should contain atleast 8 characters, 1 uppercase character, 1 numeric character and 1 special character");
                Console.WriteLine("Re-enter Password");
                this.password = Console.ReadLine();

            }
            Console.WriteLine("Valid Password");

            Console.WriteLine("User Registration is successfull");
        }
        
        public Func<string, bool> validateFirstName = (firstName) =>
        {
            return Regex.IsMatch(firstName, @"^[A-Z][A-Za-z\s]{2,}$");
        };

        public Func<string, bool> validateLastName = (lastName) =>
        {
            return Regex.IsMatch(lastName, @"^[A-Z][A-Za-z\s]{2,}$");
        };

        public Func<string, bool> validateEmailId = (emailId) =>
        {
            Regex reEmail = new Regex(@"^([a-z][a-z0-9+_-]*\.?[a-z0-9]+@([a-z]([a-z0-9-]*[a-z])\.)([a-z]([a-z0-9-]*[a-z])\.?)([a-z]{2,3})?)$");
            return reEmail.IsMatch(emailId);
        };

        public Func<string, bool> validatePhoneNumber = (phoneNumber) =>
        {
            return Regex.IsMatch(phoneNumber, @"^\+?[0-9]{1,3}\s[0-9]{10}$");
        };

        public Func<string, bool> validatePassword = (password) =>
        {
            return Regex.IsMatch(password, @"^(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&*_\-.,]).*$");
        };
    }
}
