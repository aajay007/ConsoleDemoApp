using System;

namespace ConsoleDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your firstName:");

            string firstName = Console.ReadLine();

            Console.WriteLine("First Name:" + firstName);

            Console.WriteLine("Enter your lastName:");

            string lastName = Console.ReadLine();

            Console.WriteLine("Last Name:" + lastName);

            Console.WriteLine("Full Name:" + firstName + " " + lastName);
        }
    }
}
