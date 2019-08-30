using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using TinyCsvParser;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public static string pathToData = "App_data/2017 01 AU3 Multichem.csv"; //"../../C:\Users\Professional\source\repos\WebApplication1\App_data/../App_data/2017 01 AU3 Multichem.csv";
        public IActionResult Index()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
            ModelClassMap maper = new ModelClassMap();
            CsvParser<Model> csvParser = new CsvParser<Model>(csvParserOptions, maper);
            var result = csvParser.ReadFromFile(pathToData, Encoding.ASCII).ToList();
           

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
