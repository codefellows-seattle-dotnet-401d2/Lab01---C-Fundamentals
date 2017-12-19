using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name stranger?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}, Answer some questions to reveal my true intentions");
            Console.ReadLine();
        }

        static void MyQuestions()
        {
            string[] questions = new string[5];
            questions[0] = "What is my favorite color?";
            questions[1] = "How many countries do you think I have visited?";
            questions[2] = "Soccer or Football?";
            questions[3] = "what is the capitol of ";
            questions[4] = "";

        }

    }
}