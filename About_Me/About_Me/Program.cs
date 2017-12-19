using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Question1();
            int result2 = Question2();
            string result3 = Question3();
            Int16 result4 = Question4();
            string result5 = Question5();
            Console.WriteLine(result);
            Console.ReadLine();
        }


        public static string Question1()
        {
            Console.WriteLine("1.Do I like cheese? yes/no");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                return "Correct!";
            }
            else 
            {
                return "incorrect!";
            }
        }

        public static int Question2()
        {
            Console.WriteLine("2.How many countries have I visited?");
            int answer = int.Parse(Console.ReadLine());
            return answer;

            /*if (answer == 4)
            {
               // add to score;
            }*/
        }

        public static string Question3()
        {
            Console.WriteLine("3.Do I like to go camping? yes/no");
            string answer = Console.ReadLine();
            return answer;

           /* if (answer == "yes")
            {
                return "Correct!";
            }*/
          
        }

        
        public static Int16 Question4()
        {
            Console.WriteLine("4.How many siblings do I have?");
            //  int answer = int.Parse(Console.ReadLine());
            // return answer;
            /* if (answer == 2)
            {
                return "Correct!";
            }*/

            if (Int16.TryParse(Console.ReadLine(), out Int16 answer))
            {
                return answer;
            }
            else
            {
                Console.WriteLine("Please put in a number");
            }

            return 0;





        }

        public static string Question5()
        {
            Console.WriteLine("5.Do I love cats? yes/no");
            string answer = Console.ReadLine();
            return answer;

            /*if (answer1 == "yes")
            {
                return "Correct!";
            }*/
           
        }
    }
}
