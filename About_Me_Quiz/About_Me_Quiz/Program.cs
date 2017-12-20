using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //capturing users name to be a more personal experience
            Console.WriteLine("What is your name stranger?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}, Answer some questions to reveal my true intentions");
            Console.ReadLine();
            
            //arrays for the questions and answer to the quizz
            string[] questions = new string[5];
            questions[0] = "What is my favorite color?";
            questions[1] = "How many countries do you think I have visited?";
            questions[2] = "Soccer or Football?";
            questions[3] = "What is the capitol of Uganda?";
            questions[4] = "How many kids do you think I have?";

            string[] answers = new string[5];
            answers[0] = "RED";
            answers[1] = "12";
            answers[2] = "SOCCER";
            answers[3] = "KAMPALA";
            answers[4] = "0";

            //points counter
            int points = 0;

            //a series of if and else statements to ask the user the question and prvide answer and feedback
            Console.WriteLine(questions[0]);
            string answerZero = Console.ReadLine();

            if (answerZero.ToUpper() == answers[0])
            {
                Console.WriteLine($"You got it {userName}!");
                points++;
            }
            else
            {
                Console.WriteLine($"Sorry {userName}, better luck next time");
            }

            Console.WriteLine(questions[1]);
            string answerOne = Console.ReadLine();

            if (answerOne == answers[1])
            {
                Console.WriteLine($"Great guess {userName}!");
                points++;
            }
            else
            {
                Console.WriteLine($"Sorry {userName}, This was a difficult one to answer. The correct Answer is {answers[1]}.");
            }

            Console.WriteLine(questions[2]);
            string answerTwo = Console.ReadLine();

            if (answerTwo.ToUpper() == answers[2])
            {
                Console.WriteLine($"Hell Yeah {userName}, I love Soccer");
                points++;
            }
            else
            {
                Console.WriteLine($"Sorry {userName}, Football is my second favorite sport");
            }

            Console.WriteLine(questions[3]);
            string answerThree = Console.ReadLine();

            if (answerThree.ToUpper() == answers[3])
            {
                Console.WriteLine($"Damn {userName}, You really know your geography");
                points++;
            }
            else
            {
                Console.WriteLine($"Sorry {userName}, you need to travel the world a little more");
            }

            Console.WriteLine(questions[4]);
            string answerFour = Console.ReadLine();

            if (answerFour.ToUpper() == answers[4])
            {
                Console.WriteLine($"And the winner is {userName}!. Not ready for that commitment yet.");
                points++;
            }
            else
            {
                Console.WriteLine($"Sorry {userName}, the correct answer is {answers[4]}. I need to have a good job before I can even consider a child at the moment");
            }

            Console.WriteLine($"Thanks for playing {userName}, you answered {points} questions correctly.");

            // the final counter prompt that will display the number of question the user answered correctly. 
            if (points < 4)
            {
                Console.WriteLine($"wish we could have been friends {userName}, But you dont know me that well. You only answered {points} correctly.");
            }
            else
            {
                Console.WriteLine($"Now that you know me so well {userName}, I guess this makes us BFF's. ");
            }           

            Console.ReadLine();
        }
        

    }
}