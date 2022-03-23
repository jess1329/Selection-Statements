using System;

namespace Selection_Statements_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            





            var random = new Random();
            var number = random.Next(1, 10);

           


            

            
            bool correct = false;

            while (!correct)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                var guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Your guess is too high, sorry");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low, sorry");
                }
                else

                {
                    correct = true;
                    Console.WriteLine("Correct!");
                }
            }
        }
    } 
}
