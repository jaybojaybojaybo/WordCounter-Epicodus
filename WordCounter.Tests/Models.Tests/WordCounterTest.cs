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
  }
}
