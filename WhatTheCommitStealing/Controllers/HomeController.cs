using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhatTheCommitStealing.Models;
using WhatTheCommitStealing.Repository;

namespace WhatTheCommitStealing.Controllers
{
    public class HomeController : Controller
    {
        private Dwa dwa = new Dwa();

        public IActionResult Index()
        {
            return View(dwa);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Why you here? Heh. Do not you have something to commit?";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Please do not contact us, We do not know either";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
