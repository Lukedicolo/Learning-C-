using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guesses = 0;
            int guessNum = 0;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            while (guessNum != theNumber){
                string guessStr = Console.ReadLine();
                guesses++;

                try{
                    guessNum = int.Parse(guessStr);
                    if (guessNum == -1){
                        Console.WriteLine("Giving up? Oh well. For the record, you made {0} guess(es).", guesses);
                        break;
                    }
                    else if (guessNum == theNumber) {
                        Console.WriteLine("Correct! Congratulations, you win!");
                        Console.WriteLine("It took you {0} guess(es).", guesses);
                        break;
                    }
                    else {
                        Console.WriteLine("Not quite, try going {0}.", guessNum < theNumber ? "higher" : "lower");
                        Console.WriteLine("You've made {0} guess(es) so far.", guesses);
                    }
                }
                catch{
                    Console.WriteLine("Oops. That doesn't look like a number... Try again (with an integer).");
                    Console.WriteLine("You've made {0} guess(es) so far.", guesses);
                }

            }
        }
    }
}
