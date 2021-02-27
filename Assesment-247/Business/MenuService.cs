using Assesment_247.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment_247.Business
{
    public class MenuService
    {
        public string[] ingredientReverse(Menu m)
        {
            // Strings for ingredient 1, ingredient 2, both ingredients reveresed, and a string array to hold the reversed strings
            string i1;
            string i2;
            string r1 = "";
            string r2 = "";
            string[] reverse = new string[2];

            // sets string values to the ingredent 1 & 2 values from the model
            i1 = m.ingredient1;
            i2 = m.ingredient2;

            // Setting up a string reader to read ingredient 1
            using (StringReader sr1 = new StringReader(i1))
            {
                // Stores each character in the string to an array
                char[] set = new char[i1.Length];
                sr1.ReadAsync(set, 0, i1.Length);
                // builds the string in reverse
                for (int i = i1.Length - 1; i >= 0; i--)
                {
                    r1 = r1 + set[i];
                }
                // saves built reversed string 
                reverse[0] = r1;
            }
            using (StringReader sr2 = new StringReader(i2))
            {
                char[] set = new char[i2.Length];
                sr2.ReadAsync(set, 0, i2.Length);
                for (int i = i2.Length - 1; i >= 0; i--)
                {
                    r2 = r2 + set[i];
                }
                reverse[1] = r2;
            }
            // returns array of revered strings
            return reverse; 
        }
    }
}
