using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thanks for visiting my About Me page!");
            Console.WriteLine("I'm Matt, and you'll be answering questions about me!");
            string username = Console.ReadLine();
            Console.WriteLine($"Welcome {username}, time to get into the questions!");
            QuestionList();
        }
        static string GiveHint()
        {
            string[] hints = new string[5];
            hints[0] = "This country doesn't like Germany very much.";
            hints[0] = "Which sport do you think would be the harder one?";
            hints[0] = "It's not the Avengers!";
            hints[0] = "It's not Pennsylvania!";
            hints[0] = "It's a Japanese food!";
            return hints[index];
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
            answers[4] = "SUSHI";

            int Incorrect = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(questions[i]);
                    string response = Console.ReadLine().ToUpper();
                    if (response == answers[i])
                    {
                        if (j == 0)
                        {
                            Console.WriteLine("Nice work, you got it first try!");
                        }
                    }
                    else
                    {
                        if (j == 2)
                        {
                            Console.WriteLine("Sorry, you're out of guesses!");
                            Incorrect++;
                        }
                        else
                        {
                            Console.WriteLine("One guess left! Heres a hint to help:");
                            Console.WriteLine(GiveHint(i));
                        }
                    }
                }

            }
            Console.WriteLine($"You got {5 - Incorrect} questions correct!");
            Console.WriteLine("Thanks for playing!");
            Console.Read();
        }
    }
}
        