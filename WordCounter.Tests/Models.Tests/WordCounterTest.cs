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
    public void InputToArray_SetUserInputToArray_True()
    {
      string testBird = "Bird";
      char[] birdArray = testBird.ToCharArray();
      WordCounter newGuideArray = new WordCounter();
      char[] testGuideArray = newGuideArray.SetGuideWord("Bird");
      CollectionAssert.AreEqual(birdArray, testGuideArray);
    }
  }
}
