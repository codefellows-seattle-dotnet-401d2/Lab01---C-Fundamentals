using System;

namespace About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Quiz App - About Ariel");
            int score = 0;
            string userInput;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(GetQuestion(i));
                userInput = Console.ReadLine();
                if (GetAnswer(i, userInput)) score++;
            }
            Console.WriteLine("Program terminating... Press Enter.");
            Console.ReadLine();
        }

        static string GetQuestion(int i)
        {
            switch (i)
            {
                case 0:
                    return "What is the meaning of life?";
                case 1:
                    return "What is my favorite color?";
                case 2:
                    return "Do I like chocolate chip cookies?";
                default:
                    return "program error";
            }
        }

        static bool GetAnswer(int i, string answer)
        {
            if ((i == 0 && answer == "42") || (i == 1 && answer == "red") || (i == 2 && answer == "yes"))
            {
                Console.WriteLine(answer + " is correct!");
                return true;
            }
            else
            {
                Console.WriteLine(answer + " was incorrect!");
                return false;
            }
        }
    }
}
