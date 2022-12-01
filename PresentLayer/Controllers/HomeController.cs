
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITaskService taskService;
        TaskTable task;

        public HomeController(ILogger<HomeController> logger, ITaskService taskService)
        {
            _logger = logger;
            this.taskService=taskService;
        }

        public IActionResult Index()
        {
            var result = taskService.ListAllTasks();
            return View(result);
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
