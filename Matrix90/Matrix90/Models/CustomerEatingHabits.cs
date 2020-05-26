using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerEatingHabits
    {
        [Key]
        public int CustomerEatingHabitsId { get; set; }
        [ForeignKey("Customer")]
        public string IdentityUserId { get; set; }
        public string TypicalBreakfast { get; set; }
        public string TypicalLunch { get; set; }
        public string TypicalDinner { get; set; }
        public string TypicalSnack { get; set; }
        public int DrinkSodaAmount { get; set; }
        public int DrinkAlcoholAmount { get; set; }
        public bool FoodAllergies { get; set; }
        public string KindOfFoodAllergies { get; set; }
        public string FavoriteFoods { get; set; }
        public string NonFavoriteFoods { get; set; }
        public string AdditionalInfo { get; set; }


    }
}
