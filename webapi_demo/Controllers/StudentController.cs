using Microsoft.AspNetCore.Mvc;

namespace webapi_demo.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return Content("Hello from StudentController!");
    }
}