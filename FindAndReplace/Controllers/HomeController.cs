using Microsoft.AspNetCore.Mvc;
using FindAndReplace.Models;
using System.Collections.Generic;
using System;

namespace FindAndReplace.Controllers
{
  public class HomeController : Controller
  {
     [HttpGet("/")]
     public ActionResult Index()
     {
       return View();
     }
     [HttpPost("/addArticle")]
     public ActionResult AddArticle()
     {
       string articleInput = Request.Form["article"];
       FindReplace.SetMainArticle(articleInput);
       return View();
     }

     [HttpPost("/findReplace")]
     public ActionResult FindReplace()
     {
       string find = Request.Form["find"];
       string replace = Request.Form["replace"];
       FindReplace findReplace = new FindReplace(find, replace);
       return View(findReplace);
     }
  }
}
