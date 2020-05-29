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
        public string IdentityUserId { get; set; }
        public int Height { get; set; }
        public int StartingWeight { get; set; }
        public int CurrentWeight { get; set; }
        public int GoalWeight { get; set; }
        public int Neck { get; set; }
        public int Arms{ get; set; }
        public int Hips { get; set; }
        public int Waist { get; set; }
        public int Chest { get; set; }
        public int Thigh { get; set; }
        public int Calves { get; set; }

    }
}
