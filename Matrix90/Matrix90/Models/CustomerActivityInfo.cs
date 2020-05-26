using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerActivityInfo
    {
        [Key]
        public int CustomerActivityInfoId { get; set; }
        [ForeignKey("Customer")]
        public string IdentityUserId { get; set; }

        public bool AccessToFacility { get; set; }
        public bool WorkoutRoutine { get; set; }
        public int RoutineTimePerDay { get; set; }
        public int RoutineDaysAWeek { get; set; }

    }
}
