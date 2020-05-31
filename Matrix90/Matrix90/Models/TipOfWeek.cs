using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class TipOfWeek
    {
        [Key]
        public int TipOfWeekId { get; set; }
        public string SubjectName { get; set; }
        public string Tip { get; set; }

        public DateTime uploadDate { get; set; }
    }
}
