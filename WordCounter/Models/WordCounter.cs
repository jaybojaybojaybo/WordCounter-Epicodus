using System.Collections.Generic;
using System;
using System.Linq;


namespace WordCounters.Models
{
    public class WordCounter
    {
      private string _userInput;
      private char[] _guideWord;
      private List<char[]> _textBase;

      public void SetUserInput(string userInput)
      {
        _userInput = userInput;
      }

      public string GetUserInput()
      {
        return _userInput;
      }

      public void SetGuideWord(char[] newGuideWord)
      {
        _guideWord = newGuideWord;
      }

      public char[] GetGuideWord()
      {
        return _guideWord;
      }
      //
      // public void SetTextBaseWords(List<char[]> textBase)
      // {
      //   _textBase = textBase;
      // }
      //
      // public List<char[]> GetTextBaseWords()
      // {
      //   return _textBase;
      // }
    }
}
