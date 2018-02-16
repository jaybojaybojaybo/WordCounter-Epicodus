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

      public char[] SetGuideWord(string newGuideWord)
      {
        char[] guideWord = newGuideWord.ToCharArray();
        _guideWord = guideWord;
        return _guideWord;
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
