using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using practice_robots_bootstrap.Models;
using practice_robots_bootstrap.Services;

namespace practice_robots_bootstrap.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index(int ID)
        {
            
            var robotList = RobotsServices.Builder();
            return View(robotList[ID-1]);
        }
    }
}