using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {
    public Dictionary<char, int> WordValues { get; set; } = new Dictionary<char, int>() { {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {'n', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'g', 2}, {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3}, {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4}, {'k', 5}, {'j', 8}, {'x', 8}, {'q', 10}, {'z', 10}};
    public string Letters {get; set;}
  

    public Word (string letters)
    {
      Letters = letters;
    }

    public char[] WordToCharacters()
    {
      char[] letterArray = Letters.ToCharArray();
      return letterArray;
    }

    public int[] CharsToPoints(char[] letterArray)
    {
      int[] pointArray = new int [letterArray.Length];
      for (int i = 0; i < letterArray.Length; i++) 
      {
        bool hasValue = WordValues.TryGetValue(letterArray[i], out int value);
        if (hasValue) 
        {
          int points = value;
          pointArray[i] = points;
        }
        else
        {
          pointArray[i] = 0;
        }
      }
      return pointArray;
    }

    public int GetTotalPoints(int[] pointArray)
    {
      int totalPoints = 0;
      foreach (int point in pointArray)
      {
        totalPoints += point;
      }
      return totalPoints;
    }
    


  }
}

//public Word (dictionary of letter:points)
//{
  //Dict = dict
  //_instances.Add(this)
//}
//public Word (dict, string word)
//{
  //:this(dict)
  //{
    //word=word;
  //}
//}