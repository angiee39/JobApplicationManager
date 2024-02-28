using Microsoft.AspNetCore.Mvc;

namespace JobApplicationManager.Controllers;

public class JobsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}