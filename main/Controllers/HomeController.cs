using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using main.Models;

namespace main.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
