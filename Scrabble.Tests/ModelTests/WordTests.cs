using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void Word_WordToCharacters_CharacterArray()
    {
      //Arrange
      Word myWord = new Word ("bananas");
      char[] target = {'b', 'a', 'n', 'a', 'n', 'a', 's'};     
      //Act
      char[] result = myWord.WordToCharacters();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_CharArraytoIntArray_IntArray()
    {
      //Arrange
      Word myWord = new Word ("bananas");
      int[] target = {3, 1, 1, 1, 1, 1, 1};
      //Act
      int[] result = myWord.CharsToPoints();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }
  }
}