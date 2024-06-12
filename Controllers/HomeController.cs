using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sea_carp.Models;

namespace sea_carp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ToDo[] todos = new[] {
            new ToDo { Id = 1, Description = "Description for Task 1", IsComplete= false, Title = "Task 1"},
            new ToDo { Id = 2, Description = "Description for Task 2", IsComplete= false, Title = "Task 2"},
            new ToDo { Id = 3, Description = "Description for Task 3", IsComplete= false, Title = "Task 3"},
        };

        Buffer buffer = new(s);

        todos.

        return View(todos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
