using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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
        [Route("method")]
        public IActionResult Method(string name, string email, string location, string language, string comment)
        {
            ViewBag.Name = name;
            System.Console.WriteLine(ViewBag.Name);
            ViewBag.Email = email;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;

            return View("Method");
        }
    }
}