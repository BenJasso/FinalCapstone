using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
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
        [AllowNull]
        public double Meal1Time { get; set; }
        [AllowNull]
        public string Meal1Entree { get; set; }
        [AllowNull]
        public int Meal1EntreeSize { get; set; }
        [AllowNull]
        public string Meal1Vegetable { get; set; }
        [AllowNull]
        public int Meal1VegetableSize { get; set; }
        [AllowNull]
        public string Meal1Carb { get; set; }
        [AllowNull]
        public int Meal1CarbSize { get; set; }
        [AllowNull]
        public double Meal2Time { get; set; }
        [AllowNull]
        public string Meal2Entree { get; set; }
        [AllowNull]
        public int Meal2EntreeSize { get; set; }
        [AllowNull]
        public string Meal2Vegetable { get; set; }
        [AllowNull]
        public int Meal2VegetableSize { get; set; }
        [AllowNull]
        public string Meal2Carb { get; set; }
        [AllowNull]
        public int Meal2CarbSize { get; set; }
        [AllowNull]
        public double Meal3Time { get; set; }
        [AllowNull]
        public string Meal3Entree { get; set; }
        [AllowNull]
        public int Meal3EntreeSize { get; set; }
        [AllowNull]
        public string Meal3Vegetable { get; set; }
        [AllowNull]
        public int Meal3VegetableSize { get; set; }
        [AllowNull]
        public string Meal3Carb { get; set; }
        [AllowNull]
        public int Meal3CarbSize { get; set; }
        [AllowNull]
        public double Meal4Time { get; set; }
        [AllowNull]
        public string Meal4Entree { get; set; }
        [AllowNull]
        public int Meal4EntreeSize { get; set; }
        [AllowNull]
        public string Meal4Vegetable { get; set; }
        [AllowNull]
        public int Meal4VegetableSize { get; set; }
        [AllowNull]
        public string Meal4Carb { get; set; }
        [AllowNull]
        public int Meal4CarbSize { get; set; }
        [AllowNull]
        public double Meal5Time { get; set; }
        [AllowNull]
        public string Meal5Entree { get; set; }
        [AllowNull]
        public int Meal5EntreeSize { get; set; }
        [AllowNull]
        public string Meal5Vegetable { get; set; }
        [AllowNull]
        public int Meal5VegetableSize { get; set; }
        [AllowNull]
        public string Meal5Carb { get; set; }
        [AllowNull]
        public int Meal5CarbSize { get; set; }
        [AllowNull]
        public double Meal6Time { get; set; }
        [AllowNull]
        public string Meal6Entree { get; set; }
        [AllowNull]
        public int Meal6EntreeSize { get; set; }
        [AllowNull]
        public string Meal6Vegetable { get; set; }
        [AllowNull]
        public int Meal6VegetableSize { get; set; }
        [AllowNull]
        public string Meal6Carb { get; set; }
        [AllowNull]
        public int Meal6CarbSize { get; set; }
        [AllowNull]
        public double Snack1Time { get; set; }
        [AllowNull]
        public string Snack1 { get; set; }
        [AllowNull]
        public int Snack1Size { get; set; }
        [AllowNull]
        public double Snack2Time { get; set; }
        [AllowNull]
        public string Snack2 { get; set; }
        [AllowNull]
        public int Snack2Size { get; set; }
        [AllowNull]
        public double Snack3Time { get; set; }
        [AllowNull]
        public string Snack3 { get; set; }
        [AllowNull]
        public int Snack3Size { get; set; }
        [AllowNull]
        public string Supplement1 { get; set; }
        [AllowNull]
        public string Supplement2 { get; set; }
        [AllowNull]
        public string Supplement3 { get; set; }
        


    }
}
