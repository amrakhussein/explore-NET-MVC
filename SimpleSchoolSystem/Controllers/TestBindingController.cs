using Microsoft.AspNetCore.Mvc;

namespace SimpleSchoolSystem.Controllers;



public class TestBindingController : Controller
{

    // route data, form data, query string, if not put default values

    public IActionResult TestPrimitive(int id, string name)
    {
        return Content("OK");
    }
}
