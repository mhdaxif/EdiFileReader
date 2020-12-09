using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoEdiReader.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DemoEdiReader.Controllers
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
            EdiListViewModel model = new EdiListViewModel(); 
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IFormFile formFile)
        {
            EdiListViewModel model = new EdiListViewModel();

            var _ediFileData = new EdiModel();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                try
                {
                    IFormFile currentFile = Request.Form.Files[i];

                    using (var stream = new StreamReader(currentFile.OpenReadStream()))
                    {
                        _ediFileData = EdiParser.ParseData(stream);
                        _ediFileData.FileName = currentFile.FileName;

                        // Just for dumping in UI..
                        _ediFileData.ParsedData = JsonConvert.SerializeObject(_ediFileData);

                        model.EdiList.Add(_ediFileData);
                    };
                }
                catch (Exception ex) { }
                 
            }
 
            return View(model);
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
