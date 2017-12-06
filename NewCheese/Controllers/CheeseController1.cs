using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewCheese.Controllers
{
    public class CheeseController1 : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> cheeses = new List<string>();

            cheeses.Add("Cheddar");
            cheeses.Add("Provel");
            cheeses.Add("Pepperjack");

            ViewBag.cheeses = cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
