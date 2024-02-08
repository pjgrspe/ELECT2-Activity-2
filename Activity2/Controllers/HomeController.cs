using Activity2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Activity2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly List<TodoItem> _todoItems = new List<TodoItem>
        {
            new TodoItem { Id = 1, Name = "Task1", IsCompleted = false },
            new TodoItem { Id = 2, Name = "Task2", IsCompleted = true },
            new TodoItem { Id = 3, Name = "Task3", IsCompleted = false }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_todoItems);
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
}