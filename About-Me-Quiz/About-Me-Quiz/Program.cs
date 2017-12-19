using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set score to zero starting out
            int score = 0;
            // Set first question
            string question = "Question 1";
            // Create array of possible answers
            string[] possibleAnswers = { "Answer1", "Answer2"};
            // Which number corrosponds to the correct answer (index + 1)
            int answer = 2;
            // Use "Question" method to present first question, result is the amount of points earned.
            short points = Question( question, possibleAnswers, answer );
            // Apply points returned to score
            score += points;
            // Show user their end points
            Console.WriteLine("Congradulations! You earned " + points + " points!");
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }

        static short Question(string question, string[] possibleAnswers, int solution)
        {
            
            do{
                // Cycling set to false
                bool cycling = false;
                // Ask the player a question
                Console.WriteLine(question);
                // Present possible answers
                for(int index = 0; index < possibleAnswers.Length; index++)
                {
                    int answerNumber = index + 1;
                    Console.WriteLine(answerNumber + ") \"" + possibleAnswers[index] + "\"");
                }
                // Get the player's guess, should be integer
                Console.WriteLine("Enter a number to make a guess.");
                string guess = Console.ReadLine();
                // If the guess can be parsed to short
                if(Int16.TryParse(guess,out short guessParsed)) {
                    // If the guess is beyond the available choices
                    if(guessParsed > possibleAnswers.Length || guessParsed <= 0)
                    {
                        Console.WriteLine("That wasn't an available answer, try again!");
                        Console.ReadLine();
                        // Out of Range (TRY AGAIN)
                    }
                    else // If the guess is a valid number
                    {
                        //If the guess is the right answer
                        if (guessParsed == solution)
                        {
                            //Correct! (SCORE PLAYER 100)
                            Console.WriteLine("Correct! +100 Points!");
                            Console.ReadLine();
                            return (100);
                        }
                        else
                        {
                            //Wrong Answer
                            Console.WriteLine("Sorry, that's not right.");
                            Console.ReadLine();
                            return (0);
                        }
                    }
                } else { // If the guess could not be parsed
                         // Not an integer (TRY AGAIN)
                    Console.WriteLine("That wasn't an available answer, try again!");
                    Console.ReadLine();
                }
                cycling = true;
            }while(cycling); // End While Loop
        } // End of Question Method
    }
}
