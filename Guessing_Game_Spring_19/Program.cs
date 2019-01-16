using System;

namespace Guessing_Game_Spring_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Guess A Number Between 1-10");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You Guessed: " + userGuess);
            // if they guess 7
            if (userGuess.Equals("7"))
            {
                // then they win
                Console.WriteLine("You Win......");
            }
            else if (userGuess.Equals("0"))
            {
                // then re-state the directions
                Console.WriteLine("Please Follow the Instructions...Pick A Number Between 1-10");
            }
            else
            {
                // otherwise they lose
                Console.WriteLine("You Lose!");
            }
            // if they guess 0
           

        }
    }
}




  