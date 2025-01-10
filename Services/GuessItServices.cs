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