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
        public int CustomerId { get; set; }
        public double WakeUpTime { get; set; }
        public double BedTime { get; set; }
        public bool SleepDifficulty { get; set; }
        public int NightlyWakeUps { get; set; }
        public double BreakfastTime { get; set; }
        public double LunchTime { get; set; }
        public double DinnerTime { get; set; }
        public bool SnackDuringDay { get; set; }
        public double SnackDuringDayTimes { get; set; }
        public bool EatingTimeFlexibility { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
