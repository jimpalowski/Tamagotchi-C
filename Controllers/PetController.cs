using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamaG.Models;
using Games.Models;

namespace TamaG.Controllers
{
  public class TamaG : Controller
  {
    [HttpGet("/new")]
      public ActionResult Index()
      {
          return View();
      }

      [HttpGet("/new")]
      public ActionResult CreateForm()
      {
          return View();
      }

      [HttpPost("/new")]
      public ActionResult Create()
      {
          Pet newTamagotchi = new Pet();
          newTamagotchi.SetName(Request.Form["new-name"]);
          newTamagotchi.Save();
          return View("Index", newTamagotchi);
      }

      [HttpPost("/eat")]
      public ActionResult Feed()
      {
          return View("Index");
      }
  }
}
