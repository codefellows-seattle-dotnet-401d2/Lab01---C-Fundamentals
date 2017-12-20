using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            StartQuiz();
            Console.Write("Press Enter to Finish Program");
            Console.ReadLine();
        }
        //Setting up the score counter, counting based on correct answers, adding to a variable "correct"
        private static void StartQuiz()
        {
            Console.WriteLine("Thanks for stopping by my About Me Page! My name is Matt Iwicki! What's your name?");
            string username = Console.ReadLine();
            Console.WriteLine($"Welcome {username}, let's get into the questions!");

            int correct = 0;
            string userInput;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(GetQuestion(i));
                userInput = Console.ReadLine();
                if (GetAnswer(i, userInput)) correct++;
            }

            Console.WriteLine($"You got {correct} questions right! Thanks for playing!");
        }
        //First external method for questions, using string as return value for user inputs
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
                    return "ERROR";
            }
        }
        //Second external method for answers, using a boolean for return values as correct and incorrect
        private static bool GetAnswer(int i, string answer)
        {
            switch (i)
            {
                case 0 when answer == "Poland":
                    Console.WriteLine("Nice work, you got it right!");
                    return true;
                case 1 when answer == "wrestling":
                    Console.WriteLine("Awesome job!!");
                    return true;
                case 2 when answer == "Star Wars":
                    Console.WriteLine("Star Wars is definitely life, good work!");
                    return true;
                case 3 when answer == "Virginia":
                    Console.WriteLine("Roanoke, Virginia to be precise!");
                    return true;
                case 4 when answer == "sushi":
                    Console.WriteLine("I could eat sushi every day!");
                    return true;
                default:
                    Console.WriteLine(answer + " was incorrect, sorry!");
                    return false;
            }
        }
    }
}

            