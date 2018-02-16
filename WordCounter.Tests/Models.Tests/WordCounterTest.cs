using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounters.Models;

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
      char[] testGuideArray = newGuideArray.SetGuideWord("Bird");
      CollectionAssert.AreEqual(birdArray, testGuideArray);
    }


    [TestMethod]
    public void TextBaseToArray_SetTextBaseToArray_True()
    {
      string testPhrase = "Bird-bird, bird. Bird isn't the Word.";
      char[] CompareTextBaseArray = testPhrase.ToLower().ToCharArray();
      WordCounter newTextBaseArray = new WordCounter();
      char[] testTextBaseArray = newTextBaseArray.SetGuideWord("Bird-bird, bird. Bird isn't the Word.");
      CollectionAssert.AreEqual(CompareTextBaseArray, testTextBaseArray);
    }

    // [TestMethod]
    // public void TextBaseArrayToList_SplitArraytoList_True()
    // {
    //   string testArray = <Bird-bird, bird. Bird isn't the Word.";
    //   char[] CompareTextBaseArray2 = testPhrase2.ToCharArray();
    //
    //
    //   WordCounter newTextBaseArray2 = new WordCounter();
    //   char[] testTextBaseArray2 = newTextBaseArray2.SetGuideWord("Bird-bird, bird. Bird isn't the Word.");
    //
    //   testTextBaseArray2.SetTextBaseWords();
    //
    //   CollectionAssert.AreEqual( , );
    // }
  }
}
