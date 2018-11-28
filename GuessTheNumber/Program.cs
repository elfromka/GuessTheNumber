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

            // Asking for a number from the user
            Console.Write("Please, enter a number between 1 & 100: ");

            // Read it, and convert it from string to int
            string stringUserNumber = Console.ReadLine();
            int intUserNumber = int.Parse(stringUserNumber);

            // Keep asking until the user guessed the random number 
            while (randomNumber != intUserNumber)
            {
                if (randomNumber > intUserNumber)
                {
                    // Warn the user that the random number is bigger
                    Console.WriteLine("\r\nWrong, it's a BIGGER number");
                }
                else
                {
                    // Warn the user that the random number is smaller
                    Console.WriteLine("\r\nWrong, it's a SMALLER number");
                }

                // Asking again for a number from the user
                Console.Write("Please try again and enter another number: ");

                // Reading/converting it again from string to int
                stringUserNumber = Console.ReadLine();
                intUserNumber = int.Parse(stringUserNumber);
            }

            /* 
             * Showing a 'Congratulations' message to the 
             * user if the number is guessed
             */
            if (randomNumber == intUserNumber)
            {
                Console.WriteLine("\r\nCongratulations! You guessed the number! :)");
                Console.ReadKey();
            }
        }
    }
}
