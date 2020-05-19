using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class CustomerWorkInfo
    {
        [Key]
        public int CustomerWorkInfoId{get;set;}
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public string Occupation { get; set; }
        public string Shift { get; set; }
        public string WorkDays { get; set; }
        public string DailyWorkHours { get; set; }
        public bool ScheduledBreaks { get; set; }
        public bool BringLunchAbility { get; set; }
        public string ActivityLevel { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
