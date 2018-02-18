using System.Collections.Generic;
using System;
using System.Linq;


namespace WordCounters.Models
{
    public class WordCounter
    {
      private string _userInput;
      private string _userInput2;
      private char[] _guideWord;
      private char[] _textBaseWords;
      private List<char[]> _textBase;
      private int _matchCount;

      private static List<WordCounter> _counterCount = new List<WordCounter> {};

      public void SetUserInput(string userInput)
      {
        _userInput = userInput;
      }

      public string GetUserInput()
      {
        return _userInput;
      }

      public void SetUserInput2(string userInput)
      {
        _userInput2 = userInput;
      }

      public string GetUserInput2()
      {
        return _userInput2;
      }

      public void SetGuideWord(string newGuideWord)
      {
        char[] guideWord = newGuideWord.ToLower().ToCharArray();
        _guideWord = guideWord;
      }

      public char[] GetGuideWord()
      {
        return _guideWord;
      }

      public char[] SetTextBaseWord(string newTextBaseWord)
      {
        char[] textBaseWord = newTextBaseWord.ToLower().ToCharArray();
        _textBaseWords = textBaseWord;
        return _textBaseWords;
      }

      public char[] GetTextBaseWord()
      {
        return _textBaseWords;
      }

      public void SetTextBase(char[] userTextBase)
      {
        List<char[]> TextBase = new List<char[]>();
        List<string> completedWords = new List<string>();
        int userTextBaseLength = userTextBase.Length;
        for (int i = 0; i < userTextBaseLength; i++)
        {
          string letter = userTextBase[i].ToString();
          if (letter == "." || letter == "," || letter == " ")
          {
            string combinedWord = string.Join("", completedWords);
            if (combinedWord == " ")
            {
              completedWords.Clear();
              return;
            }
            else
            {
            TextBase.Add(combinedWord.ToCharArray());
            completedWords.Clear();
            }
          }
          else if (i == userTextBaseLength-1)
          {
            completedWords.Add(letter);
            string combinedWord = string.Join("", completedWords);
            TextBase.Add(combinedWord.ToCharArray());
            completedWords.Clear();
          }
          else
          {
            completedWords.Add(letter);
            // Console.WriteLine(forWords[0]);
          }
        }
        _textBase = TextBase;
      }

      public List<char[]> GetTextBase()
      {
        return _textBase;
      }

      public void SetMatchCount(string userInput1, string userInput2)
      {
        WordCounter UserCounter = new WordCounter();
        UserCounter.SetUserInput(userInput1);
        UserCounter.SetUserInput2(userInput2);
        string userGuideWord = UserCounter.GetUserInput();
        string userTextBase = UserCounter.GetUserInput2();
        UserCounter.SetGuideWord(userGuideWord);
        UserCounter.SetTextBaseWord(userTextBase);
        char[] userGuideWordArray = UserCounter.GetGuideWord();
        char[] userTextBaseArray = UserCounter.GetTextBaseWord();
        UserCounter.SetTextBase(userTextBaseArray);

        char[] GuideWord = UserCounter.GetGuideWord();
        List<char[]> TextBase = UserCounter.GetTextBase();
        int textBaseCount = TextBase.Count;
        int matchCount = 0;
        for (int i = 0 ; i < textBaseCount ; i++)
        {
          if(TextBase[i].SequenceEqual(GuideWord))
          {
            matchCount += 1;
          }
        }
        _userInput = userGuideWord;
        _userInput2 = userTextBase;
        _matchCount = matchCount;
      }

      public int GetMatchCount()
      {
        return _matchCount;
      }

    }
}
