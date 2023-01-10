using System;
using System.Collections.Generic;

namespace Cocktail.Models
{
    public class Cocktail
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients {get;set;}
    }
}
