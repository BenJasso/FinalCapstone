using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class NutritionPlan
    {
        [Key]
        public int NutritionPlanId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public double Meal1Time { get; set; }
        public string Meal1Entree { get; set; }
        public int Meal1EntreeSize { get; set; }
        public string Meal1Vegetable { get; set; }
        public int Meal1VegetableSize { get; set; }
        public string Meal1Carb { get; set; }
        public int Meal1CarbSize { get; set; }
        public double Meal2Time { get; set; }
        public string Meal2Entree { get; set; }
        public int Meal2EntreeSize { get; set; }
        public string Meal2Vegetable { get; set; }
        public int Meal2VegetableSize { get; set; }
        public string Meal2Carb { get; set; }
        public int Meal2CarbSize { get; set; }
        public double Meal3Time { get; set; }
        public string Meal3Entree { get; set; }
        public int Meal3EntreeSize { get; set; }
        public string Meal3Vegetable { get; set; }
        public int Meal3VegetableSize { get; set; }
        public string Meal3Carb { get; set; }
        public int Meal3CarbSize { get; set; }
        public double Meal4Time { get; set; }
        public string Meal4Entree { get; set; }
        public int Meal4EntreeSize { get; set; }
        public string Meal4Vegetable { get; set; }
        public int Meal4VegetableSize { get; set; }
        public string Meal4Carb { get; set; }
        public int Meal4CarbSize { get; set; }
        public double Meal5Time { get; set; }
        public string Meal5Entree { get; set; }
        public int Meal5EntreeSize { get; set; }
        public string Meal5Vegetable { get; set; }
        public int Meal5VegetableSize { get; set; }
        public string Meal5Carb { get; set; }
        public int Meal5CarbSize { get; set; }
        public double Meal6Time { get; set; }
        public string Meal6Entree { get; set; }
        public int Meal6EntreeSize { get; set; }
        public string Meal6Vegetable { get; set; }
        public int Meal6VegetableSize { get; set; }
        public string Meal6Carb { get; set; }
        public int Meal6CarbSize { get; set; }
        public double Snack1Time { get; set; }
        public string Snack1 { get; set; }
        public int Snack1Size { get; set; }
        public double Snack2Time { get; set; }
        public string Snack2 { get; set; }
        public int Snack2Size { get; set; }
        public double Snack3Time { get; set; }
        public string Snack3 { get; set; }
        public int Snack3Size { get; set; }
        public string Supplement1 { get; set; }
        public string Supplement2 { get; set; }
        public string Supplement3 { get; set; }


    }
}
