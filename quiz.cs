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
            QuestionList();
        }
        static void QuestionList()
        {
            string[] questions = new string[5];
            questions[0] = "From which nation does my last name, Iwicki, originate?";
            questions[1] = "Soccer and wrestling are my favorite sports, but in which sport did I compete for UW's collegiate team?";
            questions[2] = "Which of these is my favorite movie franchise, Star Wars, Lord of the Rings, or the Avengers?";
            questions[3] = "In which US State was I born, Washington, Virginia, or Pennsylvania?";
            questions[4] = "What is my favorite food?";

            string[] answers = new string[5];
            answers[0] = "POLAND";
            answers[1] = "WRESTLING";
            answers[2] = "STAR WARS";
            answers[3] = "VIRGINIA";
            answers[4] = "PIZZA";
        }
    }
}