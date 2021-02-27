using Assesment_247.Business;
using Assesment_247.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment_247.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult MenuReturn()
        {
            Menu m = new Menu();
            string[] reverse = new string[2];
            MenuService ms = new MenuService();
            m.name = Convert.ToString(Request.Form["name"]);
            m.calories = Convert.ToInt32(Request.Form["calories"].ToString());
            m.ingredient1 = Convert.ToString(Request.Form["ingredient1"]);
            m.ingredient2 = Convert.ToString(Request.Form["ingredient2"]);

            reverse = ms.ingredientReverse(m);

            ViewBag.r1 = reverse[0];
            ViewBag.r2 = reverse[1];
            return View(m);
        }
    }
}
