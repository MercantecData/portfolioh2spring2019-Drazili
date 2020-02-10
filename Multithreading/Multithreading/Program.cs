using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static int i;
        static bool timedOut = false;

        static void Main(string[] args)
        {
            Random random = new Random();
            bool running = true;
            string nr;
            string guess;
            int testnr;

            Console.WriteLine("Welcome to GUESSGAME! Press any key to start");
            Console.ReadKey();

            while (running)
            {
                i = 0;
                timedOut = false;
                //nr = random.Next(1, 10).ToString();
                nr = "2";
                Game();

                guess = Console.ReadLine();
                i = 20;

                if (guess == "" || int.TryParse(guess, out testnr) == false)
                {
                    Console.WriteLine("You have failed");
                }
                else if (nr == guess)
                {
                    Console.WriteLine("Finally, you did it.");
                }
                else
                {
                    Console.WriteLine("YOU ARE WRONG! The number was " + nr);
                }

                Console.WriteLine("Press any key to try again.");
                Console.ReadKey();
            }
        }

        static public async Task Game()
        {
            for (i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Guess a number between 1 and 10. You have " + (10 - i) + " seconds left");
                await Task.Delay(1000);
            }

            if (i == 10)
            {
                timedOut = true;
                Console.WriteLine("Time's out, press any key to continue.");
            }

        }
    }

}
