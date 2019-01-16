using System;

namespace Guessing_Game_Spring_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Guess A Number Between 1-10 and hit enter to submit");
            string userGuess = Console.ReadLine();

            Console.WriteLine("You Guessed: " + userGuess);

            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You Win......");
            }
            else if (userGuess.Equals("0"))
            {
                Console.WriteLine("Please Follow the Instructions...Pick A Number Between 1-10");

                userGuess = Console.ReadLine();
            }

            else

            {
                Console.WriteLine("Wrong Number, Try Again!");
            }         
        }
    }
}



  