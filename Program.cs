using System;
using System.Text.RegularExpressions;

namespace RegExLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // THANK YOU, REGEXR :)    (I didn't know about this site!)
            // E-mail ^([A-z-]{5,30})[@]([A-z]{5,10})[.]([A-z]{2,3})
            // Phone numbers ^([0-9]{3})[-]([0-9]{3})[-]([0-9]{4})
            // Dates ^([0-9]{2})[/]([0-9]{2})[/]([0-9]{4})

            Console.Write("Please enter firstname lastname: ");
            string name = Console.ReadLine();

            string pattern = @"^([A-z'-]+\s+){1,2}[A-z'-]+$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Name valid");
            }
            else
            {
                Console.WriteLine("Name invalid");
            }
            Email();
        }

        private static void Email()
        {
            Console.Write("Please enter your e-mail: ");
            string name = Console.ReadLine();

            string pattern = @"^([A-z-]{5,30})[@]([A-z]{5,10})[.]([A-z]{2,3})+$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Email valid");
                PhoneNumber();
            }
            else
            {
                Console.WriteLine("Email invalid");
                Email();
            }
        }
        private static void PhoneNumber()
        {
            Console.Write("Please enter your phone number (xxx-xxx-xxxx): ");
            string name = Console.ReadLine();

            string pattern = @"^([0-9]{3})[-]([0-9]{3})[-]([0-9]{4})+$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Phone Number valid");
                Date();
            }
            else
            {
                Console.WriteLine("Phone Number invalid");
                PhoneNumber();
            }
        }

        private static void Date()
        {
            Console.Write("Please enter the date mm/dd/yyyy: ");
            string name = Console.ReadLine();

            string pattern = @"^([0-9]{2})[/]([0-9]{2})[/]([0-9]{4})+$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Date valid");
                return;
            }
            else
            {
                Console.WriteLine("Date invalid");
                Date();
            }
        }

    }
}
