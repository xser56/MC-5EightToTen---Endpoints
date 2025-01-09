using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC_5EightToTen___Endpoints.Services
{
    public class GuessItServices
    {
        public string GuessItEasy(int easy)
        {
            int minRange = 1, maxRange = 10;
            Random rng = new Random();
            int numberToGuess = rng.Next(minRange, maxRange + 1);

            if (easy < minRange || easy > maxRange)
            {
                return $"Please enter a number between {minRange} and {maxRange}.";
            }
            
            if (easy == numberToGuess)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else if (easy < numberToGuess)
            {
                return "Your guess is too low. The number was " + numberToGuess;
            }
            else
            {
                return "Your guess is too high. The number was " + numberToGuess;
            }
        }

        public string GuessItMedium(int medium)
        {
            int minRange = 1, maxRange = 50;
            Random rng = new Random();
            int numberToGuess = rng.Next(minRange, maxRange + 1);

            if (medium < minRange || medium > maxRange)
            {
                return $"Please enter a number between {minRange} and {maxRange}.";
            }
            
            if (medium == numberToGuess)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else if (medium < numberToGuess)
            {
                return "Your guess is too low. The number was " + numberToGuess;
            }
            else
            {
                return "Your guess is too high. The number was " + numberToGuess;
            }
        }

        public string GuessItHard(int hard)
        {
            int minRange = 1, maxRange = 100;
            Random rng = new Random();
            int numberToGuess = rng.Next(minRange, maxRange + 1);

            if (hard < minRange || hard > maxRange)
            {
                return $"Please enter a number between {minRange} and {maxRange}.";
            }
            
            if (hard == numberToGuess)
            {
                return "Congratulations! You guessed the correct number!";
            }
            else if (hard < numberToGuess)
            {
                return "Your guess is too low. The number was " + numberToGuess;
            }
            else
            {
                return "Your guess is too high. The number was " + numberToGuess;
            }
        }
    }
}

        
// switch(convertDiff) // Switch stores variables
// {
//     case 1:
//         numberToGuess = rng.Next(1, 11); 
//         break;

//     case 2:
//         minRange = 1;
//         maxRange = 50;
//         numberToGuess = rng.Next(minRange, maxRange + 1); 
//         break;

//     case 3:
//         minRange = 1;
//         maxRange = 100;
//         numberToGuess = rng.Next(minRange, maxRange + 1); 
//         break;
// }
// //------------------------------------------------
//     int userGuess = 0;
//     int attempts = 0;
//     bool validGuess = false;
      
// while(userGuess != numberToGuess)
// {
//     validGuess = false;
            
//     // validation loop
//     while (!validGuess)
//     {
//         string? guessInput = Console.ReadLine();

//         // validate
//         if (int.TryParse(guessInput, out userGuess) && userGuess >= minRange && userGuess <= maxRange)
//         {
//             validGuess = true;
//         }
//         else
//         {
//             Console.WriteLine($"Invalid input. Please enter a number between {minRange} and {maxRange}.");
//         }
//     }

// attempts++; // counter for attemps

// if (userGuess > numberToGuess)
//     {
//         Console.WriteLine("Guess lower!");
//     }
//     else if (userGuess < numberToGuess)
//     {
//         Console.WriteLine("Guess higher!");
//     }
//     else
//         {
//             Console.WriteLine($"Congrats! You guessed the correct number in [{attempts}] attempts.");
//         }
// }
//             return easy;
//         }
//     }
// }