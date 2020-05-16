using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiplicationTables.Models;

namespace MultiplicationTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MultiplyTableListVM model )
        {
            var vm = new MultiplyTableListVM();
            vm.MultiplyTableList = new List<MultiplyTable>();

            for (int iterator = 1; iterator <= 10; iterator++)
            {
                vm.MultiplyTableList.Add(new MultiplyTable {multiplying = iterator, result = (model.numberTable * iterator) });
            }
            ViewBag.numberTable = model.numberTable;
            ViewBag.showTable = true;

            return View("Index", vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
