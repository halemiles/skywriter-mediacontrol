using System;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using skywriter_mediacontrols.Models;

namespace mediacontrol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControlController : ControllerBase
    {
        private readonly ILogger<ControlController> _logger;
        private readonly MediaControlConfiguration _appSettings;
        
        public ControlController(ILogger<ControlController> logger, IOptions<MediaControlConfiguration> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Content("Available methods: Play, Next, Back");
        }

        [HttpGet]
        [Route("/home/play")]
        public IActionResult Play()
        {
            CallPython("play");
            return Ok();
        }

        [HttpGet]
        [Route("/home/next")]
        public IActionResult Next()
        {
            CallPython("next");
            return Ok();
        }

        [HttpGet]
        [Route("/home/back")]
        public IActionResult Back()
        {
            CallPython("back");
            return Ok();
        }

        private bool CallPython(string action)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = _appSettings.PythonLocation;
            start.Arguments = string.Format("{0} {1}", _appSettings.TriggerMediaButtonLocation, action);
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
            return true;
        }
    }
}
