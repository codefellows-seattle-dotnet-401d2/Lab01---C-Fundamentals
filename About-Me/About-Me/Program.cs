using System;

namespace About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            StartQuiz();
            Console.Write("Program terminating... Press Enter...");
            Console.ReadLine();
        }

        private static void StartQuiz()
        {
            Console.WriteLine("Console Quiz App - About Ariel");
            int score = 0;
            string userInput;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(GetQuestion(i));
                userInput = Console.ReadLine();
                if (GetAnswer(i, userInput)) score++;
            }
            Console.WriteLine($"You scored {score} points.");
        }

        private static string GetQuestion(int i)
        {
            switch (i)
            {
                case 0:
                    return "What is the meaning of life?";
                case 1:
                    return "What is my favorite color?";
                case 2:
                    return "Do I like chocolate chip cookies?";
                case 3:
                    return "Do I drink Soylent almost everyday?";
                case 4:
                    return "What is my cat's name?";
                default:
                    return "program error";
            }
        }

        private static bool GetAnswer(int i, string answer)
        {
            switch (i)
            {
                case 0 when answer == "42":
                case 1 when answer == "red":
                case 2 when answer == "yes":
                case 3 when answer == "yes":
                case 4 when answer == "stitch":
                    Console.WriteLine(answer + " is correct!");
                    return true;
                default:
                Console.WriteLine(answer + " was incorrect!");
                return false;
            }
        }
    }
}
