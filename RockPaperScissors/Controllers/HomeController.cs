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
        
    }
}