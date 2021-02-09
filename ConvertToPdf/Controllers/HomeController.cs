using ConvertToPdf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace ConvertToPdf.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        readonly IGeneratePdf generatePdf;


        public HomeController(ILogger<HomeController> logger, IGeneratePdf generatePdf)
        {
            _logger = logger;
            this.generatePdf = generatePdf;
        }

        public async Task<IActionResult> GetEmplyeeInfo()
        {
            var empObj = new EmplyeeInfo
            {

            }
        }

        public IActionResult Index()
        {
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
