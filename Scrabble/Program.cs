using System;
using Scrabble.Models;
using System.Collections.Generic;

namespace Program
{
  class ScrabbleGame
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Counter!\nWould you like to run the program?\n y / n");
      string run = Console.ReadLine();
      while (run != "n")
      {
        if (run == "y")
        {
        Console.WriteLine("Please enter a word to calculate the points");
        string userWord = Console.ReadLine();
        Word testWord = new Word (userWord);
        char[] letterArray = testWord.WordToCharacters();
        int[] pointArray = testWord.CharsToPoints(letterArray);
        int result = testWord.GetTotalPoints(pointArray);
        Console.WriteLine("Your word '" + userWord + "' is equal to " + result + " points.");
        }
        else if (run == "n")
        {
          Console.WriteLine("That's too bad.");
          break;
        }
        else
        {
          Console.WriteLine("Your input was not recognized, please try again.");
        }
        Console.WriteLine("Do you want to run the program again?");
        run = Console.ReadLine();
      }
    }
  }
}
