using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
