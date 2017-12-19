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
            Console.WriteLine("Thanks for stopping by my About Me Page! My name is Matt Iwicki");
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
                    return "From which nation does my last name, Iwicki, originate?";
                case 1:
                    return "Soccer and wrestling are my favorite sports, but in which sport did I compete for UW's collegiate team?";
                case 2:
                    return "Which of these is my favorite movie franchise, Star Wars, Lord of the Rings, or the Avengers?";
                case 3:
                    return "In which US State was I born, Washington, Virginia, or Pennsylvania?";
                case 4:
                    return "What is my favorite food?";
                default:
                    return "program error";
            }
        }

        private static bool GetAnswer(int i, string answer)
        {
            switch (i)
            {
                case 0 when answer == "Poland":
                case 1 when answer == "wrestling":
                case 2 when answer == "Star Wars":
                case 3 when answer == "Virginia":
                case 4 when answer == "sushi":
                    Console.WriteLine(answer + " is correct!");
                    return true;
                default:
                    Console.WriteLine(answer + " was incorrect!");
                    return false;
            }
        }
    }
}

            