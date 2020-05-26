using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
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
        public IFormFile FrontImage { get; set; }
        public IFormFile BackImage { get; set; }
        public IFormFile ProfileRight { get; set; }
        public IFormFile ProfileLeft { get; set; }





    }
}
