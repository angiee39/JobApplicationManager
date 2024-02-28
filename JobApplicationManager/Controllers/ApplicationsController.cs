using Microsoft.AspNetCore.Mvc;

namespace JobApplicationManager.Controllers;

public class ApplicationsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}