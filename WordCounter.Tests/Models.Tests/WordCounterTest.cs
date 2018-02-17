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

    [TestMethod]
    public void TextBaseArrayToList_SplitCharArraystoList_True()
    {
      string testText = "Bird-bird";
      char[] testArray = testText.ToLower().ToCharArray();
      WordCounter TextBaseArray = new WordCounter();
      List<char[]> newTextBase = new List<char[]> {};

      char[] divisionTextBaseArray = TextBaseArray.SetGuideWord("Bird-bird, bird. Bird isn't the Word.");
      List<string> forWords = new List<string>();
      for (int i = 0; i < divisionTextBaseArray.Length; i++)
      {
        string letter = divisionTextBaseArray[i].ToString();
        if (letter == "." || letter == "," || letter == " ")
        {
          // Console.WriteLine("punc");
          string combined = string.Join("", forWords);
          // Console.WriteLine(combined);
          newTextBase.Add(combined.ToCharArray());
          forWords.Clear();
        }
        else
        {
          forWords.Add(letter);
          Console.WriteLine(forWords[0]);
        }
      }
      // char[] outputArray = newTextBase[0];
      // Console.WriteLine(outputArray);
      CollectionAssert.AreEqual(testArray, newTextBase[0]);
    }

    [TestMethod]
    public void TextBaseArrayToListIncludingApostropheWords_SplitCharArraystoListIncludingApostropheWords_True()
    {
      string testText2 = "isn't";
      char[] testArray2 = testText2.ToLower().ToCharArray();
      WordCounter TextBaseArray2 = new WordCounter();
      List<char[]> newTextBase2 = new List<char[]> {};

      char[] divisionTextBaseArray2 = TextBaseArray2.SetGuideWord("Bird-bird, bird. Bird isn't the Word.");
      List<string> forWords2 = new List<string>();
      for (int i = 0; i < divisionTextBaseArray2.Length; i++)
      {
        string letter = divisionTextBaseArray2[i].ToString();
        if (letter == ". " || letter == ", " || letter == " ")
        {
          string combined2 = string.Join("", forWords2);
          if (combined2 == " ")
          {
            forWords2.Clear();
            return;
          }
          else
          {
          newTextBase2.Add(combined2.ToCharArray());
          Console.WriteLine(combined2);
          forWords2.Clear();
          }
        }
        else
        {
          forWords2.Add(letter);
          // Console.WriteLine(forWords[0]);
        }
      }
      // char[] outputArray = newTextBase2[0];
      // Console.WriteLine(outputArray);
      CollectionAssert.AreEqual(testArray2, newTextBase2[3]);
    }

  }
}
