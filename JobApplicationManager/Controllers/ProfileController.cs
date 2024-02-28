using Microsoft.AspNetCore.Mvc;

namespace JobApplicationManager.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}