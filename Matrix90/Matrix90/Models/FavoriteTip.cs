using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix90.Models
{
    public class FavoriteTip
    {
        [Key]
        public int FavoriteTipId { get; set; }
        [ForeignKey("TipOfWeek")]
        public int TipOfWeekId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
