using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
             int from = 1;
             int to = 100;
            Console.WriteLine("You are thinking of a number between 0 and 100");
            Console.WriteLine("Enter the starting number");
            from = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the stoping number");
            to = Convert.ToInt32(Console.ReadLine());
            int randomNumber = new Random().Next(from, to);
            int trys=0;
            int guessedNumber;

            Console.Write("The number is between {0} and {1}. ", from, to);
            while (true)
            {
                Console.Write("Make a guess: ");
                if (int.TryParse(Console.ReadLine(), out guessedNumber))
                {
                    trys++;
                    if (guessedNumber == randomNumber)
                    {
                        
                       
                        Console.WriteLine("You guessed the right number!");

                        Console.WriteLine("it took you");
                        Console.WriteLine(trys);
                        Console.WriteLine("trys");

                        

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too {0}.", (guessedNumber > randomNumber) ? "high" : "low");
                    }
                }
                else
                {
                    Console.WriteLine("Input was not an integer.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

    
