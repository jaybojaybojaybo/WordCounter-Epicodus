using System.Collections.Generic;
using System;
using System.Linq;


namespace WordCounters.Models
{
    public class WordCounter
    {
      private string _userInput;
      private char[] _guideWord;
      private char[] _textBaseWords;
      private List<char[]> _textBase;
      private int _matchCount;

      private Dictionary<string, string> _puncs = new Dictionary<string, string>(){
        {".", "period"},
        {",", "comma"},
        {" ", "space"}
      };

      public string GetPuncs(string key)
      {
        return _puncs[key];
      }

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
        char[] guideWord = newGuideWord.ToLower().ToCharArray();
        _guideWord = guideWord;
        return _guideWord;
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
        for (int i = 0; i < userTextBase.Length; i++)
        {
          string letter = userTextBase[i].ToString();
          if (letter == ". " || letter == ", " || letter == " ")
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

      public void SetMatchCount(WordCounter UserCounter)
      {
        char[] userGuideWordArray = UserCounter.SetGuideWord(userGuideWord);
        char[] userTextBaseArray = UserCounter.SetTextBaseWord(userTextBase);
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
          else
          {
            return;
          }
        }
        _matchCount = matchCount;
      }

    }
}
