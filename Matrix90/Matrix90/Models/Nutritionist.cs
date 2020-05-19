using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class Nutritionist
    {
        [Key]
        public int NutritionistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double PhoneNumber { get; set; }
        [ForeignKey("IdentityUser")] public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
