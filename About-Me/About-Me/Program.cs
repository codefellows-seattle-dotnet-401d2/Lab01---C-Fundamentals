using System;

namespace About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            StartQuiz();
            Console.Write("\nProgram terminating... Press Enter...");
            Console.ReadLine();
        }

        /// <summary>
        /// This handles the main loop for the quiz game. Asks questions and waits for input. Tells you if you were 
        /// correct or not, then at the end, how many you got right.
        /// </summary>
        private static void StartQuiz()
        {
            int score = 0;
            string userInput;
            bool isAnswerRight;
            Console.WriteLine("Console Quiz App - About Ariel\n");
            bool areHintsOn = EnableHints();
            // Should iterate through the same number of questions available in GetQuestion()
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(GetQuestion(i));
                if (areHintsOn) PrintHint(i);
                userInput = Console.ReadLine();
                /* The try block will run code inside and if an exception is thrown, catch block will handle it. 
                 * Because I don't expect user input to actually throw an exception, I am manually throwing an 
                 * exception when userInput was an empty string. I am only writing to the console that an exception 
                 * was thrown. I decrement i and continue so that the question is asked again.
                */
                try
                {
                    if(userInput == "") throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Exception thrown");
                    i--;
                    continue;
                }
                isAnswerRight = GetAnswer(i, userInput);
                if (isAnswerRight) score++;
            }
            Console.WriteLine($"\nYou scored {score} points.");
        }

        /// <summary>
        /// Calling this will ask the user if they want hints printed and parse input to determine if the user said yes.
        /// </summary>
        /// <returns>True or False</returns>
        private static bool EnableHints()
        {
            string[] yesArray= {"y","Y","yes","YES", "Yes", "Yeah", "yeah", "Okay", "okay", "OK", "ok", "Ok"};
            Console.Write("Would you like to enable hints?: ");
            string userInput = Console.ReadLine();
            //using array of possible ways to answer "yes" to so I can compare input against
            foreach (string yes in yesArray)
            {
                if (userInput == yes)
                {
                    Console.WriteLine("Hints Enabled!");
                    return true;
                }
            }
            Console.WriteLine("Hints not enabled.");
            return false;
        }

        /// <summary>
        /// Will write lines to the screen (hints to questions) dependant on counter number passed in that matches with current question.
        /// </summary>
        /// <param name="i"></param>
        private static void PrintHint(int i)
        {
            //needs to have same number of case statements as GetQuestion()
            switch (i)
            {
                case 0:
                    Console.WriteLine("Hints: Money, Fame, Glory, 42");
                    break;
                case 1:
                    Console.WriteLine("Hints: Red, Blue, Green, Gold");
                    break;
                case 2:
                    Console.WriteLine("Hints: Yes, No, Maybe");
                    break;
                case 3:
                    Console.WriteLine("Hints: Yes, No, Maybe");
                    break;
                case 4:
                    Console.WriteLine("Hints: Coco, Beans, Stitch, Curry");
                    break;
                default:
                    Console.WriteLine("program error");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static string GetQuestion(int i)
        {
            switch (i)
            {
                case 0:
                    return "\nWhat is the meaning of life?";
                case 1:
                    return "\nWhat is my favorite color?";
                case 2:
                    return "\nDo I like chocolate chip cookies?";
                case 3:
                    return "\nDo I drink Soylent almost everyday?";
                case 4:
                    return "\nWhat is my cat's name?";
                default:
                    return "program error";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="answer"></param>
        /// <returns></returns>
        private static bool GetAnswer(int i, string answer)
        {
            answer = answer.ToLower();
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
