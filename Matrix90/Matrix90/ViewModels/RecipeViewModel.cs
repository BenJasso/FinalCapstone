using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.ViewModels
{
    public class RecipeViewModel
    {
        public int RecipeId { get; set; }
        public string Type { get; set; }
        public string RecipeInfo { get; set; }
        public IFormFile RecipeImage { get; set; }

        public DateTime uploadDate { get; set; }
    }
}
