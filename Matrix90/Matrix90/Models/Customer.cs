using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Matrix90.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string CityAddress { get; set; }
        public string StateAddress { get; set; }
        public int ZipAddress { get; set; }
        public string Email { get; set; }
        public double PhoneNumber { get; set; } 
        public string PrefferedMethodOfContact { get; set; }
        public string BestTimeToReach { get; set; }
        public string FrontImage { get; set; }
      
        public string BackImage { get; set; }
        public string ProfileRight { get; set; }
        public string ProfileLeft { get; set; }
        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
