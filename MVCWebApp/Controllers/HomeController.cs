using AzureStorageLibrary;
using AzureStorageLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;
using System.Diagnostics;

namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoSqlStorage<Player> _noSqlStorage;

        public HomeController(INoSqlStorage<Player> noSqlStorage)
        {
            _noSqlStorage = noSqlStorage;
        }

        public async Task<IActionResult> Index()
        {
            var player = new Player
            {
                RowKey = Guid.NewGuid().ToString(),
                PartitionKey = "Young",
                Name = "Ehned",
                Surname = "Memmedov",
                BirthDate = DateTime.Now,
                Salary = 1200,
                Score = 100
            };
            await _noSqlStorage.Add(player);
            ViewBag.products = (await _noSqlStorage.All()).ToList();
            return View();
        }
    }
}
