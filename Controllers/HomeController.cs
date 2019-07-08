using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public IActionResult Method () 
        {
            return View ("Method");
        }

        
        [HttpPost]
        [Route ("result")]
        public IActionResult Result (string name, string location, string language, string comment) 
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View ("Result");
        }
    
        

    }
}