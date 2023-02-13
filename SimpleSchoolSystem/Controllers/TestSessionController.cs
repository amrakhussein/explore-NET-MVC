using Microsoft.AspNetCore.Mvc;

namespace SimpleSchoolSystem.Controllers
{
    public class TestSessionController : Controller
    {
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("name", "Amr");
            HttpContext.Session.SetString("favColor", "Blue");
            return Content("Session Saved");
        }
        public IActionResult GetSession()
        {
            string? name = HttpContext.Session.GetString("name");
            string? color = HttpContext.Session.GetString("favColor");
            return Content($"I'm {name} \n my favorite color is {color}");
        }
    }
}
