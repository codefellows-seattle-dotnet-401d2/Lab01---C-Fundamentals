using System;

namespace About_Me2
{
    class Program
    {
        static void Main(string[] args)
        {
            // entry point
            Console.WriteLine("Welcome to my guessing game!");
            // Method call
            QuestionsAndAnswers();
        }

        static void QuestionsAndAnswers()
        {
            //array of questions
            string[] questions = new string[5];
            questions[0] = "Question 1! Have I ever been out of country? Y/N?";
            questions[1] = "Question 2! Is Reese's Peanut Butter Cups my favorite candy? Y/N?";
            questions[2] = "Question 3! Have I ever participated in any sports? Y/N?";
            questions[3] = "Question 4! Am I an only child? Y/N?";
            questions[4] = "And finally, question number 5! Am I enjoying this beautiful Seattle weather? Y/N?";

            //array of answers
            string[] answers = new string[5];
            answers[0] = "Y";
            answers[1] = "Y";
            answers[2] = "Y";
            answers[3] = "N";
            answers[4] = "N";

            //tracker for number of questions guessed correctly
            int correctGuesses = 0;


            for (int i = 0; i < questions.Length; i++)
            {
                //iterate over questions
                Console.WriteLine(questions[i]);
                
                // auto caps y and n answers
                string userInput = Console.ReadLine().ToUpper();

                //if user answer is correct, increment correct guesses
                if (userInput == answers[i])
                {
                    Console.WriteLine("You are correct! Next question..");
                    correctGuesses++;
                }

                //otherwise, give incorrect message, and move on to next question
                else
                {
                    Console.WriteLine("Sorry! Incorrect, next question..");
                }
            }

            // displaying correct guesses and informing player that game is over
            Console.WriteLine("The game is done! You got " + correctGuesses + " correct. Thanks for playing!");
            Console.Read();
        }
    }
}
