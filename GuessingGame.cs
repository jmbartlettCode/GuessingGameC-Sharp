/* 
Josh Bartlett
6July2019
Assignment 3.2
Guessing game that generates a random number between 1 and 10 and 
asks the user to guess the number then displays the random numeber 
and a message either too high, too low, or correct. 
*/

using System;
using static System.Console;

class GuessingGame
{
    static void Main(string[] args)
    {
        string loop = "Y";
        // Display title 
        WriteLine("Guessing Game: Guess the number");
        while(loop == "Y"){
        // Generate random number
        Random ranNumberGenerator = new Random();
        int randomNumber = ranNumberGenerator.Next(1, 11);

        // Ask user for input and convert from string to int
        Write("Enter guess number: ");
        string stringInputNumber = ReadLine();
        int inputNumber = Convert.ToInt16(stringInputNumber);

        // if statement that checks the guessed number against 
        // the random number and displays the random number and
        // whether the guess was too high, too low, or correct
        if (inputNumber > randomNumber)
        {
            WriteLine("The number was {0}", randomNumber);
            WriteLine("You Guessed Too High");
        }
        else if (inputNumber < randomNumber)
        {
            WriteLine("The number was {0}", randomNumber);
            WriteLine("You Guessed Too Low");
        }
        else if (inputNumber == randomNumber)
        {
            WriteLine("The number was {0}", randomNumber);
            WriteLine("You Guessed Correctly!");
            loop = "N";
        }
        }
        // keeps console open until a key is pressed
        ReadKey(true);
    }
}
