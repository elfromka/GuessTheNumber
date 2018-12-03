using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcoming the user
            Console.WriteLine("Welcome to 'GUESS THE NUMBER' game!{0}", Environment.NewLine);

            // Generating the random number
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);

            // Checking if the number is guessed by the user
            bool isItGuessed = false;

            // Welcoming the user
            do {
                // Asking for a number from the user
                Console.Write("Please, enter a number between 1 & 100: ");

                // Read it, and convert it from string to int
                string stringUserNumber = Console.ReadLine();
                int intUserNumber = int.Parse(stringUserNumber);

                // Little hints/helps
                if (randomNumber > intUserNumber)
                {
                    Console.WriteLine("\r\nWrong, it's a BIGGER number");
                }
                else if(randomNumber < intUserNumber)
                {
                    Console.WriteLine("\r\nWrong, it's a SMALLER number");
                } 
                else if(randomNumber == intUserNumber)
                {
                    // The number is the same as the input number from the user
                    isItGuessed = true;
                    Console.WriteLine("\r\nCongratulations! You guessed the number! :)");
                    Console.WriteLine("\r\nPress any key to Exit...)");
                    Console.ReadKey();
                }
            } while(isItGuessed == false);
        }
    }
}
