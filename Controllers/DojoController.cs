using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("survey")]
        public IActionResult Method(string name, string email, string location, string language, string comment)
        {
            Survey form = new Survey
            {
                
                Name = name,
                Email = email,
                Location = location,
                Language = language,
                Comment = comment
            };
            System.Console.WriteLine(form.Name);
            return View(form);
        }
    }
}