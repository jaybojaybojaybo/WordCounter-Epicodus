using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using NumberNames.Models;

namespace NumberNames.Models.Tests
{
  [TestClass]
  public class ProjectTest
  {
    [TestMethod]
    public void CollectInputs_SetGuideWord_False()
    {
      GuideWord newGuideWord = new GuideWord();
      newGuideWord.SetGuideWord("bird");
      string testGuideWord = newGuideWord.GetGuideWord();
      Assert.AreEqual("bird", testGuideWord);
    }
  }
}
