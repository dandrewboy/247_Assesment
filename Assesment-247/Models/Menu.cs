using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment_247.Models
{
    public class Menu
    {
        // Name of menu item
        [Display(Name ="Name")]
        public string name { get; set; }
        //Calories menu item has
        [Display(Name = "Amount of Calories")]
        public int calories { get; set; }
        // First ingredient
        [Display(Name = "Ingredient 1:")]
        public string ingredient1 { get; set; }
        // Second ingredient
        [Display(Name = "Ingredient 2:")]
        public string ingredient2 { get; set; }

        // Constructor
        public Menu(string name, int calories, string ingredient1, string ingredient2)
        {
            this.name = name;
            this.calories = calories;
            this.ingredient1 = ingredient1;
            this.ingredient2 = ingredient2;
        }
        // Empty Constructor
        public Menu()
        {

        }
    }
}
