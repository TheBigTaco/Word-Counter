using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/result")]
      public ActionResult Result()
      {
        int result = RepeatCounter.CountRepeats(Request.Form["sentence"], Request.Form["word"]);
        return View(result);
      }
    }
}
