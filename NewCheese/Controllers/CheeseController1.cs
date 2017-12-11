using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewCheese.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewCheese.Controllers
{
    public class CheeseController : Controller
    {       
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();
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
        public IActionResult NewCheese(string name, string description)
        {          
            //accessing the empty constructor i created in the Cheese model class
            Cheese newCheese = new Cheese
            {
                Description = description,
                Name = name
            };
            //Add the new cheese to my existing cheeses by passing it to the Add method
            CheeseData.Add(newCheese);
            return Redirect("/Cheese");
        }

        [HttpGet]
        public IActionResult Remove()
        {
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult Remove(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);            
            }

            return Redirect("/Cheese");
        }
    }
}
