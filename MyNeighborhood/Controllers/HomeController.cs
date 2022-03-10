﻿using Microsoft.AspNetCore.Mvc;
using MyNeighborhood.Core.Constants;
using MyNeighborhood.Models;
using System.Diagnostics;

namespace MyNeighborhood.Controllers
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
            ViewData[MessageConstant.SuccessMessage] = "Урра, успя нещо да тръгне!!!";

            return View();
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