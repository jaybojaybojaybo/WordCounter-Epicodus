using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounters.Models;
using System;

namespace WordCounters.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<WordCounter> CountList = new List<WordCounter>();
        return View(CountList);
      }

      [HttpPost("/match")]
      public ActionResult Matching()
      {
        WordCounter newCounter = new WordCounter();
        string gWord = Request.Form["gWord"];
        string tBase = Request.Form["tBase"];
        newCounter.SetMatchCount(gWord, tBase);
        string userInput1 = newCounter.GetUserInput();
        string userInput2 = newCounter.GetUserInput2();
        string newMatchCount = newCounter.GetMatchCount().ToString();
        char[] getQuizBaseWord = newCounter.GetTextBaseWord();
        Console.WriteLine(getQuizBaseWord);

        return View("Return", newCounter);
      }

  }

}
