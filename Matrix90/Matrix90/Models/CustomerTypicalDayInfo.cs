using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerTypicalDayInfo
    {
        [Key]
        public int CustomerTypicalDayInfoId { get; set; }
        [ForeignKey("Customer")]
        public string IdentityUserId{ get; set; }
        public string WakeUpTime { get; set; }
        public string BedTime { get; set; }
        public bool SleepDifficulty { get; set; }
        public int NightlyWakeUps { get; set; }
        public string BreakfastTime { get; set; }
        public string LunchTime { get; set; }
        public string DinnerTime { get; set; }
        public bool SnackDuringDay { get; set; }
        public double SnackDuringDayTimes { get; set; }
        public bool EatingTimeFlexibility { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
