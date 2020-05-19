using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerMeasurements
    {
        [Key]
        public int CustomerMeasurementsId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public int Height { get; set; }
        public int CurrentWeight { get; set; }
        public int GoalWeight { get; set; }
        public int Wrist { get; set; }
        public int Forearm { get; set; }
        public int Hips { get; set; }
        public int Waist { get; set; }

    }
}
