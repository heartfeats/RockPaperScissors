using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers {
    public class HomeController : Controller {

        [HttpGet ("/")]
        public ActionResult Index () {
            return View ();
        }

        // [HttpGet ("/PlayerOne")]
        // public ActionResult PlayerOne () {
        //     return View ();
        // }

        // [HttpPost ("/PlayerTwo")]
        // public ActionResult PlayerTwo () {
        //     return View ();
        // }

        [HttpPost ("/Result")]
        public ActionResult Result () {
            PlayerChoices newPlayerChoices = new PlayerChoices(Request.Form["inputOne"], Request.Form["inputTwo"]);
            return View (newPlayerChoices);
        }

    }
}