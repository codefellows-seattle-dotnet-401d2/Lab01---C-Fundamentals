using System;

namespace AboutMe
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Thanks for visiting my About Me page!");
            Console.WriteLine("I'm Matt, and you'll be answering questions about me!");
            string username = Console.ReadLine();
            Console.WriteLine($"Welcome {username}, time to get into the questions!")
        }
    }
}