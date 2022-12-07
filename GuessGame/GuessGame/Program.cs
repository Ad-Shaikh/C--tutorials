using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecretWord = "alarm";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool OutOfGuesses = false;

            while(guess!=SecretWord && !OutOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine($"Guess the word: You have {guessLimit-guessCount} tries left");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    OutOfGuesses = true;
                }
            }
            if (OutOfGuesses)
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry! You Lost");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hurray! You win");
            }
           
            Console.ReadLine();
        }

        
    }

}
