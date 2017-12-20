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
            int result4 = Question4();
            string result5 = Question5();
            Console.WriteLine("You got "+ score+"/5" + " correct");
            Console.ReadLine();
        }

        public static int score = 0;

        public static string Question1()
        {
            Console.WriteLine("1.Do I like cheese? yes/no");
            string answer = Console.ReadLine();

            if (answer == "yes")
                score++;

            return answer;
        }

        public static int Question2()
        {
            Console.WriteLine("2.How many countries have I visited?");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 4)
               score++;

            return answer;
        }

        public static string Question3()
        {
            Console.WriteLine("3.Do I like to go camping? yes/no");
            string answer = Console.ReadLine();

            if (answer == "yes")
                score++;  
             
            return answer;
        }

        
        public static int Question4()
        {
            Console.WriteLine("4.How many siblings do I have?");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 2)
                score++;

            return answer;

        }

        public static string Question5()
        {
            Console.WriteLine("5.Do I love cats? yes/no");
            string answer = Console.ReadLine();

            if (answer == "no")
                score++;
            try
            {
                answer = ("yes");
                answer = ("no");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("Executed");
            }
            return answer;
        }
    }
}
