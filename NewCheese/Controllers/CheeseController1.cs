using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewCheese.Controllers
{
    public class CheeseController : Controller
    {
        static private List<string> Cheeses = new List<string>();
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")] //specify where the form lives
                                // our form has no action method,
                                //so we need this here
        public IActionResult NewCheese(string name)
        {
            //Add new cheese to my existing cheeses
            Cheeses.Add(name);

            return Redirect("/Cheese");
        }
    }
}
