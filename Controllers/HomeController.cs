using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mediacontrol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private const string controlLoc = "D:\\code\\general\\mediacontrol\\scripts\\pp.py";
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Content("Available methods: Play, Pause, Stop, Next, Back");
        }

        [HttpGet]
        [Route("/home/play")]
        public IActionResult Play()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\python27\\python.exe";
            start.Arguments = string.Format("{0} {1}", controlLoc, "play");
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using(Process process = Process.Start(start))
            {
                using(StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
            return Ok();
        }

        [HttpGet]
        [Route("/home/next")]
        public IActionResult Next()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\python27\\python.exe";
            start.Arguments = string.Format("{0} {1}", controlLoc, "next");
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using(Process process = Process.Start(start))
            {
                using(StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
            return Ok();
        }

        [HttpGet]
        [Route("/home/back")]
        public IActionResult Back()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\python27\\python.exe";
            start.Arguments = string.Format("{0} {1}", controlLoc, "back");
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using(Process process = Process.Start(start))
            {
                using(StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
            return Ok();
        }
    }
}
