using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounters.Models;
using System.Linq;

namespace WordCounters.Models.Tests
{
  [TestClass]
  public class ProjectTest
  {
    [TestMethod]
    public void Inputs_GetUserInput_True()
    {
      WordCounter newWordCounter = new WordCounter();
      newWordCounter.SetUserInput("bird");
      string testOutput = newWordCounter.GetUserInput();
      Assert.AreEqual("bird", testOutput);
    }

    [TestMethod]
    public void TextBaseInputs_SetUserInputtoTextBase_True()
    {
      WordCounter newTextBaseInput = new WordCounter();
      newTextBaseInput.SetUserInput("Bird-bird, bird. Bird isn't the Word.");
      string testTextBaseInput = newTextBaseInput.GetUserInput();
      Assert.AreEqual("Bird-bird, bird. Bird isn't the Word.", testTextBaseInput);
    }

    [TestMethod]
    public void InputToArray_SetUserInputToArray_True()
    {
      string testBird = "Bird";
      char[] birdArray = testBird.ToLower().ToCharArray();
      WordCounter newGuideArray = new WordCounter();
      newGuideArray.SetGuideWord("Bird");
      char[] testGuideArray = newGuideArray.GetGuideWord();
      CollectionAssert.AreEqual(birdArray, testGuideArray);
    }


    [TestMethod]
    public void TextBaseToArray_SetTextBaseToArray_True()
    {
      string testPhrase = "Bird-bird, bird. Bird isn't the Word.";
      char[] CompareTextBaseArray = testPhrase.ToLower().ToCharArray();
      WordCounter newTextBaseArray = new WordCounter();
      newTextBaseArray.SetGuideWord("Bird-bird, bird. Bird isn't the Word.");
      char[] testTextBaseArray = newTextBaseArray.GetGuideWord();
      CollectionAssert.AreEqual(CompareTextBaseArray, testTextBaseArray);
    }

    [TestMethod]
    public void TextBaseArrayToList_SplitCharArraystoList_True()
    {
      //Arrange
      WordCounter TextBaseArray = new WordCounter();
      string testText = "Bird-bird";
      TextBaseArray.SetGuideWord(testText);
      char[] testArray = TextBaseArray.GetGuideWord();

      TextBaseArray.SetTextBaseWord("Bird-bird, bird. Bird isn't the Word.");
      char[] divisionTextBaseArray = TextBaseArray.GetTextBaseWord();

      //Act
      TextBaseArray.SetTextBase(divisionTextBaseArray);
      List<char[]> newTextBase = TextBaseArray.GetTextBase();

      //Assert
      CollectionAssert.AreEqual(testArray, newTextBase[0]);
    }

    [TestMethod]
    public void TextBaseArrayToListIncludingApostropheWords_SplitCharArraystoListIncludingApostropheWords_True()
    {
      //Arrange
      WordCounter TextBaseArray2 = new WordCounter();
      string testText2 = "isn't";
      TextBaseArray2.SetGuideWord(testText2);
      char[] testArray2 = TextBaseArray2.GetGuideWord();

      TextBaseArray2.SetTextBaseWord("Bird-bird, bird. Bird isn't the Word.");
      char[] divisionTextBaseArray2 = TextBaseArray2.GetTextBaseWord();

      //Act
      TextBaseArray2.SetTextBase(divisionTextBaseArray2);
      List<char[]> newTextBase2 = TextBaseArray2.GetTextBase();

      //Assert
      CollectionAssert.AreEqual(testArray2, newTextBase2[5]);
    }

    [TestMethod]
    public void GuideWordMatchesTextBaseWords_ThereAreMatches_True()
    {
      //Arrange
      WordCounter UserCounter = new WordCounter();
      string userGuideWord = "bird";
      string userTextBase = "Bird-bird, bird. Bird isn't the Word.";

      //Act
      UserCounter.SetMatchCount(userGuideWord, userTextBase);
      int matchCount = UserCounter.GetMatchCount();

      //Assert
      Assert.AreEqual(2, matchCount);
    }

  }
}
