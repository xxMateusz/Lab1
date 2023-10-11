using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using System.Diagnostics;

namespace Lab1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About(string author, int? id)

        {
            // string author = Request.Query["author"];
            //string strid = Request.Query["id"];
            //if(int.TryParse(strid,out var id))
            //{

            //}
            //ViewBag.Author = author + " id = " + id;
            if (id == null || author == null)
            {
                return BadRequest();
            }
            ViewBag.Author = author + " id= " + id;
            return View();
        }
        public IActionResult Calculator([FromQuery(Name = "operator")] Operators op, double? x, double? y)
        { {
                if (op == null || x == null || y == null)
                { return BadRequest(); }
            }
            string r = "";
            switch (op)
            {
                case Operators.Add:
                    r = $"{x} + {y} = {x+y}";
                    break;
                case Operators.Sub:
                    r =$"{x} - {y} = {x - y}";
                    break;

            }

            ViewBag.wynik = r;
            {

                //if (op == "add")
                //{
                //    ViewBag.wynik = x + y;
                //}
                //else if(op =="sub")
                //{
                //    ViewBag.wynik = y * x;
                //}
                //else if(op == "div")
                //{
                //    ViewBag.wynik = x / y;
                //}
                //else if (op == "mul")
                //{
                //  ViewBag.wynik = (x - y);
                //}


                // return View();
            } }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}