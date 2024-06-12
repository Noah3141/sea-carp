using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sea_carp.Models;

namespace sea_carp.Controllers;

public class FooController(ILogger<FooController> logger) : Controller
{
    private readonly ILogger<FooController> _logger = logger;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Bar()
    {
        return View();
    }
    public IActionResult Biz()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
