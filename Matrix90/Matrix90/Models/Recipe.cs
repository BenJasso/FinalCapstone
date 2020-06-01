using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string Type { get; set; }
        public string RecipeInfo { get; set; }
        public string RecipeImage { get; set; }
        public string RecipeTitle { get; set; }

        public DateTime uploadDate { get; set; }

    }
}
